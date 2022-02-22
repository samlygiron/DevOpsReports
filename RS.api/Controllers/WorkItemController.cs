using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RS.api.Models;
using RS.api.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkItemController : ControllerBase
    {
        private readonly IPullRequestService _pullRequestService;
        private readonly IPullRequestStatusesService _pullRequestStatusesService;
        private readonly IWorkItemService _workItemService;

        public WorkItemController(
            IPullRequestStatusesService pullRequestStatusesService,
            IPullRequestService pullRequestService,
            IWorkItemService workItemService)
        {
            _pullRequestStatusesService = pullRequestStatusesService;
            _pullRequestService = pullRequestService;
            _workItemService = workItemService;
        }

        //[Route("ValidateUpdate")]
        //[Authorize]
        //[HttpPost]
        //public async Task<IActionResult> ValidateUpdate(WorkItemParam wiParam)
        //{
        //    string resp = "{ 'status': 0}";
        //    if(wiParam.resource.fields.SystemState.oldValue != "Dev Review" && wiParam.resource.fields.SystemState.newValue != "Dev Review")
        //        return new JsonResult(resp);

        //    List<Relation> lst = wiParam.resource.revision.relations;
        //    foreach (Relation rel in lst)
        //    {
        //        if (rel.attributes.name == "Pull Request")
        //        {
        //            PullRequestParam param = new PullRequestParam()
        //            {
        //                resource = new Resource()
        //                {
        //                    pullRequestId = int.Parse(rel.url.Substring((rel.url.Length - 4)))
        //                }
        //            };

        //            bool wiStatus = await _pullRequestService.ValidateWorkItemStatusAsync(param);

        //            PullRequestStatusParam prParam = new PullRequestStatusParam()
        //            {
        //                context = new ContextModel() { name = "Work Item State" },
        //                state = wiStatus ? PullRequestStatusParam.SUCCESS_STATE : PullRequestStatusParam.FAIL_STATE
        //            };

        //            await _pullRequestStatusesService.SetStatusAsync(param.resource.pullRequestId, prParam);
        //        }
        //    }

        //    return new JsonResult(resp);
        //}

        [Route("UserStory/ValidateUpdate")]
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ValidateUpdateUS(WorkItemParam wiParam)
        {
            string resp = "{ 'status': 0}";
            //Verify if is Task or Bug -> This validation comes from the hook

            //Verify the state of the task
            if (wiParam.resource.fields.SystemState.newValue != "QA")
                return new JsonResult(resp);

            //Get the Parent 
            WorkItemResponse wiParent = await _workItemService.GetDetailAsync(wiParam.resource.revision.fields.SystemParent);
            
            //Verify if is US
            if(wiParent.fields.SystemWorkItemType == "User Story")
            {
                //Get all its childs and verify its status
                List<WorkItemResponse> lstChilds = await _workItemService.GetChildsAsync(wiParam.resource.revision.fields.SystemParent);
                foreach(WorkItemResponse child in lstChilds)
                {
                    //If all are in QA and the US is not QA -> update the status to QA 
                }
            }



            

            return new JsonResult(resp);
        }

        [Route("{WorkItem}/PullRequests")]
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> PullRequest(int workitem)
        {

            var resp = await _workItemService.GetPullRequestAsync(workitem);

            return new JsonResult(resp);
        }


    }
}

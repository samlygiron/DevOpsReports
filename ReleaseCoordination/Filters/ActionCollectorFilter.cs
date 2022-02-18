using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using RS.data.Interfaces;
using RS.data.Model;
using System;

namespace ReleaseCoordination.Filters
{
    public class ActionCollectorFilter : IActionFilter
    {
        public readonly IConectionTrackService ConectionTrackService;

        public ActionCollectorFilter(IConectionTrackService IConectionTrackService)
        {
            this.ConectionTrackService = IConectionTrackService;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

            ConectionTrack obj = new ConectionTrack()
            {
                Path = context.HttpContext.Request.Path,
                Datelog = DateTime.Now,
                Params = JsonConvert.SerializeObject(context.ActionArguments),
                TraceIdentifier = context.HttpContext.TraceIdentifier
            };

            ConectionTrackService.Insert(obj);
        }
    }
}

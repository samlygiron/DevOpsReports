using System.Collections.Generic;

namespace RS.api.Models
{
    public class PullRequestResponse
    {
        public List<WorkItemModel> value { get; set; }

        public string targetRefName { get; set; }

    }


    public class WorkItemModel
    {
        public string id { get; set; }
    }
}

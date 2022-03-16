#nullable disable

namespace RS.data.Model
{
    public partial class WorkItem
    {
        public int WorkItemId { get; set; }
        public int CommitId { get; set; }
        public string Description { get; set; }

        public virtual Commit Commit { get; set; }
    }
}

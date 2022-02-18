using System;
using System.Collections.Generic;

#nullable disable

namespace RS.data.Model
{
    public partial class Commit
    {
        public Commit()
        {
            WorkItems = new HashSet<WorkItem>();
        }

        public int CommitId { get; set; }
        public string Sha { get; set; }
        public string Comment { get; set; }
        public int PullRequest { get; set; }
        public int ReleaseId { get; set; }

        public virtual Release Release { get; set; }
        public virtual ICollection<WorkItem> WorkItems { get; set; }
    }
}

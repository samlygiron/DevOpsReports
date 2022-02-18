using System;
using System.Collections.Generic;

#nullable disable

namespace RS.data.Model
{
    public partial class Release
    {
        public Release()
        {
            Commits = new HashSet<Commit>();
        }

        public int ReleaseId { get; set; }
        public DateTime? Date { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Commit> Commits { get; set; }
    }
}

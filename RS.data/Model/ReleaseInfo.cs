using System;

#nullable disable

namespace RS.data.Model
{
    public partial class ReleaseInfo
    {
        public int ReleaseInfoId { get; set; }
        public DateTime CurrentReleaseDate { get; set; }
        public bool IsOffCycle { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}

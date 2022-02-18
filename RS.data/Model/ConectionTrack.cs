using System;
using System.Collections.Generic;

#nullable disable

namespace RS.data.Model
{
    public partial class ConectionTrack
    {
        public int Id { get; set; }
        public string TraceIdentifier { get; set; }
        public string Path { get; set; }
        public string Params { get; set; }
        public DateTime Datelog { get; set; }
    }
}

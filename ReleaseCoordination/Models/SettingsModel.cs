using Microsoft.Extensions.Configuration;
using System;

namespace ReleaseCoordination.Models
{
    public class SettingsModel
    {
        private readonly IConfiguration configuration;

        public SettingsModel(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Host = configuration.GetSection("AppSettings").GetSection("Host").Value;
            this.CurrentRelease = DateTime.Parse(configuration.GetSection("AppSettings").GetSection("CurrentRelease").Value);
            this.UpdatedDate = DateTime.Parse(configuration.GetSection("AppSettings").GetSection("UpdatedDate").Value);
            this.IsOffCycle = bool.Parse(configuration.GetSection("AppSettings").GetSection("IsOffCycle").Value);
            this.TopIndex = Int32.Parse(configuration.GetSection("AppSettings").GetSection("BC_TopIndex").Value);
            this.TopComment = configuration.GetSection("AppSettings").GetSection("BC_TopComment").Value;

        }


        public string Host { get; set; }
        public DateTime CurrentRelease { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsOffCycle { get; set; }

        //Branch comparison

        public int TopIndex { get; set; }
        public string TopComment { get; set; }

        //###
    }
}

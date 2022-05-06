using System;
using System.Text.Json.Serialization;

namespace RS.data.Model
{
    public class ExcelReportModel
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("State")]
        public string State { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("ParentId")]
        public int ParentId { get; set; }

        [JsonPropertyName("Priority")]
        public int Priority { get; set; }

        [JsonPropertyName("WorkItemType")]
        public string WorkItemType { get; set; }

        [JsonPropertyName("ReleaseDate")]
        public DateTime ReleaseDate { get; set; }

        [JsonPropertyName("ProjectManager")]
        public string ProjectManager { get; set; }

        [JsonPropertyName("IterationPath")]
        public string IterationPath { get; set; }

        [JsonPropertyName("Area")]
        public string Area { get; set; }

        [JsonPropertyName("AssignedTo")]
        public string AssignedTo { get; set; }

        [JsonPropertyName("OriginalEstimate")]
        public int OriginalEstimate { get; set; }

        [JsonPropertyName("RemainingWork")]
        public int RemainingWork { get; set; }

        [JsonPropertyName("CompletedWork")]
        public int CompletedWork { get; set; }

        [JsonPropertyName("DueDate")]
        public DateTime DueDate { get; set; }

        [JsonPropertyName("QAResource")]
        public string QAResource { get; set; }

    }
}
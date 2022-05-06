using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReleaseCoordination.Models;
using System.Collections.Generic;

namespace ReleaseCoordination.Controllers
{
    public class ReleaseController : Controller
    {
        private readonly IConfiguration configuration;

        public ReleaseController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpPost]
        public IActionResult Report([FromBody] ExcelReportModel2 param)
        {
            return Json(param);
        }

        public IActionResult May(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult April(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }
        public IActionResult March(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult FebruaryEpic(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult February(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult January(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult December(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult November(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult October(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult July(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult August(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult September(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }
    }

    public class ExcelReportModel3
    {
        public int Id { get; set; }
    }
    public class ExcelReportModel2
    {
        public List<ExcelReportModel3> rows { get; set; }
    }
    //[JsonPropertyName("Title")]
    //public string Title { get; set; }

    //[JsonPropertyName("State")]
    //public string State { get; set; }

    //[JsonPropertyName("Type")]
    //public string Type { get; set; }

    //[JsonPropertyName("ParentId")]
    //public int ParentId { get; set; }

    //[JsonPropertyName("Priority")]
    //public int Priority { get; set; }

    //[JsonPropertyName("WorkItemType")]
    //public string WorkItemType { get; set; }

    //[JsonPropertyName("ReleaseDate")]
    //public DateTime ReleaseDate { get; set; }

    //[JsonPropertyName("ProjectManager")]
    //public string ProjectManager { get; set; }

    //[JsonPropertyName("IterationPath")]
    //public string IterationPath { get; set; }

    //[JsonPropertyName("Area")]
    //public string Area { get; set; }

    //[JsonPropertyName("AssignedTo")]
    //public string AssignedTo { get; set; }

    //[JsonPropertyName("OriginalEstimate")]
    //public int OriginalEstimate { get; set; }

    //[JsonPropertyName("RemainingWork")]
    //public int RemainingWork { get; set; }

    //[JsonPropertyName("CompletedWork")]
    //public int CompletedWork { get; set; }

    //[JsonPropertyName("DueDate")]
    //public DateTime DueDate { get; set; }

    //[JsonPropertyName("QAResource")]
    //public string QAResource { get; set; }


}

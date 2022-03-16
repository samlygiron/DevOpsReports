using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReleaseCoordination.Models;

namespace ReleaseCoordination.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IConfiguration configuration;

        public DashboardController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Active(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult Completed(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult Counter(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult BranchComparison(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult BranchComparison2(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            ViewBag.TopIndex = model.TopIndex;
            ViewBag.TopComment = model.TopComment;
            return View();
        }

        public IActionResult CurrentRelease(bool isWidget = false)
        {
            SettingsModel model = new SettingsModel(configuration);
            ViewBag.Host = model.Host;
            ViewBag.UpdatedDate = model.UpdatedDate;
            ViewBag.CurrentRelease = model.CurrentRelease;
            ViewBag.IsOffCycle = model.IsOffCycle;
            ViewBag.IsWidget = isWidget;
            return View();
        }

        public IActionResult Released(bool isWidget = false)
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
}

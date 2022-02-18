using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReleaseCoordination.Models;

namespace ReleaseCoordination.Controllers
{
    public class ReleaseController : Controller
    {
        private readonly IConfiguration configuration;

        public ReleaseController(IConfiguration configuration)
        {
            this.configuration = configuration;
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
}

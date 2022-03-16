using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReleaseCoordination.Models;

namespace ReleaseCoordination.Controllers
{
    public class ChartController : Controller
    {
        private readonly IConfiguration configuration;

        public ChartController(IConfiguration configuration)
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
    }
}

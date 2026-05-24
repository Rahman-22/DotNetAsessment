using Microsoft.AspNetCore.Mvc;
using DotNetAsessment.Models;

namespace DotNetAsessment.Controllers
{
    public class DynamicControlController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new DynamicControlViewModel { NumberOfControls = 0 });
        }

        [HttpPost]
        public IActionResult Index(DynamicControlViewModel model)
        {
            if (model.NumberOfControls < 0) model.NumberOfControls = 0;
            return View(model);
        }
    }
}
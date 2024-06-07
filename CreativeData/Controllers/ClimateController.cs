using Microsoft.AspNetCore.Mvc;

namespace CreativeData.Controllers
{
    public class ClimateController : Controller
    {
        public IActionResult Climate()
        {
            return View();
        }
    }
}

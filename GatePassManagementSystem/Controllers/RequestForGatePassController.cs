using Microsoft.AspNetCore.Mvc;

namespace GatePassManagementSystem.Controllers
{
    public class RequestForGatePassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

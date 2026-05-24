using Microsoft.AspNetCore.Mvc;

namespace GatePassManagementSystem.Controllers
{
    public class PendingRequestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

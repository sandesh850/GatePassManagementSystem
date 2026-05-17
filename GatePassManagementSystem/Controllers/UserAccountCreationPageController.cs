using Microsoft.AspNetCore.Mvc;

namespace GatePassManagementSystem.Controllers
{
    public class UserAccountCreationPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

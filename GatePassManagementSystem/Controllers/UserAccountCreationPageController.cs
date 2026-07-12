using GatePassManagementSystem.Data;
using GatePassManagementSystem.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GatePassManagementSystem.Controllers
{
    public class UserAccountCreationPageController : Controller
    {
        // dependency injection
        private readonly AppDb _AppDb;

        public UserAccountCreationPageController(AppDb _appDb)
        {
            _AppDb = _appDb;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserAccountCreationViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserAccountCreationViewModel Model)
        {
            if(!ModelState.IsValid)
            {
                return View(Model);
            }
            else
            {
                return View();
            }
           
        }
    }
}

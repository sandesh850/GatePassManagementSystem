using GatePassManagementSystem.Data;
using GatePassManagementSystem.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GatePassManagementSystem.Controllers
{
    public class ManageUserACCController : Controller
    {
        // dependency injection
        private readonly AppDb _AppDb;

        public ManageUserACCController(AppDb _appDb)
        {
            _AppDb = _appDb;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new ManageUserACCViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(ManageUserACCViewModel Model)
        {
         
            if (!ModelState.IsValid)
            {
                return View(Model);
            }
            else
            {
                return RedirectToAction("Index", "ManageUserACC");
            }

            
        }
    }
}

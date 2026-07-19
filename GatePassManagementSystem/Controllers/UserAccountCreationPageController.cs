using GatePassManagementSystem.Data;
using GatePassManagementSystem.Models.EntityModels;
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
            if (!ModelState.IsValid)
            {
                return View(Model);
            }
            else
            {
                byte[]? img = null;

                if (Model.EmployeePhoto != null)
                {
                    using (var inputImage = new MemoryStream())
                    {
                        await Model.EmployeePhoto.CopyToAsync(inputImage);
                        img = inputImage.ToArray();
                    }
                }

                var TblUserAccountDetails = new TblUserAccountDetails
                {
                    EmployeePhoto = img,
                    EmployeeName = Model.EmployeeName,
                    Username = Model.Username,
                    Password = Model.Password,
                    UserRole = Model.UserRole,
                    ReportingSupervisor = Model.ReportingSupervisor,
                    ReportingManager = Model.ReportingManager,
                    DPM = Model.DPM,
                    UserRoleType = Model.UserRoleType,
                };

                _AppDb.TblUserAccountDetails.Add(TblUserAccountDetails);
                await _AppDb.SaveChangesAsync();

                return RedirectToAction("index", "UserAccountCreationPage");
            }

           

        }
    }
}

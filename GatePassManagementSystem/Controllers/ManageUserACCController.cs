using GatePassManagementSystem.Data;
using GatePassManagementSystem.Models.EntityModels;
using GatePassManagementSystem.Models.ViewModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            //ViewBag.DPM = "Select Department";
            return View(new ManageUserACCViewModel());
        }

        public TblUserAccountDetails? DST_TblUserAccount_details {  get; set; }

        [HttpPost]
        public async Task<IActionResult> Index(ManageUserACCViewModel Model)
        {
            //DST_TblUserAccount_details = await _AppDb.TblUserAccountDetails
            //        .FirstOrDefaultAsync(x => x.Username == Convert.ToInt16(Model.SearchingEPF));

            var result = await _AppDb.TblUserAccountDetails
                .FirstOrDefaultAsync(x => x.Username == Convert.ToInt32(Model.SearchingEPF));

            if (result == null)
            {
                Model.EmployeeName = "No Record Found";
            }
            else
            {
                if(result.EmployeePhoto != null)
                {
                    string imageBase64 = Convert.ToBase64String(result.EmployeePhoto);
                    ViewBag.EmployeeImage = imageBase64;
                    ViewBag.EmployeeName = result.EmployeeName;
                    ViewBag.Username = result.Username;
                    ViewBag.Password = result.Password;
                    ViewBag.UserRole = result.UserRole;
                    ViewBag.DPM = result.DPM;
                    ViewBag.UserRoleType = result.UserRoleType;
                    ViewBag.ReportingSupervisor = result.ReportingSupervisor;
                    ViewBag.ReportingManager = result.ReportingManager;
                }

               
                

            }

            return View(Model);

            //return RedirectToAction("Index", "ManageUserACC");

            //if (!ModelState.IsValid)
            //{
            //    return View(Model);
            //}
            //else
            //{
            //    DST_TblUserAccount_details = await _AppDb.TblUserAccountDetails.FindAsync(Model.SearchingEPF);
            //    Model.EmployeeName = DST_TblUserAccount_details.EmployeeName;

            //    return RedirectToAction("Index", "ManageUserACC");
            //}


        }
    }
}

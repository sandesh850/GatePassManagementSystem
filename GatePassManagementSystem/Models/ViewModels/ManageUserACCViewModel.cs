using System.ComponentModel.DataAnnotations;

namespace GatePassManagementSystem.Models.ViewModels
{
    public class ManageUserACCViewModel
    {
        [Required(ErrorMessage = "Please Enter a EPF No")]
        public string? SearchingEPF { get; set; }

        
        public IFormFile? EmployeePhoto { get; set; }

       
        public string? EmployeeName { get; set; }

       
        public int Username { get; set; }

        
        public string? Password { get; set; }

       
        public string? UserRole { get; set; }

        
        public string? ReportingSupervisor { get; set; }

       
        public string? ReportingManager { get; set; }

        
        public string? DPM { get; set; }

        
        public string? UserRoleType { get; set; }
    }
}

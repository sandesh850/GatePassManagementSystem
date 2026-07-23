using System.ComponentModel.DataAnnotations;

namespace GatePassManagementSystem.Models.ViewModels
{
    public class UserAccountCreationViewModel
    {
        [Required(ErrorMessage ="Please Select a Employee Photo")]
        public IFormFile? EmployeePhoto { get; set;  }

        [Required(ErrorMessage = "Please Enter the Employee Name")]
        public string? EmployeeName { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter the Username (EPF)")]
        public int Username { get; set; }

        [Required(ErrorMessage = "Please Enter the Password")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please Select the User Role")]
        public string? UserRole { get; set; }

        [Required(ErrorMessage = "Please Enter the Reporting Supervisor")]
        public string? ReportingSupervisor { get; set; }

        [Required(ErrorMessage = "Please Select the Reporting Manager")]
        public string? ReportingManager { get; set; }

        [Required(ErrorMessage = "Please Select the Department")]
        public string? DPM { get; set; }

        [Required(ErrorMessage = "Please Select the User Role Type")]
        public string? UserRoleType { get; set; }

    }
}

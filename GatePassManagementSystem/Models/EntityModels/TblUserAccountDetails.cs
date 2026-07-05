using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GatePassManagementSystem.Models.EntityModels
{
    public class TblUserAccountDetails
    {
        [Key]
        public int TblId { get; set; }


        [Required, Column(TypeName = "VARBINARY(MAX)")]
        public byte[]? EmployeePhoto { get; set; }


        [Required, Column(TypeName = "varchar(40)")]
        public string? EmployeeName { get; set; }


        [Required, Column(TypeName = "int")]
        public int Username { get; set; } // EPF


        [Required, Column(TypeName = "varchar(10)")]
        public string? Password { get; set; }


        [Required, Column(TypeName = "varchar(20)")]
        public string? UserRole { get; set; }


        [Required, Column(TypeName = "varchar(40)")]
        public string? ReportingSupervisor { get; set; }


        [Required, Column(TypeName = "varchar(40)")]
        public string? ReportingManager { get; set; }


        [Required, Column(TypeName = "varchar(20)")]
        public string? DPM { get; set; }


        [Required, Column(TypeName = "varchar(15)")]
        public string? UserRoleType { get; set; } // special or normal

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GatePassManagementSystem.Models.EntityModels
{
    public class TblAllPendingRequests
    {
        [Key]
        public int TblId { get; set; }


        [Required, Column(TypeName = "int")]
        public int EPF { get; set; }


        [Required, Column(TypeName = "varchar(40)")]
        public string? EmployeeName { get; set; }


        [Required, Column(TypeName = "varchar(20)")]
        public string? EmployeeRole { get; set; }


        [Required, Column(TypeName = "varchar(20)")]
        public string? DPM { get; set; }


        [Required, Column(TypeName = "varchar(100)")]
        public string? Reason { get; set; }


        [Required, Column(TypeName = "varchar(30)")]
        public string? VehicleNo { get; set; }


        [Required]
        public DateTime OutTime { get; set; }


        [Required]
        public DateTime InTime { get; set; }


        [Required, Column(TypeName = "varchar(15)")]
        public string? UserRoleType { get; set; } // special or normal


        [Required, Column(TypeName = "date")]
        public DateTime RequestCreatedDate { get; set; }

    }
}

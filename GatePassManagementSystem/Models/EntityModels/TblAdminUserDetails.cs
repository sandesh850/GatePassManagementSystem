using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GatePassManagementSystem.Models.EntityModels
{
    public class TblAdminUserDetails
    {
        [Key]
        public int TblId { get; set; }

        [Required,Column(TypeName ="int")]
        public int Username {  get; set; }// EPF number


        [Required, Column(TypeName = "varchar(10)")]
        public int Password { get; set; }


        [Required, Column(TypeName = "varchar(40)")]
        public string? Name { get; set; }


    }
}

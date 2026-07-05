using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GatePassManagementSystem.Models.EntityModels
{
    public class TblAdminAccessDetails
    {
        [Key]
        public int TblId { get; set; }

        [Column(TypeName ="varchar(40)")]
        public int Name { get; set; }

        [Column(TypeName ="date")]
        public DateTime LogINdate { get; set; }

        [Column(TypeName = "date")]
        public DateTime LogINtime { get; set; }

    }
}

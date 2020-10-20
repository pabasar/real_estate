using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
    [Table("Rent_tbl")]
    public class Rent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String PropertyNo { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        public String PType { get; set; }

        public int Rooms { get; set; }

        [ForeignKey("Owner")]

        [Column("RefOwnerNo")]
        public String OwnerRef { get; set; }
        public virtual Owner Owner { get; set; }

        [ForeignKey("Staff")]

        [Column("RefStaffNo")]
        public String StaffRef { get; set; }
        public virtual Staff Staff { get; set; }

        [ForeignKey("Branch")]

        [Column("RefBranchNo")]
        public String BranchRef { get; set; }
        public virtual Branch Branch { get; set; }

        public int Rent1 { get; set; }


    }
}
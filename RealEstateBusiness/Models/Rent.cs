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
        [Display(Name = "Property Number")]
        public String PropertyNo { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        [Display(Name = "Property Type")]
        public String PType { get; set; }

        public int Rooms { get; set; }

        [ForeignKey("Owner")]

        [Display(Name = "Owner Number")]
        [Column("RefOwnerNo")]
        public String OwnerRef { get; set; }
        public virtual Owner Owner { get; set; }

        [ForeignKey("Staff")]

        [Display(Name = "Staff Number")]
        [Column("RefStaffNo")]
        public String StaffRef { get; set; }
        public virtual Staff Staff { get; set; }

        [ForeignKey("Branch")]

        [Display(Name = "Branch Number")]
        [Column("RefBranchNo")]
        public String BranchRef { get; set; }
        public virtual Branch Branch { get; set; }

        [Display(Name = "Rents")]
        public int Rent1 { get; set; }


    }
}
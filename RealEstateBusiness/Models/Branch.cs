using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
    [Table("Branch_tbl")]
    public class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Branch Number")]
        [Required(AllowEmptyStrings = false)]
        public String BranchNo { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        [Display(Name = "Post Code")]
        public String PostCode { get; set; }

        public List<Staff> Staffs { get; set; }

        public List<Rent> Rents { get; set; }
    }
}
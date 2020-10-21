using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
    [Table("Staff_tbl")]
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Staff Number")]
        [Required]
        public String StaffNo { get; set; }

        [Display(Name = "First Name")]
        public String FName { get; set; }

        [Display(Name = "Last Name")]
        public String LName { get; set; }

        public String Position { get; set; }

        [Display(Name = "Date of Birth")]
        [Column(TypeName ="Date")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [DataType(DataType.Currency)]
        public int Salary { get; set; }

        public List<Rent> Rents { get; set; }

        [ForeignKey("Branch")]

        [Display(Name = "Branch Number")]
        [Column("BranchNo")]
        public String BranchRef { get; set; }
        public virtual Branch Branch { get; set; }


    }
}
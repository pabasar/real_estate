using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String StaffNo { get; set; }

        public String FName { get; set; }

        public String LName { get; set; }

        public String Position { get; set; }

        public DateTime DOB { get; set; }

        public int Salary { get; set; }

        public List<Rent> Rents { get; set; }

        [ForeignKey("Branch")]

        [Display(Name = "Branch_BranchNo")]
        public String BranchRef { get; set; }
        public virtual Branch Branch { get; set; }


    }
}
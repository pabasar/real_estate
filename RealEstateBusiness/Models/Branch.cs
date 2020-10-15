using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
    public class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String BranchNo { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        public int PostCode { get; set; }

        public List<Staff> Staffs { get; set; }

        public List<Rent> Rents { get; set; }
    }
}
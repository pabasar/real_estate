using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
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
        public String OwnerRef { get; set; }
        public virtual Staff RefOwnerNo { get; set; }

        [ForeignKey("Staff")]
        public String StaffRef { get; set; }
        public virtual Staff RefStaffNo { get; set; }

        [ForeignKey("Branch")]
        public String BranchRef { get; set; }
        public virtual Staff RefBranchNo { get; set; }


    }
}
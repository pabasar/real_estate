using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
    public class Owner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String OwnerNo { get; set; }

        public String FName { get; set; }

        public String LName { get; set; }

        public String Address { get; set; }

        public String TelNo { get; set; }

        public List<Rent> Rents { get; set; }
    }
}
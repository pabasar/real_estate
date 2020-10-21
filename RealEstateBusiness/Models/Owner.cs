using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
    [Table("Owner_tbl")]
    public class Owner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner Number")]
        [Required]
        public String OwnerNo { get; set; }

        [Display(Name = "First Name")]
        public String FName { get; set; }

        [Display(Name = "Last Name")]
        public String LName { get; set; }

        [DataType(DataType.MultilineText)]
        public String Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telephone Number")]
        public String TelNo { get; set; }

        public List<Rent> Rents { get; set; }
    }
}
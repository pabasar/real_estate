using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
    public class BusinessContext:DbContext
    {
        public DbSet<Branch> Branches { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Harjoitustyo2.Models
{
    public class Harjoitustyo2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Harjoitustyo2Context() : base("name=Harjoitustyo2Context")
        {
        }

        public System.Data.Entity.DbSet<Harjoitustyo2.Models.Owner> Owners { get; set; }

        public System.Data.Entity.DbSet<Harjoitustyo2.Models.Car> Cars { get; set; }
    
    }
}

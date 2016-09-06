using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Round2.Models
{
    public class Round2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Round2Context() : base("name=Round2Context")
        {
        }

        public System.Data.Entity.DbSet<Round2.Models.Review> Reviews { get; set; }

        public System.Data.Entity.DbSet<Round2.Models.Category> Categories { get; set; }
    }
}

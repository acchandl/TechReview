using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Round2.Models
{
    public class Category
    {
        [Key]

        //fields added for Review 

        public int ID { get; set; }
        public string Title { get; set; }
        //public string Content { get; set; }



        //may lead to dropdown menu
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
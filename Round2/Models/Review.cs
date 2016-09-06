using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Round2.Models
{
    public class Review
    {

        //fields added for Review 
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //make more fields

        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        //may be related to the dropdown box as well
        public virtual Category Category { get; set; }


    }
}
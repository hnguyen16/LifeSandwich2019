using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LifeSandwich.Models
{
    public class Collection
    {
        public int CollectionID { get; set; }

        [Required()]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "you're dumb")]
        public string name { get; set; } 
        public DateTime createdOnDate { get; set; } = DateTime.Now;
        public DateTime? dateMotified { get; set; } = DateTime.Now;
        public List<Image> images { get; set; }

    }
}
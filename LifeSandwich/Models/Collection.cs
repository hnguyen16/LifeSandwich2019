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
        public string Name { get; set; } 
        public DateTime CreatedOnDate { get; set; } = DateTime.Now;
        public DateTime? DateMotified { get; set; } = DateTime.Now;
        public virtual ICollection<Image> Images { get; set; }

    }
}
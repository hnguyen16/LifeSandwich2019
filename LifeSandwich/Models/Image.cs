using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LifeSandwich.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedOnDate { get; set; } = DateTime.Now;
        [ForeignKey("CollectionID")]
        public virtual ICollection<Collection> Collection { get; set; }
        
    }
}
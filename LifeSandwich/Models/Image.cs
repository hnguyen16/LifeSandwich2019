using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LifeSandwich.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public string name { get; set; }
        public string filePath { get; set; }
        public DateTime createdOnDate { get; set; } = DateTime.Now;
    }
}
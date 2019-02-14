using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LifeSandwich.Models
{
    public class ImageCollectionDBContext : DbContext 
    {
        public DbSet<Image> Images { get; set; }
        public DbSet<Collection> Collections { get; set; }

        public ImageCollectionDBContext() : base("ImageDB")
        {

        }
    }
}
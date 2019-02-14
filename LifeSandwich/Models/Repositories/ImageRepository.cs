using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LifeSandwich.Models.Repositories
{
    public class ImageRepository : Repository<Image>
    {
        public List<Image> findImage(string name)
        {
            return DbSet.Where(c => c.Name.Contains(name)).ToList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LifeSandwich.Models.Repositories
{
    public class CollectionRepository : Repository<Collection>
    {
        public List<Collection> findCollection(string name)
        {
            return DbSet.Where(c => c.Name.Contains(name)).ToList();
        }

        //detail
    }
}
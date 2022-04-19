using CatalogServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogServices.Services
{
    public class RepoCategory : Icategory
    {
        public List<Category> FindList()
        {
            try
            {
                return new List<Category>
                {
                    new Category{ ID=1,Name="cat1"},
                    new Category{ ID=2,Name="cat2"}
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

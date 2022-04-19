using ProductServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Services
{
    public class RepoProduct : Iproduct
    {
        public List<Product> FindList()
        {
            try
            {
                return new List<Product>
                {
                    new Product{ ID=1,Name="product1"},
                    new Product{ ID=2,Name="product2"}
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

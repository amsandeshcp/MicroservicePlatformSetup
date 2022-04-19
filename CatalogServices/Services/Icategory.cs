using CatalogServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogServices.Services
{
    public interface Icategory
    {
        List<Category> FindList();
    }
}

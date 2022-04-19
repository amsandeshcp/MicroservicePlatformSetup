using LibCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogServices.Models
{
    public class Category: DateIU
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

using CatalogServices.Models;
using CatalogServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private Icategory _Category;
        public CategoryController(Icategory category)
        {
            _Category = category;
        }

        [Produces("application/json")]
        [HttpGet("findall")]
        public IActionResult FindAll()
        {
            try
            {
                return Ok(_Category.FindList());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPost("create")]
        public IActionResult Create([FromBody] Category category)
        {
            try
            {
                Debug.WriteLine("Product Infor : Post ");
                Debug.WriteLine("Product id:" + category.ID);
                Debug.WriteLine("Product Name:" + category.Name);
                Debug.WriteLine("Product Date:" + category.InsertedDate.ToString());
                return Ok(category);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}

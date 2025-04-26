using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        
   
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<object>
            {
                new { Id = 1, Name = "Laptop", Price = 75000 },
                new { Id = 2, Name = "Mouse", Price = 1200 },
                new { Id = 3, Name = "Keyboard", Price = 2000 }
            };

            return Ok(products);
        }
    }
}
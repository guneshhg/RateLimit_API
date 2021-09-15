using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RateLimit_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategory()
        {
            return Ok(new { Id = 1, Category = "Car" });
        }
        
        [HttpPost]
        public IActionResult SaveProduct()
        {
            return Ok(new { Status = "Success" });
        }


    }
}

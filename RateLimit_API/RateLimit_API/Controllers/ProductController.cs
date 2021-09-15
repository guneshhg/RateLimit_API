﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RateLimit_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(new { Id = 1, Name = "Kalem", Price = 20 });
        }


        [HttpPut]
        public async Task<IActionResult>UpdateProduct()
        {
            return Ok();
        }

        // api/product/kalem/20
        [HttpGet("{name}/{price}")]
        public IActionResult GetProduct(string name,int price)
        {
            return Ok(name);
        }






    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LAB1_API.Controllers
{/*
    [Route("api/[controller]")]
    [ApiController]
    public class TestingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var profession = new Profession
            {
                name = "Software En",
                Description = "software development engenieer"
            };
            return Ok(profession);
        }
        [HttpPost]
        public async Task<Profession> Add([FromForm]IFormFile file)
        {
            using var contentInMemory = new MemoryStream();
            await file.CopyToAsync(contentInMemory);
            var content = Encoding.ASCII.GetString(content.ToArray());


            using (var x = '')
            {

            }
            var profession = new Profession
            {
                name = "se",
                ApiDescription = "sde"
            };
            return profession;
        }
    }*/
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LAB1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class moviesController : ControllerBase
    {

        // GET api/<moviesController>/inorder
        [HttpGet("{traversal}")]
        public ActionResult GetByDate([FromRoute] string traversal)
        {
            traversal = traversal.ToLower();
            var order = 2;
            if (traversal.Equals("preorder"))
            {
                 order = 2 /*Aqui se debe regresar el ordenamiento preorder, a traves del metodo*/;
            }
            else if (traversal.Equals("inorder"))
            {
                 order = 2 /*Aqui se debe regresar el ordenamiento inorder, a traves del metodo*/;
            }
            else if (traversal.Equals("postorder"))
            {
                 order = 2 /*Aqui se debe regresar el ordenamiento postorder, a traves del metodo*/;
            }

            if (order == null) return NotFound();
            //Se devuelve el texto ordenado
            return Ok(order);
        }


        [HttpPost]
        public ActionResult Post([FromBody] string Tipo)
        {
            int cantidadhijos = int.Parse(Tipo);

            
            return BadRequest();
        }



        // GET: api/<moviesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<moviesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<moviesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<moviesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<moviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

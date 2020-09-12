using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB1_API.Helpers;
using LAB1_API.Models;
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
            try
            {
                traversal = traversal.ToLower();
                List<mMovies> Result = new List<mMovies>();
                if (traversal.Equals("preorder"))
                {
                    Result = Storage.MoviesTree.MultiwayPeli.Preorder();
                }
                else if (traversal.Equals("inorder"))
                {
                    Result = Storage.MoviesTree.MultiwayPeli.Inorder();
                }
                else if (traversal.Equals("postorder"))
                {
                    Result = Storage.MoviesTree.MultiwayPeli.Postorder();
                }
                return Created("", Result);
            }
            catch
            {
                return Ok("Data export failed");
            }
        }

        //Post para recibir el orden del MultiWayTree
        [HttpPost]
        public ActionResult Post([FromBody] mTree Tree)
        {
            try
            {
                if(!(Tree.Order<1))
                {
                    Storage.MoviesTree.Order = Tree.Order;
                    Storage.MoviesTree.MultiwayPeli.SetM(Tree.Order);
                    return Ok("El orden del árbol es:" + Tree.Order);
                }
                else
                {
                    return Ok("El orden debe ser mayor a 1");
                }
            }
            catch
            {
                return BadRequest();
            }
        }


        // GET: api/<moviesController>
        [HttpPost]
        public ActionResult Post([FromBody] List<mMovies> movList)
        {
            try
            {
                if(Storage.MoviesTree.MultiwayPeli!=null)
                {
                    foreach (mMovies pelicula in movList)
                    {
                        Storage.MoviesTree.MultiwayPeli.InsertMultiWay(pelicula);  
                    }
                    return Ok("OK");
                }
                return Ok("InternalServerError");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


    }
}

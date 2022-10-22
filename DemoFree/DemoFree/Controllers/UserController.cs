using DemoFree.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFree.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        shrihegde_SampleDBContext db = new shrihegde_SampleDBContext();


        [Route("register")]
        [HttpPost]
        public IActionResult GetPeople([FromBody]Table table)
        {
            db.Tables.Add(table);

            
            return Ok("Registered");
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            var res = db.People.ToList();

            return res;
            //return Ok("Registered");
        }

    }
}

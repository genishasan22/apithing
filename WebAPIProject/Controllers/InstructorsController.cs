using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class InstructorsController : ApiController
    {
        Instructors[] instructors = new Instructors[]
       {
            new Instructors { Id = 1, Name = "Hasan", LastName = "Geniş", Age = 23, DanceCategory ="Bachata",Information = "BlaBla" },
            new Instructors { Id = 2, Name = "Atalay", LastName = "Orçin", Age = 21, DanceCategory ="Salsa",Information = "BlaBla" },
            new Instructors { Id = 3, Name = "Merve", LastName = "Çolak", Age = 26, DanceCategory ="Salsa",Information = "BlaBla" }
       };

        // GET api/values
        public IEnumerable<Instructors> GetAllInstrocturs()
        {
            return instructors;
        }

        // GET api/values/5
        public IHttpActionResult GetInstructor(int id)
        {
            var instructor = instructors.FirstOrDefault((p) => p.Id == id);
            if (instructor == null)
            {
                return NotFound();
            }
            return Ok(instructor);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

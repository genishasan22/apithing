using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class LecturesController : ApiController
    {
        Lecture[] lectures = new Lecture[]
       {
            new Lecture { Id = 1, Name = "Hasan", Day = "Geniş", Time = 23, Price =96,Information = "BlaBla" },
            new Lecture { Id = 2, Name = "Atalay",Day = "Geniş", Time = 23, Price =96,Information = "BlaBla" },
            new Lecture { Id = 3, Name = "Merve", Day = "Geniş", Time = 23, Price =96,Information = "BlaBla" }
       };

        // GET api/values
        public IEnumerable<Lecture> GetAllInstrocturs()
        {
            return lectures;
        }

        // GET api/values/5
        public IHttpActionResult GetInstructor(int id)
        {
            var lecture = lectures.FirstOrDefault((p) => p.Id == id);
            if (lecture == null)
            {
                return NotFound();
            }
            return Ok(lecture);
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

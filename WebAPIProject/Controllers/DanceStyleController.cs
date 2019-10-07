using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class DanceStyleController : ApiController
    {
        DanceStyle[] styles = new DanceStyle[]
       {
            new DanceStyle { Id = 1, Name = "Hasan", Origin = "Geniş", Information = "BlaBla" },
            new DanceStyle { Id = 2, Name = "Atalay",Origin = "Geniş", Information = "BlaBla" },
            new DanceStyle { Id = 3, Name = "Merve", Origin = "Geniş",Information = "BlaBla" }
       };

        // GET api/values
        public IEnumerable<DanceStyle> GetAllInstrocturs()
        {
            return styles;
        }

        // GET api/values/5
        public IHttpActionResult GetInstructor(int id)
        {
            var style = styles.FirstOrDefault((p) => p.Id == id);
            if (style == null)
            {
                return NotFound();
            }
            return Ok(style);
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

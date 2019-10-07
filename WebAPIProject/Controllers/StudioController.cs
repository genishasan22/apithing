using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIProject.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Results;

namespace WebAPIProject.Controllers
{
    public class StudioController : ApiController
    {
        List<Studio> studios =  new List<Studio>();
        //Studio[] studios = new Studio;
        //{
        //     new Studio { Id = 1, Name = "Hasan", Address = "Geniş", Information = "BlaBla" },
        //     new Studio { Id = 2, Name = "Atalay",Address = "Geniş", Information = "BlaBla" },
        //     new Studio { Id = 3, Name = "Merve", Address = "Geniş",Information = "BlaBla" }
        //};


        // GET api/values
        [HttpGet]
        [Route("api/Studio")]
        public JsonResult<List<Studio>> GetAllInstrocturs()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"C:\Users\HGENIS\source\repos\WebAPIProject\WebAPIProject\JSONFiles\studios.json");
            var studios1 = JsonConvert.DeserializeObject <List<Studio>> (json);
            foreach (var item in studios1)
            {
                Studio s = new Studio();
                s.Id = item.Id;
                s.Name = item.Name;
                s.Address = item.Address;
                s.Information = item.Information;
                this.studios.Add(s);
            }
            return Json<List<Studio>>(studios);
        }

        // GET api/values/5
        public IHttpActionResult GetInstructor(int id)
        {
            var studio = studios.FirstOrDefault((p) => p.Id == id);
            if (studio == null)
            {
                return NotFound();
            }
            return Ok(studio);
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

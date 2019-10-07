using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebAPIProject.Models;
using WebAPIProject.Utility;

namespace WebAPIProject.MVCController
{
    public class StudiosController : Controller
    {
        // GET: Studios
        public ActionResult Index()
        {
            try
            {
                ServiceRepository serviceObj = new ServiceRepository();
                HttpResponseMessage response = serviceObj.GetResponse("api/Studio");
                response.EnsureSuccessStatusCode();
                List<Models.Studio> products = response.Content.ReadAsAsync<List<Models.Studio>>().Result;
                //ViewBag.Title = "All Products";
                return View("Studio");
            }
            catch (Exception)
            {
                throw;
            }
            //var client = new HttpClient();
            //var response = client.GetAsync("https://localhost:44328/api/Studio").Result;
            //var studios = response.Content.ReadAsAsync<IEnumerable<Studio>>().Result;
            //Studio model = new Studio();
            //foreach (var item in studios)
            //{
            //    model.Address = item.Address;
            //    model.Id = item.Id;
            //    model.Name = item.Name;
            //    model.Information = item.Information;
            //}
            //return View(model);
        }
    }
}
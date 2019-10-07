using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIProject.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public string Day { get; set; }
        public int Price { get; set; }
        public string Information { get; set; }
    }
}
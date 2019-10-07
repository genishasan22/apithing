using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIProject.Models
{
    public class Instructors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string DanceCategory { get; set; }
        public string Information { get; set; }
    }
}
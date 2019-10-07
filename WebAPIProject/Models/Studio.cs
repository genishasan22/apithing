using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIProject.Models
{
    public class StudioList
    {
        [JsonProperty("Studios")]
        public List<Studio> LogEntries { get; set; }
    }
    public class Studio
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Address")]
        public string Address { get; set; }
        [JsonProperty("Information")]
        public string Information { get; set; }
    }
}
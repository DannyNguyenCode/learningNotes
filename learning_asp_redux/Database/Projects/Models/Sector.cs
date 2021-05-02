using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Projects.Models
{
    public class Sector
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string Description {get;set;}
        [JsonIgnore]
        virtual public List<Technology> Technologies {get;set;}
    }
}
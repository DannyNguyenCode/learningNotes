using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Projects.Models
{
    public class Technology
    {
        public int Id {get;set;}
        public string Name {get;set;}
        [JsonIgnore]
        public virtual List<Sector> Sectors {get;set;}
    }
}
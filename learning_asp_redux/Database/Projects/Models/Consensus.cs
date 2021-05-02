using System;
using System.Collections.Generic;

namespace Projects.Models
{
    public class Consensus
    {
        public int Id {get;set;}
        public string Name {get;set;}

        public virtual List<Technology> Technologies{get;set;}
    }
}
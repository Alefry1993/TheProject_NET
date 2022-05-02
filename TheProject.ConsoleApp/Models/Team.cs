using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheProject.API.Models
{
    public class Team
    {
        public int TeamId {get; set;}
        public string TeamName { get; set; }
        public string LeagueName { get; set; }
        public string logoURL { get; set; }
        public League League { get; set; }


    }
}

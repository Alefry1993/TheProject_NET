using System.Collections.Generic;

namespace TheProject.API.Models
{
    public class League
    {
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
        public string Nationality { get; set; }
        public List<Team> Teams { get; set; }
    }
}

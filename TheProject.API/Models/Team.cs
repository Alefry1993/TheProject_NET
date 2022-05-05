namespace TheProject.API.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
        public string logoURL { get; set; }
        public League League { get; set; }


    }
}

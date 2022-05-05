using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Net;

using System.Text.Json;
using Windows.Storage.Streams;
using Windows.Web.Http;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TheProject.WinUI.TeamPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateTeam : Page
    {
        public CreateTeam()
        {
            this.InitializeComponent();

           
        }



        private async void Create_Click(object sender, RoutedEventArgs e)
        {

            using (HttpClient client = new HttpClient())
            {

                if (TeamName.Text == string.Empty)
                {
                    messageCreate.Text = "Please enter the name of the team";
                }
                else if (TeamDesc.Text == string.Empty)
                {
                    messageCreate.Text = "Please enter a description of the team";
                }
                else if (TeamLogo.Text == string.Empty)
                {
                    messageCreate.Text = "Please enter the logo URL for the team";
                }
                else
                {

                    String TName = TeamName.Text;
                    String TDescription = TeamDesc.Text;
                    String TlogoURL = TeamLogo.Text;
                    
                    Team team = new Team();
                    team.TeamName = TName;
                    team.TeamDescription = TDescription;
                    team.logoURL = TlogoURL;
                    


                    ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    string jsonTeam = JsonSerializer.Serialize(team);
                    Uri uri = new Uri("https://localhost:44301/api/Teams");
                    HttpStringContent content = new HttpStringContent(jsonTeam, UnicodeEncoding.Utf8, "application/json");
                    HttpResponseMessage httpResponseMessage = await client.PostAsync(uri, content);
                    var courses = JsonSerializer.Deserialize<List<Team>>(await client.GetStringAsync(uri));
                    messageCreate.Text = "Team Created!!!";
                    TeamName.Text = string.Empty;
                    TeamDesc.Text = string.Empty;
                    TeamLogo.Text = string.Empty;



                }

            }
        }
    }

    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
        public string logoURL { get; set; }
        public League League { get; set; }


    }

    public class League
    {
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
        public string Nationality { get; set; }
        public List<Team> Teams { get; set; }
    }
}

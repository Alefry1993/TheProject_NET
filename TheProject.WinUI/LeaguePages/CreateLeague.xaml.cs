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

namespace TheProject.WinUI.LeaguePages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateLeague : Page
    {
        public CreateLeague()
        {
            this.InitializeComponent();
        }

        private async void Create_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {

                if (LeagueName.Text == string.Empty)
                {
                    messageCreate.Text = "Please enter the leagues name";
                }
                else if (LeagueNation.Text == string.Empty)
                {
                    messageCreate.Text = "Please enter the leagues Nationality";
                }
                else
                {

                    ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                    String LName = LeagueName.Text;
                    String LNation = LeagueNation.Text;
                    League league = new League();
                    league.LeagueName = LName;
                    league.Nationality = LNation;

                    string jsonLeague = JsonSerializer.Serialize(league);

                    Uri uri = new Uri("https://localhost:44301/api/Leagues");
                    HttpStringContent content = new HttpStringContent(jsonLeague, UnicodeEncoding.Utf8, "application/json");
                    HttpResponseMessage httpResponseMessage = await client.PostAsync(uri, content);
                    var courses = JsonSerializer.Deserialize<List<League>>(await client.GetStringAsync(uri));
                    messageCreate.Text = "Team Created!!!";
                    LeagueName.Text = string.Empty;
                    LeagueNation.Text = string.Empty;
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

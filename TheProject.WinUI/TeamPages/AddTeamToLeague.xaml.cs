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
    public sealed partial class AddTeamToLeague : Page
    {
        public AddTeamToLeague()
        {
            this.InitializeComponent();
            TeamCombobox();
            LeagueCombobox();
        }

        private async void TeamCombobox()
        {
            using (HttpClient client2 = new HttpClient())
            {

                Uri uri = new("https://localhost:44301/api/Teams");
                var listTeames = await client2.GetAsync(uri);
                string jsonTeames = listTeames.Content.ReadAsStringAsync().GetResults();
                var myTeam = Newtonsoft.Json.JsonConvert.DeserializeObject<Team[]>(jsonTeames);

                foreach (var Team in myTeam)
                {
                    TeamBox.Items.Add(new ComboBoxItem { Content = Team.TeamName, Tag = Team.TeamId });
                }
            }
        }

        private async void LeagueCombobox()
        {
            using (HttpClient client2 = new HttpClient())
            {

                Uri uri = new("https://localhost:44301/api/Leagues");
                var listLeagues = await client2.GetAsync(uri);
                string jsonLeagues = listLeagues.Content.ReadAsStringAsync().GetResults();
                var myLeague = Newtonsoft.Json.JsonConvert.DeserializeObject<League[]>(jsonLeagues);

                foreach (var League in myLeague)
                {
                    LeagueBox.Items.Add(new ComboBoxItem { Content = League.LeagueName, Tag = League.LeagueId });
                }
            }

        }

        private async void AddTeam_Click(object sender, RoutedEventArgs e)
        {

            using (HttpClient client = new HttpClient())
            {

                League league = new League();
                var LeagueTag = ((ComboBoxItem)LeagueBox.SelectedItem).Tag.ToString();
                league.LeagueId = int.Parse(LeagueTag);
                Team team = new Team();



                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                string jsonTeam = JsonSerializer.Serialize(team);
                Uri uri = new Uri("https://localhost:44301/api/Teams" + LeagueTag);
                HttpStringContent content = new HttpStringContent(jsonTeam, UnicodeEncoding.Utf8, "application/json");
                HttpResponseMessage httpResponseMessage = await client.PostAsync(uri, content);
                var courses = JsonSerializer.Deserialize<List<Team>>(await client.GetStringAsync(uri));
                messageCreate.Text = "Team Created!!!";

            }
        }
    }
}

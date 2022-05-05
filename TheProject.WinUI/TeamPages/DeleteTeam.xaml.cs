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
    public sealed partial class DeleteTeam : Page
    {
        public DeleteTeam()
        {
            this.InitializeComponent();
            TeamCombobox();
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

        private async void DeleteTeam_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {

                Team team = new Team();
                var TeamTag = ((ComboBoxItem)TeamBox.SelectedItem).Tag.ToString();
                team.TeamId = int.Parse(TeamTag);

                string jsonLeague = JsonSerializer.Serialize(team);

                Uri uri = new Uri("https://localhost:44301/api/Leagues" + TeamTag);
                HttpResponseMessage httpResponseMessage = await client.DeleteAsync(uri);
                messageCreate.Text = "Team Deleted!!!";
                TeamCombobox();
            }
        }
    }
}

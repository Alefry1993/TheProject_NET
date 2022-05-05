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
    public sealed partial class DeleteLeague : Page
    {
        public DeleteLeague()
        {
            this.InitializeComponent();
            LeagueCombobox();
        }

        private async void LeagueCombobox()
        {
            using (HttpClient client2 = new HttpClient())
            {
                LeagueBox.Items.Clear();
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

        private async void DeleteLeague_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {

                League league = new League();
                var LeagueTag = ((ComboBoxItem)LeagueBox.SelectedItem).Tag.ToString();
                league.LeagueId = int.Parse(LeagueTag);

                string jsonLeague = JsonSerializer.Serialize(league);

                Uri uri = new Uri("https://localhost:44301/api/Leagues" + LeagueTag);
                HttpStringContent content = new HttpStringContent(jsonLeague, UnicodeEncoding.Utf8, "application/json");
                HttpResponseMessage httpResponseMessage = await client.DeleteAsync(uri);

                if(httpResponseMessage.IsSuccessStatusCode)
                {
                    messageCreate.Text = "League Deleted!!!";
                    LeagueBox.Items.Clear();
                    LeagueCombobox();
                }
                messageCreate.Text = $"{httpResponseMessage.StatusCode}";


            }
        }
    }
}

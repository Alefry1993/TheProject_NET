using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TheProject.WinUI.LeaguePages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReadLeague : Page
    {
        public ReadLeague()
        {
            this.InitializeComponent();
        }

        private async void Read_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                var listemedleagues = await client.GetAsync("https://localhost:44301/api/Leagues");
                listemedleagues.EnsureSuccessStatusCode();
                string jsonLeague = listemedleagues.Content.ReadAsStringAsync().Result;
                var myLeague = JsonConvert.DeserializeObject<League[]>(jsonLeague);
                boxBorder.Visibility = Visibility.Visible;
                Read.Visibility = Visibility.Collapsed;
                if (listemedleagues.IsSuccessStatusCode)
                {
                    foreach (var league in myLeague)
                    {
                        message.Text += $"\n League ID: {league.LeagueId}\n     League Name: {league.LeagueName}\n     League Nationality: {league.Nationality}\n    League Teams: {league.Teams}";

                    }
                }
                else
                {
                    message.Text = $"Server error code {listemedleagues.StatusCode}";
                }
            }

        }
    }
}

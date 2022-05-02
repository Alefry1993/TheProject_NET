using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;


namespace TheProject.WinUI
{

    public sealed partial class TeamPage : Page
    {
        public TeamPage()
        {
            this.InitializeComponent();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage));
        }

        private void LeagueButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LeaguePage));
        }

        private void TeamButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TeamPage));
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserPage));
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingsPage));
        }
    }
}

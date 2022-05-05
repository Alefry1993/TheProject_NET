using Microsoft.UI.Xaml;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TheProject.WinUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
   
        public MainWindow()
        {
            this.InitializeComponent();

        }
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {

            mainFrame.Navigate(typeof(HomePage));

            HomeButton.BorderThickness = new Thickness(5);
            TeamButton.BorderThickness = new Thickness(0);
            LeagueButton.BorderThickness = new Thickness(0);
            UserButton.BorderThickness = new Thickness(0);
            SettingsButton.BorderThickness = new Thickness(0);

            MenyLeague.Visibility = Visibility.Collapsed;
            MenyTeam.Visibility = Visibility.Collapsed;

        }

        private void LeagueButton_Click(object sender, RoutedEventArgs e)
        {

            HomeButton.BorderThickness = new Thickness(0);
            TeamButton.BorderThickness = new Thickness(0);
            LeagueButton.BorderThickness = new Thickness(5);
            UserButton.BorderThickness = new Thickness(0);
            SettingsButton.BorderThickness = new Thickness(0);

           MenyLeague.Visibility = Visibility.Visible;
           MenyTeam.Visibility = Visibility.Collapsed;

            CreateLeague.BorderThickness = new Thickness(0);
            ReadLeague.BorderThickness = new Thickness(0);
            UpdateLeague.BorderThickness = new Thickness(0);
            DeleteLeague.BorderThickness = new Thickness(0);
        }

        private void CreateLeague_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(LeaguePages.CreateLeague));

            CreateLeague.BorderThickness = new Thickness(5);
            ReadLeague.BorderThickness = new Thickness(0);
            UpdateLeague.BorderThickness = new Thickness(0);
            DeleteLeague.BorderThickness = new Thickness(0);
        }

        private void ReadLeague_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(LeaguePages.ReadLeague));

            CreateLeague.BorderThickness = new Thickness(0);
            ReadLeague.BorderThickness = new Thickness(5);
            UpdateLeague.BorderThickness = new Thickness(0);
            DeleteLeague.BorderThickness = new Thickness(0);
        }

        private void UpdateLeague_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(LeaguePages.UpdateLeague));

            CreateLeague.BorderThickness = new Thickness(0);
            ReadLeague.BorderThickness = new Thickness(0);
            UpdateLeague.BorderThickness = new Thickness(5);
            DeleteLeague.BorderThickness = new Thickness(0);
        }

        private void DeleteLeague_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(LeaguePages.DeleteLeague));

            CreateLeague.BorderThickness = new Thickness(0);
            ReadLeague.BorderThickness = new Thickness(0);
            UpdateLeague.BorderThickness = new Thickness(0);
            DeleteLeague.BorderThickness = new Thickness(5);

        }

        private void TeamButton_Click(object sender, RoutedEventArgs e)
        {

            HomeButton.BorderThickness = new Thickness(0);
            TeamButton.BorderThickness = new Thickness(5);
            LeagueButton.BorderThickness = new Thickness(0);
            UserButton.BorderThickness = new Thickness(0);
            SettingsButton.BorderThickness = new Thickness(0);

            MenyLeague.Visibility = Visibility.Collapsed;
            MenyTeam.Visibility = Visibility.Visible;

            CreateTeam.BorderThickness = new Thickness(0);
            AddTeamToLeague.BorderThickness = new Thickness(0);
            UpdateTeam.BorderThickness = new Thickness(0);
            DeleteTeam.BorderThickness = new Thickness(0);
        }

        private void CreateTeam_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(TeamPages.CreateTeam));

            CreateTeam.BorderThickness = new Thickness(5);
            AddTeamToLeague.BorderThickness = new Thickness(0);
            UpdateTeam.BorderThickness = new Thickness(0);
            DeleteTeam.BorderThickness = new Thickness(0);
        }

        private void AddTeamToLeague_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(TeamPages.AddTeamToLeague));

            CreateTeam.BorderThickness = new Thickness(0);
            AddTeamToLeague.BorderThickness = new Thickness(5);
            UpdateTeam.BorderThickness = new Thickness(0);
            DeleteTeam.BorderThickness = new Thickness(0);
        }

        private void UpdateTeam_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(TeamPages.UpdateTeam));

            CreateTeam.BorderThickness = new Thickness(0);
            AddTeamToLeague.BorderThickness = new Thickness(0);
            UpdateTeam.BorderThickness = new Thickness(5);
            DeleteTeam.BorderThickness = new Thickness(0);
        }

        private void DeleteTeam_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(TeamPages.DeleteTeam));

            CreateTeam.BorderThickness = new Thickness(0);
            AddTeamToLeague.BorderThickness = new Thickness(0);
            UpdateTeam.BorderThickness = new Thickness(0);
            DeleteTeam.BorderThickness = new Thickness(5);
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(UserPage));
            HomeButton.BorderThickness = new Thickness(0);
            TeamButton.BorderThickness = new Thickness(0);
            LeagueButton.BorderThickness = new Thickness(0);
            UserButton.BorderThickness = new Thickness(5);
            SettingsButton.BorderThickness = new Thickness(0);

            MenyLeague.Visibility = Visibility.Collapsed;
            MenyTeam.Visibility = Visibility.Collapsed;
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(SettingsPage));

            HomeButton.BorderThickness = new Thickness(0);
            TeamButton.BorderThickness = new Thickness(0);
            LeagueButton.BorderThickness = new Thickness(0);
            UserButton.BorderThickness = new Thickness(0);
            SettingsButton.BorderThickness = new Thickness(5);

            MenyLeague.Visibility = Visibility.Collapsed;
            MenyTeam.Visibility = Visibility.Collapsed;
        }

    }
}

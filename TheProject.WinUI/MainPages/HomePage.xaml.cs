using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TheProject.WinUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }

        private void LeagueButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LeaguePages.CreateLeague));
            

        }

        private void TeamButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TeamPages.CreateTeam));
        }
    }
}

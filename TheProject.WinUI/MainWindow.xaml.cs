using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;


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

        }

        private void LeagueButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(LeaguePage));
            HomeButton.BorderThickness = new Thickness(0);
            TeamButton.BorderThickness = new Thickness(0);
            LeagueButton.BorderThickness = new Thickness(5);
            UserButton.BorderThickness = new Thickness(0);
            SettingsButton.BorderThickness = new Thickness(0);
        }

        private void TeamButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(TeamPage));
            HomeButton.BorderThickness = new Thickness(0);
            TeamButton.BorderThickness = new Thickness(5);
            LeagueButton.BorderThickness = new Thickness(0);
            UserButton.BorderThickness = new Thickness(0);
            SettingsButton.BorderThickness = new Thickness(0);
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(UserPage));
            HomeButton.BorderThickness = new Thickness(0);
            TeamButton.BorderThickness = new Thickness(0);
            LeagueButton.BorderThickness = new Thickness(0);
            UserButton.BorderThickness = new Thickness(5);
            SettingsButton.BorderThickness = new Thickness(0);
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(SettingsPage));
            HomeButton.BorderThickness = new Thickness(0);
            TeamButton.BorderThickness = new Thickness(0);
            LeagueButton.BorderThickness = new Thickness(0);
            UserButton.BorderThickness = new Thickness(0);
            SettingsButton.BorderThickness = new Thickness(5);
        }



    }
}

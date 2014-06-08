using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace AgentsOfChange3
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void textblock_Mission_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Mission_PivotPage.xaml", UriKind.Relative));
        }

        private void Panorama_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count < 1) return;
            if (!(e.AddedItems[0] is PanoramaItem)) return;

            PanoramaItem selectedItem = (PanoramaItem)e.AddedItems[0];

            string strTag = (string)selectedItem.Tag;
            if (strTag.Equals("events"))
            {
                this.ApplicationBar.Mode = ApplicationBarMode.Default;
            }
            
            else //if (strTag.Equals("mission"))
            {
                this.ApplicationBar.Mode = ApplicationBarMode.Minimized;
            }
            
           

        }

        private void stackpanel_TodaysMission_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Mission_PivotPage.xaml", UriKind.Relative));
        }

        private void AppBarMI_Settings_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AboutPage.xaml",UriKind.Relative));
        }

        private void AppBarIB_MoreEvents_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/BrowseAgenada_PivotPage.xaml", UriKind.Relative));
        }

      
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Cool_Music
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        int count;
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if ((UserTXT.Text == "CoolMusic") && (PassTXT.Password == "enjoyment"))
            {
                this.Frame.Navigate(typeof(VideoPlayer),null);
            }
            else if ((UserTXT.Text != "CoolMusic") || (PassTXT.Password != "enjoyment"))
            {
                count += 1;
            }
            if ( count == 3)
            {
                this.Frame.Navigate(typeof(MainPage), null); 
            }
            /*for (count = 0; count <= 3; count++)
            {
                if ((UserTXT.Text == "CoolMusic") && (PassTXT.Text == "enjoyment"))
                {
                    this.Frame.Navigate(typeof(VideoPlayer), null);
                    break;
                }

                else if (count == 3)
                {
                      
                }
            }*/
        }

        private void GospelMusic_Click(object sender, RoutedEventArgs e)
        {
            Username.Visibility = Visibility.Visible ;
            UserTXT.Visibility = Visibility.Visible;
            PassTXT.Visibility = Visibility.Visible;
            Password.Visibility = Visibility.Visible;
            Login.Visibility = Visibility.Visible;
        }
    }
}

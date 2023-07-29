using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media;

namespace Lazy_Tweet
{
    /// <summary>
    /// Interakční logika pro Own_Tweet.xaml
    /// </summary>
    public partial class Own_Tweet : Window
    {
        API new_api;
        OpenFileDialog file;
        public string FILENAME;

        public Own_Tweet(API api)
        {
            InitializeComponent();
            new_api = api;
            file = new OpenFileDialog();
        }
        public Own_Tweet()
        {
            
        }

        public void tweet_Click(object sender, RoutedEventArgs e)
        {
            if(tb_own.Text != null)
            {
                new_api.SendTweet(tb_own.Text, FILENAME);
                FILENAME = null;
                Close();
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            file.DefaultExt = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";

            Nullable<bool> result = file.ShowDialog();

            if (result == true)
            {
                FILENAME = file.FileName;
                addButton.Background = Brushes.Red;
            }
        }
    }
}

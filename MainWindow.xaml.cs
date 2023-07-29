using System.Windows;

namespace Lazy_Tweet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string CONSUMER_KEY = "wXcS57beFdNS8gYtmXd8VCdZO";
        public string CONSUMER_SECRET = "4rvG6BvJCp7F9fHGo9OO5YXBlFG9VCTRO7MGHOUzXjbBZqRa9E";
        public string ACCESS_TOKEN = "1525024819426824192-r69njI0WMpc17OtCOZFGibgPfyVljg";
        public string ACCESS_TOKEN_SECRET = "oaqcNug96Mi4EMg51mIZhc67NGUDKb7dvgS2Z5GGbcWZf";
        API api;
        public  MainWindow()
        {
            InitializeComponent();
            api = new API(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
            DataContext = api;
        }

        private void ownTweet_Click(object sender, RoutedEventArgs e)
        {
            Own_Tweet own = new Own_Tweet(api);
            own.ShowDialog();
        }

        private void account_Click(object sender, RoutedEventArgs e)
        {
            api.Account();
        }

        private void tweet_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)happy.IsChecked)
            {
                api.MoodTweet("happy");
            }
            else if ((bool)sad.IsChecked)
            {
                api.MoodTweet("sad");
            }
            else if ((bool)angry.IsChecked)
            {
                api.MoodTweet("angry");
            }
            else if ((bool)disgusted.IsChecked)
            {
                api.MoodTweet("disgusted");
            }
            else if ((bool)empty.IsChecked)
            {
                api.MoodTweet("empty");
            }
            
        }
    }
}

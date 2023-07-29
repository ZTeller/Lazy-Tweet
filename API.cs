using System;
using System.Linq;
using System.Threading.Tasks;
using Tweetinvi;
using System.Diagnostics;
using System.IO;
using Tweetinvi.Parameters;

namespace Lazy_Tweet
{
    public class API
    {
        public string CONSUMER_KEY { get; set; }
        public string CONSUMER_SECRET { get; set; }
        public string ACCESS_TOKEN { get; set; }
        public string ACCESS_TOKEN_SECRET { get; set; }
        public string USER {get; set; }
        public TwitterClient Client { get; set; }
        Random random;
        public API(string CK, string CS, string AT, string ATS)
        {
            CONSUMER_KEY = CK;
            CONSUMER_SECRET = CS;
            ACCESS_TOKEN = AT;
            ACCESS_TOKEN_SECRET = ATS;
            var userClient = new TwitterClient(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
            Client = userClient;
            random = new Random(); 
            GetUser();
            Task.Delay(1000).Wait();
        }
        async public void GetUser()
        {
            var userClient = new TwitterClient(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
            var user = await userClient.Users.GetAuthenticatedUserAsync();
            USER = user.ToString();
        }
        public void Account()
        {
            Process.Start("https://twitter.com/" + USER);
        }
        public async void SendTweet(string tweet, string path)
        {
            if(path == null)
            {
                await Client.Tweets.PublishTweetAsync(tweet);
            }
            else
            {
                var image = File.ReadAllBytes(path);
                var uploadedImage = await Client.Upload.UploadTweetImageAsync(image);
                var tweetWithImage = await Client.Tweets.PublishTweetAsync(new PublishTweetParameters(tweet)
                {
                    Medias = { uploadedImage }
                });
            }
            
            Tweet_success success = new Tweet_success();
            success.ShowDialog();
        }
        public void MoodTweet(string mood)
        {
            string[] lines = File.ReadAllLines("./"+mood+".txt");
            string line = lines[random.Next(0, lines.Count())];
            SendTweet(line, null);
        }
    }
}

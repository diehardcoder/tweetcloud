using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TweetSharp;

namespace TwitterPuzzle
{
    public class TwitterStatusId : ITwitterCloud
    {
        private string mainImage;
        private List<TweetCloudDetails> objTweetCloud = new List<TweetCloudDetails>();

        public string MainImage
        {
            get { return mainImage; }
            set { mainImage = value; }
        }

        public List<TweetCloudDetails> tweetCloudDetails
        {
            get { return objTweetCloud; }
            set { objTweetCloud = value; }            
        }

        public void GetTopTenTweets()
        {
            var service = new TwitterService(CommonData.ConsumerKey, CommonData.ConsumerSecret);
            service.AuthenticateWith(CommonData.AccessToken, CommonData.AccessTokenSecret);
            
            /*TwitterRateLimitStatus limitStatus = new TwitterRateLimitStatus();           
            if (limitStatus.RemainingHits == 0)
            {
                throw new Exception("Your Twitter limit has exceeded. Please try after sometime");
            }*/

            RetweetsOptions ro = new RetweetsOptions();
            ro.Count = 10;
            ro.Id = CommonData.StatusId;        

            var retweets = service.Retweets(ro).ToArray();

            if (retweets.Count() == 0)
            {
                throw new Exception(@"Sorry Twitter did not respond to your request :(.
                                      May be you have entered a valid StatusId/Twitter handle!");
            }
            
             if (retweets == null)
            {
                 throw new Exception("Your Twitter limit has exceeded. Please try after sometime");
            }

            var retweetsOrdered = from tweetStatus in retweets
                                  orderby tweetStatus.User.FollowersCount descending
                                  select tweetStatus;

            mainImage = retweets[0].RetweetedStatus.User.ProfileImageUrlHttps.Replace("_normal", String.Empty);

            foreach (var tweet in retweetsOrdered)
            {
                objTweetCloud.Add(new TweetCloudDetails(tweet.User.ProfileImageUrl));
            }
        }
    }
}

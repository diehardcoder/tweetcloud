using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TweetSharp;

namespace TwitterPuzzle
{
    public class TwitterTweetHandle : ITwitterCloud
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
            long statusId = GetLatestTweet();
            var service = new TwitterService(CommonData.ConsumerKey, CommonData.ConsumerSecret);
            service.AuthenticateWith(CommonData.AccessToken, CommonData.AccessTokenSecret);

            RetweetsOptions ro = new RetweetsOptions();
            ro.Count = 10;
            ro.Id = statusId;

            var retweets = service.Retweets(ro).ToArray();
            var retweetsOrdered = from tweetStatus in retweets
                                orderby tweetStatus.User.FollowersCount descending
                                select tweetStatus;

            mainImage = retweets[0].RetweetedStatus.User.ProfileImageUrlHttps.Replace("_normal",String.Empty);

            foreach (var tweet in retweetsOrdered)
            {
                objTweetCloud.Add(new TweetCloudDetails(tweet.User.ProfileImageUrl));
            }
        }

        private static long GetLatestTweet()
        {
            long statusId = 0;
            var service = new TwitterService(CommonData.ConsumerKey, CommonData.ConsumerSecret);
            service.AuthenticateWith(CommonData.AccessToken, CommonData.AccessTokenSecret);

            ListTweetsOnUserTimelineOptions userTimeLineOpt = new ListTweetsOnUserTimelineOptions();
            userTimeLineOpt.ScreenName = CommonData.TweetHandle;
            userTimeLineOpt.Count = 1;

            var latestTweet = service.ListTweetsOnUserTimeline(userTimeLineOpt).ToArray();

            statusId = latestTweet[0].Id;

            return statusId;
        }
    }
}
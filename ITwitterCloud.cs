using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitterPuzzle
{
    public interface ITwitterCloud
    {
        string MainImage { get; set; }        
        List<TweetCloudDetails> tweetCloudDetails { get; set; }
        void GetTopTenTweets();
    }

    //Contains required fields and methods for generating Tweetcloud
    public class TweetCloudDetails
    {
        private string profileImageUrl;
        private DateTime lastUpdatedTime;

        public TweetCloudDetails()
        {

        }

        public TweetCloudDetails(string profileImageUrl, DateTime lastUpdatedTime)
        {
            this.profileImageUrl = profileImageUrl;
            this.lastUpdatedTime = lastUpdatedTime;
        }

        public string ProfileImageUrl
        {
            get { return profileImageUrl; }
            set { profileImageUrl = value; }
        }

        public DateTime LastUpdateTime
        {
            get { return lastUpdatedTime; }
            set { lastUpdatedTime = value; }
        }

        public override string ToString()
        {
            return profileImageUrl;
        }
    }
}

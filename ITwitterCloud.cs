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

        public TweetCloudDetails()
        {

        }

        public TweetCloudDetails(string profileImageUrl)
        {
            this.profileImageUrl = profileImageUrl;
        }

        public string ProfileImageUrl
        {
            get { return profileImageUrl; }
            set { profileImageUrl = value; }
        }

        public override string ToString()
        {
            return profileImageUrl;
        }
    }
}

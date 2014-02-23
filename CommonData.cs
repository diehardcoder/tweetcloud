using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwitterPuzzle
{
    /// <summary>
    /// Shared/static data 
    /// </summary>
    public static class CommonData
    {
        //add yur twitter api tokens here
        private static string _consumerKey = "nOpNkgbLqfnEVzirmPdIQ";
        private static string _consumerSecret = "WMqXxNT6Op9TB5hv5dNVCoVkPwJSy4lTAIc6sS23xJM";
        private static string _accessToken = "433510624-0igbiTKSRpW4qX0KAsvJiejdbg9OKZqHbkN2nwce";
        private static string _accessTokenSecret = "BS8rQdBYnUAc2Ybc6rcHLfEwNvkgz3g3NWplnMpBGm6eE";

        private static string _tweetHandle;
        private static long _statusId;

        public static string ConsumerKey { get { return _consumerKey; } }
        public static string ConsumerSecret { get { return _consumerSecret; } }
        public static string AccessToken { get { return _accessToken; } }
        public static string AccessTokenSecret { get { return _accessTokenSecret; } }

        /// <summary>
        /// TweetHandle entered by user
        /// </summary>
        public static string TweetHandle
        {
            get { return _tweetHandle; }
            set { _tweetHandle = value; }
        }

        /// <summary>
        /// Tweet StatusId input by user
        /// </summary>
        public static long StatusId
        {
            get { return _statusId; }
            set { _statusId = value; }
        }
    }
}

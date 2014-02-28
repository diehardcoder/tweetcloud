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
        private static string _consumerKey = "7iT7HQ4EiFPJ3x3988Ahiw";
        private static string _consumerSecret =  "VZIfFrYphBIToiBXIg1rQfERyCOkkAF4UaLMQcBzSs";
        private static string _accessToken = "163168291-rxY6cN1VTrFGBG9HDF7Ee08NsEwirRXQXAVkAfCo";
        private static string _accessTokenSecret = "azcGep27YEQtfx8wKllutCmPykYMjyCDR3DRCMHkD1t9i";

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

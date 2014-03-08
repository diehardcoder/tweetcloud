using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;
using TweetSharp;

namespace TwitterPuzzle
{
    public partial class _Default : System.Web.UI.Page
    {
        List<Image> imgList = new List<Image>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Image[] imgArray = new Image[] { image1, image2, image3, image4, image5, image6, image7, image8, image9, image10 };
            imgList.AddRange(imgArray);
            ComputeCloud();
        }

        private void ComputeCloud()
        {
            ITwitterCloud objTweetCloud = null;

            //cache the state if doesnot exit
            if (Cache[CommonData.TweetHandle] == null)
            {
                try
                {
                    objTweetCloud = _Default.GetTweetCloudType(TweetCloudType.StatusId);
                    objTweetCloud.GetTopTenTweets();                    
                    AddItemToCache(CommonData.TweetHandle, objTweetCloud);
                }

                catch (Exception ec)
                {
                    Response.Write(@"<p style=""color:#000000; font-weight:bold;"">" + ec.Message + "</p>");
                }
            }

            //restore state from cache
            else
            {
                objTweetCloud = (ITwitterCloud)Cache[CommonData.TweetHandle];
            }
            DrawTwitterCloud(objTweetCloud);
        }

        private void DrawTwitterCloud(ITwitterCloud objTweetCloud)
        {
            ClearCloud();
            
            try
            {
                this.mainImg.ImageUrl = objTweetCloud.MainImage;

                for (int i = 0; i < objTweetCloud.tweetCloudDetails.Count; i++)
                {
                    imgList[i].ImageUrl = objTweetCloud.tweetCloudDetails[i].ProfileImageUrl.Replace("_normal", String.Empty);
                    imgList[i].Visible = true;

                    //last Updated time
                    TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                    DateTime initialTime = objTweetCloud.tweetCloudDetails[i].LastUpdateTime;
                    DateTime convertedTime = TimeZoneInfo.ConvertTime(initialTime, TimeZoneInfo.Local, ist);
                    this.lblLastUpdatedTime.Text = "Last Updated: " + convertedTime + " IST";
                }
            }

            catch (Exception ec)
            {
                Response.Write(@"<p style=""color:#000000; font-weight:bold;"">" + ec.Message + "</p>");
            }
        }

        private void ClearCloud()
        {
            foreach (Image img in imgList)
            {
                img.Visible = false;
            }
        }

        private static ITwitterCloud GetTweetCloudType(TweetCloudType tc)
        {
            ITwitterCloud tweetCloud = null;
            switch (tc)
            {
                case TweetCloudType.StatusId:
                    tweetCloud = new TwitterStatusId();
                    break;

                /*case TweetCloudType.TweetHandle:
                    tweetCloud = new TwitterTweetHandle();
                    break;*/
            }
            return tweetCloud;
        }

        private void AddItemToCache(string keyTwitterHandle, ITwitterCloud valueObj)
        {
            CacheItemRemovedCallback onRemove = new CacheItemRemovedCallback(this.RemovedCallback);

            Cache.Insert(keyTwitterHandle,
                    valueObj,
                    null,
                    Cache.NoAbsoluteExpiration,
                    TimeSpan.FromSeconds(3600),
                    CacheItemPriority.Default,
                    onRemove);
        }

        private void RemovedCallback(String k, Object v, CacheItemRemovedReason reason)
        {
            //When the item is expired
            if (reason == CacheItemRemovedReason.Expired)
            {
                //make call to twitter api again and cache the results
                ComputeCloud();
            }
        }
    }
}

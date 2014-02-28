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
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ComputeCloud();
        }

        private void ComputeCloud()
        {
            ITwitterCloud objTweetCloud = null;

            if (tbTwitterHandle.Text != String.Empty)
            {
                long result;
                //Check whether user entered StatusId or TweetHandle
                if (long.TryParse(tbTwitterHandle.Text, out result) == true)
                {
                    CommonData.StatusId = result;

                    //cache the state if doesnot exit
                    if (Cache[CommonData.StatusId.ToString()] == null)
                    {
                        try
                        {
                            objTweetCloud = _Default.GetTweetCloudType(TweetCloudType.StatusId);
                            objTweetCloud.GetTopTenTweets();
                            AddItemToCache(CommonData.StatusId.ToString(), objTweetCloud);
                        }

                        catch (Exception ec)
                        {
                            Response.Write(@"<p style=""color:#ffffff; font-weight:bold;"">" + ec.Message + "</p>");
                        }
                    }

                    //restore state from cache
                    else
                    {
                        objTweetCloud = (ITwitterCloud)Cache[CommonData.StatusId.ToString()];
                    }
                }

                //if user entered TweetHandle instead of StatusId
                else
                {
                    CommonData.TweetHandle = this.tbTwitterHandle.Text;

                    //cache the state if doesnot exit
                    if (Cache[CommonData.TweetHandle] == null)
                    {
                        try
                        {
                            objTweetCloud = _Default.GetTweetCloudType(TweetCloudType.TweetHandle);
                            objTweetCloud.GetTopTenTweets();
                            AddItemToCache(CommonData.TweetHandle, objTweetCloud);
                        }

                        catch (Exception ec)
                        {
                            Response.Write(@"<p style=""color:#ffffff; font-weight:bold;"">" + ec.Message + "</p>");
                        }
                    }

                    //restore state from cache
                    else
                    {
                        objTweetCloud = (ITwitterCloud)Cache[CommonData.TweetHandle];
                    }
                }
            }

            else
            {
                Response.Write(@"<p style=""color:#ffffff; font-weight:bold;"">Please enter a twitter handle or status id</p>");
                return;
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
                }
            }

            catch (Exception ec)
            {
                Response.Write(@"<p style=""color:#ffffff; font-weight:bold;"">" + ec.Message + "</p>");
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

                case TweetCloudType.TweetHandle:
                    tweetCloud = new TwitterTweetHandle();
                    break;
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

            //last Updated time
            this.lblLastUpdatedTime.Text = "Last Updated: "+ DateTime.Now.AddHours(12.0).ToString()+" IST";

            /*TwitterRateLimitStatus limitStatus = new TwitterRateLimitStatus();
            this.remainingHits.Text = "Remaining Hits: " + limitStatus.RemainingHits.ToString();*/
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

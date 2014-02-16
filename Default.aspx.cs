using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwitterPuzzle
{
    public partial class _Default : System.Web.UI.Page
    {
        ITwitterCloud objTweetCloud;
        List<Image> imgList = new List<Image>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Image[] imgArray = new Image[] { image1, image2, image3, image4, image5, image6, image7, image8, image9, image10 };
            imgList.AddRange(imgArray);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbTwitterHandle.Text != String.Empty)
            {
                long result;
                //Check whether user entered StatusId or TweetHandle
                if (long.TryParse(tbTwitterHandle.Text, out result) == true)
                {
                    CommonData.StatusId = result;
                    objTweetCloud = _Default.GetTweetCloudType(TweetCloudType.StatusId);
                }

                else
                {
                    CommonData.TweetHandle = this.tbTwitterHandle.Text;
                    objTweetCloud = _Default.GetTweetCloudType(TweetCloudType.TweetHandle);
                }
            }

            else
            {
                Response.Write(@"<p style=""color:#ffffff; font-weight:bold;"">Please enter a twitter handle or status id</p>");
                return;
            }
            DrawTwitterCloud();
        }

        private void DrawTwitterCloud()
        {
            ClearCloud();
            try
            {
                objTweetCloud.GetTopTenTweets();
                this.mainImg.ImageUrl = objTweetCloud.MainImage;
                
                for (int i = 0; i < objTweetCloud.tweetCloudDetails.Count; i++)
                {
                    imgList[i].ImageUrl = objTweetCloud.tweetCloudDetails[i].ProfileImageUrl.Replace("_normal",String.Empty);
                    imgList[i].Visible = true;
                }
            }

            catch (Exception ec) 
            {
                Response.Write(@"<p style=""color:#ffffff; font-weight:bold;"">"+ec.Message+"</p>");
            }
        }

        private void ClearCloud()
        {
            foreach (Image img in imgList)
            {
                img.Visible = false;
            }
        }

        public static ITwitterCloud GetTweetCloudType(TweetCloudType tc)
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
    }
}

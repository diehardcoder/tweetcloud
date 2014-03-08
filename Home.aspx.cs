using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwitterPuzzle
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnImage_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton image = (ImageButton)sender;
            string imgId = image.ID;

            switch (imgId)
            {
                case "github":
                    CommonData.StatusId = 441620973931200512;
                    CommonData.TweetHandle = "github";
                    Response.Redirect("Default.aspx");
                    break;

                case "timoreilly":
                    CommonData.StatusId = 442025832173678594;
                    CommonData.TweetHandle = "timoreilly";
                    Response.Redirect("Default.aspx");
                    break;

                case "twitter":
                    CommonData.StatusId = 440378821242400770;
                    CommonData.TweetHandle = "twitter";
                    Response.Redirect("Default.aspx");
                    break;

                case "martinfowler":
                    CommonData.StatusId = 441585021250727936;
                    CommonData.TweetHandle = "martinfowler";
                    Response.Redirect("Default.aspx");
                    break;

                case "gvanrossum":
                    CommonData.StatusId = 438831865076514816;
                    CommonData.TweetHandle = "gvanrossum";
                    Response.Redirect("Default.aspx");
                    break;

                case "billgates":
                    CommonData.StatusId = 441227018685136896;
                    CommonData.TweetHandle = "billgates";
                    Response.Redirect("Default.aspx");
                    break;

                case "spolsky":
                    CommonData.StatusId = 442019017188847616;
                    CommonData.TweetHandle = "spolsky";
                    Response.Redirect("Default.aspx");
                    break;

                case "firefox":
                    CommonData.StatusId = 442066393098244096;
                    CommonData.TweetHandle = "firefox";
                    Response.Redirect("Default.aspx");
                    break;

                case "dhh":
                    CommonData.StatusId = 441961939347185664;
                    CommonData.TweetHandle = "dhh";
                    Response.Redirect("Default.aspx");
                    break;
            }
        }
    }
}
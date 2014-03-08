<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TwitterPuzzle.Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Multunus Twitter Puzzle</title>
    <h1>Welcome to Multunus Twitter Puzzle Solution (Level: Beginner)</h1>
    <h2>Click on any of the profile pics below to learn more about the puzzle.</h2>
    <link rel ="Stylesheet" href="homestyle.css" type="text/css" />
</head>
<body style ="background-image:url(http://cdn.elegantthemes.com/blog/wp-content/uploads/2013/09/bg-10-full.jpg); background-size:cover; background-repeat :no-repeat;">
    <form id="form1" runat="server">
    <div>
      <div class = "tweethandle-selector">
         <div class = "twitter-circle-container">
          <div class ="twitter-circle">
            <a>
              <asp:ImageButton runat="server" OnClick="OnImage_Click" ID="github" CssClass ="img-circle"  ImageUrl ="http://pbs.twimg.com/profile_images/426158315781881856/sBsvBbjY.png" />
            </a>
          </div>
          <div class ="twitter-circle">
            <a>
              <asp:ImageButton runat="server" OnClick="OnImage_Click" ID="timoreilly" CssClass ="img-circle" ImageUrl ="http://pbs.twimg.com/profile_images/2823681988/f4f6f2bed8ab4d5a48dea4b9ea85d5f1.jpeg" />
            </a>
          </div>
           <div class ="twitter-circle">
            <a>
             <asp:ImageButton runat="server" OnClick="OnImage_Click" ID="twitter" CssClass ="img-circle" ImageUrl ="http://pbs.twimg.com/profile_images/2284174758/v65oai7fxn47qv9nectx.png"/>
            </a>
          </div>
           <div class ="twitter-circle">
            <a>
              <asp:ImageButton runat="server" OnClick="OnImage_Click" ID="martinfowler" CssClass ="img-circle" ImageUrl ="http://pbs.twimg.com/profile_images/79787739/mf-tg-sq.jpg" />
            </a>
          </div>
           <div class ="twitter-circle">
            <a>
              <asp:ImageButton runat="server" OnClick="OnImage_Click" ID="gvanrossum" CssClass ="img-circle" ImageUrl ="http://pbs.twimg.com/profile_images/424495004/GuidoAvatar.jpg" />
            </a>
          </div>
           <div class ="twitter-circle">
            <a>
             <asp:ImageButton runat="server" OnClick="OnImage_Click" ID="billgates" CssClass ="img-circle" ImageUrl ="http://pbs.twimg.com/profile_images/1884069342/BGtwitter.JPG" />
            </a>
          </div>
           <div class ="twitter-circle">
            <a>
              <asp:ImageButton runat="server" OnClick="OnImage_Click" ID="spolsky" CssClass ="img-circle" ImageUrl ="http://pbs.twimg.com/profile_images/378800000091193257/fcb03c8d0a40048f2537df967239686f.jpeg" />
            </a>
          </div>
           <div class ="twitter-circle">
            <a>
              <asp:ImageButton runat="server" OnClick="OnImage_Click" ID="firefox" CssClass ="img-circle" ImageUrl ="http://pbs.twimg.com/profile_images/378800000324784929/1a4ee3fde80808a96ed268a7fb94682d.png" />
            </a>
          </div>
           <div class ="twitter-circle">
            <a>
              <asp:ImageButton runat="server" OnClick="OnImage_Click" ID="dhh" CssClass ="img-circle" ImageUrl ="http://pbs.twimg.com/profile_images/2556368541/alng5gtlmjhrdlr3qxqv.jpeg" />
            </a>
          </div>
          <img alt="Choose one" class="choose-circle-helper" src="http://puzzle.multunus.com/assets/choose-one-94c7b38f3a6c3cc3b0e060e9b988b496.png">
         </div>
      </div>
    </div>
    </form> 
</body>
</html>

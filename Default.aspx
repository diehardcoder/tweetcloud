<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TwitterPuzzle._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
     <title>Multunus Twitter Puzzle</title>
     <div id="influences-wrapper">
       <div class="top-links-container">
       <a class="try-another-handle-link" href="home.aspx">Try Another Handle</a>
       </div>
     </div>
    <h1>Welcome to Multunus Twitter Puzzle Solution (Level: Beginner)</h1>
    <link rel ="Stylesheet" href="tooltip.css" type="text/css" /> 
    <link rel ="Stylesheet" href="defaultstyle.css" type="text/css" />    
</head>

<body style ="background-image:url(http://cdn.elegantthemes.com/blog/wp-content/uploads/2013/09/bg-10-full.jpg); background-size:cover; background-repeat :no-repeat;">    
     <div class="textstyle">
        <asp:Label ID ="lblLastUpdatedTime" runat="server"></asp:Label>
     </div>
    <asp:Panel runat="server" ID="pnlImages" CssClass ="img-container">   
    <div class ="main-profile-image">
        <asp:Image ID="mainImg" runat="server" CssClass="img-circle" />
    </div>  
    <div id ="radial-div" style="position: relative;">
       <div id ="radial-div-item1" style ="position:absolute; left:250px;top: 30px;">  
       <a href ="#" class="tooltips">  
         <asp:Image ID="image1" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span>1</span>
       </a> 
       </div>
       <div id ="radial-div-item2" style ="position:absolute; left:379px;top: 72px;">
        <a href ="#" class="tooltips">  
         <asp:Image ID="image2" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span>2</span>
         </a> 
       </div>
       <div id ="radial-div-item3" style ="position:absolute; left:459px;top: 182px;">
        <a href ="#" class="tooltips">  
         <asp:Image ID="image3" runat= "server" CssClass="img-circle infulence-image"  Visible="False" />
         <span>3</span>
         </a> 
       </div>
        <div id ="radial-div-item4" style ="position:absolute; left:459px;top: 317px;">
         <a href ="#" class="tooltips">  
         <asp:Image ID="image4" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span>4</span>
         </a> 
       </div>
       <div id ="radial-div-item5" style ="position:absolute; left:379px;top: 427px;">
        <a href ="#" class="tooltips">  
         <asp:Image ID="image5" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span>5</span>
         </a> 
       </div>
       <div id ="radial-div-item6" style ="position:absolute; left:250px;top: 470px;">
        <a href ="#" class="tooltips">  
         <asp:Image ID="image6" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span>6</span>
         </a> 
       </div>
       <div id ="radial-div-item7" style ="position:absolute; left:120px;top: 429px;">
        <a href ="#" class="tooltips">  
         <asp:Image ID="image7" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span>7</span>
         </a> 
       </div>
       <div id ="radial-div-item8" style ="position:absolute; left:40px;top: 319px;">
        <a href ="#" class="tooltips">  
         <asp:Image ID="image8" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span>8</span>
         </a> 
       </div>
       <div id ="radial-div-item9" style ="position:absolute; left:40px;top: 183px;">
        <a href ="#" class="tooltips">  
         <asp:Image ID="image9" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span>9</span>
         </a> 
       </div>
       <div id ="radial-div-item10" style ="position:absolute; left:120px;top: 72px;">
        <a href ="#" class="tooltips">  
         <asp:Image ID="image10" runat= "server" CssClass="img-circle infulence-image"  Visible="False" />
         <span>10</span>
         </a> 
       </div>
    </div>     
    </asp:Panel>  
    
</body>
</html>

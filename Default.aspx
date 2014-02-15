<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TwitterPuzzle._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Multunus Twitter Puzzle</title>
    <link rel ="Stylesheet" href="tooltip.css" type="text/css" />
    <style type="text/css">
        .img-circle 
        {
             border-radius: 50%;
        }
        
        .img-container
        {
           position: relative;
            z-index: 10;
            width: 600px;
            height: 500px;
           margin-left: auto;
           margin-right: auto;
        }
        div.main-profile-image 
        {
            position: absolute;
            width: 300px;
            height: 300px;
            margin-left: auto;
            left: 150px;
            top: 150px;
        }        
        div.main-profile-image img 
        {
            width: 100%;
            height: 100%;
        }
        img.infulence-image 
        {
            height: 100px;
            width: 100px;
            background: none repeat scroll 0% 0% #FFF;               
        }
    </style>
</head>
<body style="background-image:url(http://cdn.elegantthemes.com/blog/wp-content/uploads/2013/09/bg-5-full.jpg);" >
    <form id="form1" runat="server">
    <div style="color: White">    
      Enter twitter handle or status id: 
        <asp:TextBox ID="tbTwitterHandle" runat="server"></asp:TextBox>     
    &nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Button" 
            onclick="btnSubmit_Click" />
        &nbsp;
    </div>
    </form>    
     
    <asp:Panel runat="server" ID="pnlImages" CssClass ="img-container">   
    <div class ="main-profile-image">
        <asp:Image ID="mainImg" runat="server" CssClass="img-circle" />
    </div>  
    <div id ="radial-div" style="position: relative;">
       <div id ="radial-div-item1" style ="position:absolute; left:250px;top: 30px;">  
       <a href ="#" class="tooltip">  
         <asp:Image ID="image1" runat= "server" CssClass="img-circle infulence-image tooltip" Visible="False" />
         <span class="tooltip">1</span>
         </a> 
       </div>
       <div id ="radial-div-item2" style ="position:absolute; left:379px;top: 72px;">
        <a href ="#" class="tooltip">  
         <asp:Image ID="image2" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span class="tooltip">2</span>
         </a> 
       </div>
       <div id ="radial-div-item3" style ="position:absolute; left:459px;top: 182px;">
        <a href ="#" class="tooltip">  
         <asp:Image ID="image3" runat= "server" CssClass="img-circle infulence-image"  Visible="False" />
         <span class="tooltip">3</span>
         </a> 
       </div>
        <div id ="radial-div-item4" style ="position:absolute; left:459px;top: 317px;">
         <a href ="#" class="tooltip">  
         <asp:Image ID="image4" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span class="tooltip">4</span>
         </a> 
       </div>
       <div id ="radial-div-item5" style ="position:absolute; left:379px;top: 427px;">
        <a href ="#" class="tooltip">  
         <asp:Image ID="image5" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span class="tooltip">5</span>
         </a> 
       </div>
       <div id ="radial-div-item6" style ="position:absolute; left:250px;top: 470px;">
        <a href ="#" class="tooltip">  
         <asp:Image ID="image6" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span class="tooltip">6</span>
         </a> 
       </div>
       <div id ="radial-div-item7" style ="position:absolute; left:120px;top: 429px;">
        <a href ="#" class="tooltip">  
         <asp:Image ID="image7" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span class="tooltip">7</span>
         </a> 
       </div>
       <div id ="radial-div-item8" style ="position:absolute; left:40px;top: 319px;">
        <a href ="#" class="tooltip">  
         <asp:Image ID="image8" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span class="tooltip">8</span>
         </a> 
       </div>
       <div id ="radial-div-item9" style ="position:absolute; left:40px;top: 183px;">
        <a href ="#" class="tooltip">  
         <asp:Image ID="image9" runat= "server" CssClass="img-circle infulence-image" Visible="False" />
         <span class="tooltip">9</span>
         </a> 
       </div>
       <div id ="radial-div-item10" style ="position:absolute; left:120px;top: 72px;">
        <a href ="#" class="tooltip">  
         <asp:Image ID="image10" runat= "server" CssClass="img-circle infulence-image"  Visible="False" />
         <span class="tooltip">10</span>
         </a> 
       </div>
    </div>     
    </asp:Panel>  
    
</body>
</html>

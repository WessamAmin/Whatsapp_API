<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Send_Message.aspx.cs" Inherits="Whatsapp_API.Send_Message" %>

<!DOCTYPE html>
<html>
  <head>
    <title>Send Data form</title>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.4.1/css/all.css" integrity="sha384-5sAR7xN1Nv6T6+dT2mhtzEpVJvfS3NScPQTrOxhwjIuvcA67KV2R5Jz6kr4abQsz" crossorigin="anonymous">
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700" rel="stylesheet">
    <style>
      html, body {
      min-height: 100%;
      }
      body, div, form, input, select, p { 
      padding: 0;
      margin: 0;
      outline: none;
      font-family: Roboto, Arial, sans-serif;
      font-size: 16px;
      color:black;
      }
      body {
      background: url("/uploads/media/default/0001/01/b5edc1bad4dc8c20291c8394527cb2c5b43ee13c.jpeg") no-repeat center;
      background-size: cover;
      }
      h1, h2 {
  
    
  font-style:italic;
      font-weight: 400;
      }
      h1{
  color:white;
      }
      h2 {
      margin: 0 0 0 8px;
        color:black;
      }
      .main-block {
      display: flex;
      flex-direction: column;
      justify-content: center;
      align-items: center;
      height: 100%;
      padding: 25px;
      background: rgb(62,180,137); 
      
      }
      .left-part, form {
      padding: 25px;
      }
      .left-part {
      text-align: center;
      }
      .fa-graduation-cap {
      font-size: 72px;
      }
        form {
            background-color: azure;
        }

        .title {
            display: flex;
            align-items: center;
            margin-bottom: 20px;
        }
      .info {
      display: flex;
      flex-direction: column;
      }
        input, select {
            padding: 5px;
            margin-bottom: 30px;
            background: transparent;
            border: none;
            border-bottom: 1px solid #eee;
        }
      input::placeholder {
      color: black;
      }
      option:focus {
      border: none;
      }
      option {
      background: black; 
      border: none;
      }
      .checkbox input {
      margin: 0 10px 0 0;
      vertical-align: middle;
      }
      .checkbox a {
      color: #26a9e0;
      }
      .checkbox a:hover {
      color: #85d6de;
      }
      .btn-item, .button1 {
      padding: 10px 5px;
      margin-top: 20px;
      border-radius: 5px; 
      border: none;
      background:rgb(24.3, 70.6, 53.7) ; 
      text-decoration: none;
      font-size: 15px;
      font-weight: 400;
      color:white;
      }
      .btn-item {
      display: inline-block;
      margin: 20px 5px 0;
      }
      .button1 {
      width: 100%;
      }
      .button1:hover, .btn-item:hover {
      background: rgb(62,180,137);
      }
      @media (min-width: 568px) {
      html, body {
      height: 100%;
      }
        .main-block {
            flex-direction: row;
            height: calc(100% - 50px);
        }
      .left-part, form {
      flex: 1;
      height: auto;
      }
      }
    </style>
  </head>
  <body>
    <div class="main-block">
      <div class="left-part">
          
          <img src="imge/icons8-whatsapp-192.png" />
        
        <h1>Welcome To Whatsapp Api Chat</h1>
    
       
      </div>
      <form  runat="server">
        <div class="title">
            <img src="imge/icons8-whatsapp.gif" />
         
          <h2> Write Your Message Here </h2>
        </div>
        <div class="info">
            <asp:TextBox ID="TextBox1"  class="fname" placeholder="Phone Number" runat="server"></asp:TextBox>
              <asp:TextBox ID="TextBox4" placeholder="FileName" runat="server"></asp:TextBox>
               <asp:TextBox ID="TextBox2" placeholder="FileLink" runat="server"></asp:TextBox>
          <asp:TextBox ID="TextBox3" placeholder="Text" runat="server"></asp:TextBox>
        
        
        </div>
         
        
          <asp:Button class="button1" runat="server" Text="Send" OnClick="Unnamed1_Click"  />
      </form>
    </div>
  </body>
</html>
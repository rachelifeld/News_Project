<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormNews1.aspx.cs" Inherits="News_Project.WebFormNews1" %>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.3/jquery.min.js"></script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>News</title>
    <link rel="stylesheet" type="text/css" href="Styles/StyleNews.css">
    <script src="Scripts/news.js"></script>
    <h1>News For You</h1>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
  <ItemTemplate>
    <div class="news-grid"> 
        <div class="news-item">
        <a href="javascript:void(0);" onclick="toggleContent(this)">
          <h3><%# Eval("Title") %></h3>
        </a>
        <div class="news-content" style="display: none;">
          <p><%# Eval("Description") %></p>
          <a href='<%# Eval("Link") %>'>Read more</a>
        </div>
      </div>
    </div>
  </ItemTemplate>
</asp:Repeater>

        </div>
    </form>
</body>
</html>

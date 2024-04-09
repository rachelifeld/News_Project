<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Google News Reader</title>
    <link rel="stylesheet" href="Styles.css">
    <script src="Scripts.js"></script>
</head>
<body>
    <h1>Google News Reader</h1>
    <asp:Repeater ID="newsList" runat="server" OnItemCommand="newsList_ItemCommand">
        <ItemTemplate>
            <div class="news-item" data-url='<%# Eval("Link") %>'>
                <a class="news-title" href='<%# Eval("Link") %>'>
                    <%# Eval("Title") %>
                </a>
                <div class="news-body">
                    </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</body>
</html>

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Summary.aspx.vb" Inherits="MASSTest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Summary</title>
    <link rel="stylesheet" type="text/css"href="/Content/Site.css" />
</head>
<body>
    <form id="summary" runat="server">
        <div class="intro">
            <h2>Donald Conyac's</h2>
            <h1>Adderator 9000</h1>
            <h3>Summary</h3>
        </div>
        <div class="content">
            <br />
            <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center"></asp:GridView>
            <br /> <br />
            <asp:Button ID="CalcPageButton" runat="server" Text="Go Back to Calculations" />
            <asp:Button ID="ClearButton" runat="server" Text="Clear Table &#9724;" />
        </div>
    </form>
</body>
</html>

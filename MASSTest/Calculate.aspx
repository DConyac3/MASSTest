<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Calculate.aspx.vb" Inherits="MASSTest.Calculate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculate</title>
    <link rel="stylesheet" type="text/css"href="./Content/Site.css" />
</head>
<body>
    <form id="calculate" runat="server">
        <div class="intro">
            <h2>Donald Conyac's</h2>
            <h1>
                Adderator 9000</h1>
            <h3>Capable of handling Integers, Mixed Numbers, Fractions,<br />
                Decimals, and the answer to life, the universe, and everything
            </h3>
        </div>
        <div class="content">
            <br />
            <asp:TextBox ID="Field1" runat="server"></asp:TextBox>
            <p>+</p>
            <asp:TextBox ID="Field2" runat="server"></asp:TextBox>
            <p>=</p>
            <asp:TextBox ID="Field3" runat="server" ReadOnly="true"></asp:TextBox>
            <br /><br />
            <asp:Button ID="CalcButton" runat="server" Text="Calculate &#9654;" />
            <asp:Button ID="SummaryButton" runat="server" Text="View Summary" />
        </div>
    </form>
    <script src="./Scripts/MASSScript.js"></script>
</body>
</html>

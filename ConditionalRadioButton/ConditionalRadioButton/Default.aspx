<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>What is your favorite movie?</h1>
        <div>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="movies" Text="Lord of the Rings" />
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="movies" Text="God Father" />
            <br />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="movies" Text="Alien" />
            <br />
            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="movies" Text="Gladiator" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ok" />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" />
&nbsp;<br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

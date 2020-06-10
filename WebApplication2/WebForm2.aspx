<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lbllat" runat="server" Text="Latitude"></asp:Label>
        <asp:TextBox ID="txtlat" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lbllong" runat="server" Text="Longitude"></asp:Label>
            <asp:TextBox ID="txtlong" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Data" />
        <p>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </p>
        <p>
            Sunrise is at : 
            <asp:Label ID="lblsunrise" runat="server" Text=""></asp:Label>
        </p>
        <p>
            Sunrise is at : 
            <asp:Label ID="lblsunset" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>

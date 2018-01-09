<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width:&nbsp;
        <asp:TextBox ID="widthBox" runat="server" AutoPostBack="True" OnTextChanged="widthBox_TextChanged"></asp:TextBox>
        <br />
        Height:&nbsp;
        <asp:TextBox ID="heightBox" runat="server" AutoPostBack="True" OnTextChanged="heightBox_TextChanged"></asp:TextBox>
        <br />
        Length:&nbsp;
        <asp:TextBox ID="lengthBox" runat="server" AutoPostBack="True" OnTextChanged="lengthBox_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundRadio" runat="server" AutoPostBack="True" GroupName="radioGroup" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Ground" />
        <br />
        <asp:RadioButton ID="airRadio" runat="server" AutoPostBack="True" GroupName="radioGroup" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Air" />
        <br />
        <asp:RadioButton ID="nextDayRadio" runat="server" AutoPostBack="True" GroupName="radioGroup" OnCheckedChanged="nextDayRadio_CheckedChanged" Text="Next Day" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>

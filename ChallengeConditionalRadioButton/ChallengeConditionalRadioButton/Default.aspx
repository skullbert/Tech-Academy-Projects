<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Your Note Taking Preferences<br />
        <br />
        <asp:RadioButton ID="pencilRadio" runat="server" GroupName="prefRadio" Text="Pencil" />
        <br />
        <asp:RadioButton ID="penRadio" runat="server" GroupName="prefRadio" Text="Pen" />
        <br />
        <asp:RadioButton ID="phoneRadio" runat="server" GroupName="prefRadio" Text="Phone" />
        <br />
        <asp:RadioButton ID="tabletRadio" runat="server" GroupName="prefRadio" Text="Tablet" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Image ID="resultImage" runat="server" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorForm.aspx.cs" Inherits="ChallengeSimpleCalculator.CalculatorForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>Simple Calculator</h2>
    
    </div>
        <p>
            First Value:&nbsp;
            <asp:TextBox ID="firstValue" runat="server"></asp:TextBox>
        </p>
        <p>
            Second Value:&nbsp;
            <asp:TextBox ID="secondValue" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addValues" runat="server" OnClick="addValues_Click" Text="+" Width="34px" />
&nbsp;<asp:Button ID="subtractValues" runat="server" OnClick="subtractValues_Click" Text="-" Width="33px" />
&nbsp;<asp:Button ID="multiplyValues" runat="server" OnClick="multiplyValues_Click" Text="*" Width="35px" />
&nbsp;<asp:Button ID="divideValues" runat="server" OnClick="divideValues_Click" Text="/" Width="34px" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server" BackColor="#66CCFF" Font-Bold="True" Font-Size="Medium"></asp:Label>
        </p>
    </form>
</body>
</html>

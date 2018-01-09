<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFirstPapaBobsWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 200px;
            height: 200px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style3 {
            color: #FF0000;
        }
    </style>
</head>
<body style="height: 288px">
    <form id="form1" runat="server">
    <div style="font-family: Arial, Helvetica, sans-serif">
    
        <h1>
            <img alt="PapaBobMascot" class="auto-style1" src="PapaBob.png" />Papa Bob&#39;s Pizza and Software</h1>
    
    </div>
    <div>
        <asp:RadioButton ID="babySizeRadio" runat="server" GroupName="sizeRadio" Text="Baby Bob Size (10&quot;) - $10" OnCheckedChanged="babySizeRadio_CheckedChanged" />
        <br />
        <asp:RadioButton ID="mamaSizeRadio" runat="server" GroupName="sizeRadio" Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="papaSizeRadio" runat="server" GroupName="sizeRadio" Text="Papa Bob Size (16&quot;) - $16" />
        </div>
        <br /><br />
        <div>
            <asp:RadioButton ID="thinCrustRadio" runat="server" GroupName="crustRadio" Text="Thin Crust" />
            <br />
            <asp:RadioButton ID="ddCrustRadio" runat="server" GroupName="crustRadio" Text="Deep Dish (+$2)" />
        </div>
        <br /><br />
        <div>

            <asp:CheckBox ID="pepperoniCheck" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Pepperoni (+$1.50)" />
            <br />
            <asp:CheckBox ID="onionsCheck" runat="server" Text="Onions (+$0.75)" />
            <br />
            <asp:CheckBox ID="gPeppersCheck" runat="server" Text="Green Peppers (+$0.50)" />
            <br />
            <asp:CheckBox ID="rPeppersCheck" runat="server" Text="Red Peppers (+$0.75)" />
            <br />
            <asp:CheckBox ID="anchoviesCheck" runat="server" Text="Anchovies (+$2)" />

        </div>
        <br /><br />
        <div>
            <h2 class="auto-style2">

                Papa Bob&#39;s <span class="auto-style3">Special Deal</span></h2>
        </div>
        <br />
        <div>

            Save $2.00 when you add Pepperoni, Green Peppers, and Anchovies OR Pepperoni, Red Peppers, and Onions to your pizza.</div>
        <br />
        <div>

            <asp:Button ID="totalButton" runat="server" OnClick="totalButton_Click" Text="Purchase" />
            <br />
            <br />
            <asp:Label ID="totalLabel" runat="server" Text="Total: $0.00"></asp:Label>
            <br />
            <br />
            Sorry, at this time you can only order one pizza online, and pick-up only... we need a better website!</div>
    </form>
    </body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuildAUnit.aspx.cs" Inherits="ArmyManager.BuildAUnit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="UnitForm" runat="server">
        <div>
            <input id="UnitName" type="text" required="required" spellcheck="True" title="Unit Name" value="Unit Name" />
            <asp:DropDownList ID="RaceDropdown" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="XPLevelDropdown" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="UnitTypeDropdown" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="EquipmentDropdown" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="SizeDropdown" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="TraitsDropdown" runat="server">
            </asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="CreateUnitButton" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>

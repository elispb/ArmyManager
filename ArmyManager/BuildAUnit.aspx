<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuildAUnit.aspx.cs" Inherits="ArmyManager.BuildAUnit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="UnitForm" runat="server">
        <div>
            <input id="UnitName" name="UnitName" type="text" spellcheck="True" title="Unit Name" value="Unit Name" runat="server"/>
            <asp:DropDownList ID="RaceDropdown" runat="server" DataSourceID="RacesTable" DataTextField="Name" DataValueField="RaceId">
            </asp:DropDownList>
            <asp:SqlDataSource ID="RacesTable" runat="server" ConnectionString="<%$ ConnectionStrings:ArmyContextConnectionString %>" SelectCommand="SELECT * FROM [Races]"></asp:SqlDataSource>
            <asp:DropDownList ID="XPLevelDropdown" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="UnitTypeDropdown" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="EquipmentDropdown" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="SizeDropdown" runat="server">
            </asp:DropDownList>
            <asp:CheckBoxList ID="TraitsList" runat="server" DataSourceID="TraitsTable" DataTextField="Name" DataValueField="TraitId">
            </asp:CheckBoxList>
            <asp:SqlDataSource ID="TraitsTable" runat="server" ConnectionString="<%$ ConnectionStrings:ArmyContextConnectionString %>" SelectCommand="SELECT * FROM [Traits]"></asp:SqlDataSource>
        </div>
        <div>
            <asp:Button ID="CreateUnitButton" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>

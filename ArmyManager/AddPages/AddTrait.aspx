﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTrait.aspx.cs" Inherits="ArmyManager.AddPages.AddTrait" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="AddTraitForm" runat="server">
        <div>
            <input id="TraitName" name="TraitName" type="text" spellcheck="True" title="Trait Name" value="Trait Name" runat="server" />
            <input id="TraitDesc" name="TraitDesc" type="text" spellcheck="True" title="Trait Description" value="Description" runat="server" />
            <input id="TraitCost" name="TraitCost" type="number" title="Trait Cost" value="000" runat="server" />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>

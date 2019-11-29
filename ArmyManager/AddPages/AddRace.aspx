<%@ Page MasterPageFile="~/ArmyManager.Master" Language="C#" AutoEventWireup="true" CodeBehind="AddRace.aspx.cs" Inherits="ArmyManager.AddPages.AddRace" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <input id="RaceName" name="RaceName" type="text" spellcheck="True" title="Race Name" value="Name" runat="server" />
            <input id="RaceDescription" name="RaceDescription" type="text" spellcheck="True" title="Race Description" value="Description" runat="server" />
            <input id="Attack" name="Attack" type="number" spellcheck="True" title="Attack Bonus" value="0" runat="server" />
            <input id="Defense" name="Defense" type="number" spellcheck="True" title="Defense Bonus" value="0" runat="server" />
            <input id="Power" name="Power" type="number" spellcheck="True" title="Power Bonus" value="0" runat="server" />
            <input id="Toughness" name="Toughness" type="number" spellcheck="True" title="Toughness Bonus" value="0" runat="server" />
            <input id="Morale" name="Morale" type="number" spellcheck="True" title="Morale Bonus" value="0" runat="server" />
            <asp:Button ID="CreateRace" runat="server" OnClick="CreateRace_Click" Text="Button" />
        </div>
        <asp:CheckBoxList ID="TraitCheckboxList" runat="server" DataSourceID="TraitList" DataTextField="Name" DataValueField="TraitId">
        </asp:CheckBoxList>
        <asp:SqlDataSource ID="TraitList" runat="server" ConnectionString="<%$ ConnectionStrings:ArmyContextConnectionString %>" SelectCommand="SELECT * FROM [Traits]"></asp:SqlDataSource>

</asp:Content>

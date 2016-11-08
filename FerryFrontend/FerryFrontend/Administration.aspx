<%@ Page Title="Administration" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administration.aspx.cs" Inherits="FerryFrontend.Administration" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Create Ferry</h3>
    <p>Create a new ferry in the system, which departures can make use of.</p>


    Ferry Name: <input type="text" id="ferryname" runat="server" /><br><br>
    
    Capacity (People): <input type="text" id="peoplecapacity"  runat="server" /> 
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="peoplecapacity" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator><br><br>
    
    Capacity (Vehicles): <input type="text" id="vehiclecapacity" runat="server"/> 
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="vehiclecapacity" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator><br><br>
    
    Capacity (Weight): <input type="text" id="weightcapacity" runat="server"/> 
    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="weightcapacity" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator><br><br>
    
    Is in reserve: <input type="checkbox" id="isreserve" runat="server"/><br><br>
    
    <asp:Button Text="Submit" ID="createferrybutton" OnClick="CreateFerryButton_Click" runat="server"/><br><br>
    
    <label id="createferrymessage" runat="server"></label>
    
</asp:Content>

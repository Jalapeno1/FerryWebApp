﻿<%@ Page Title="Administration" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="Administration.aspx.cs" Inherits="FerryFrontend.Administration" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">    
    <div class="page-header">
        <h2><%: Title %></h2>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-lg-5"> 
                <div class="panel panel-default">
                    <div class="panel-heading">Create Ferry</div>
                    <div class="panel-body">
                        <p>Create a new ferry in the system, which departures can make use of.</p><br/><br/>

                        Ferry Name: <input type="text" id="ferryname" runat="server" /><br><br>
    
                        Capacity (People): <input type="text" id="peoplecapacity"  runat="server" /> 
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="peoplecapacity" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator><br><br>
    
                        Capacity (Vehicles): <input type="text" id="vehiclecapacity" runat="server"/> 
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="vehiclecapacity" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator><br><br>
    
                        Capacity (Weight in kg): <input type="text" id="weightcapacity" runat="server"/> 
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="weightcapacity" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator><br><br>
    
                        Is in reserve: <input type="checkbox" id="isreserve" runat="server"/><br/><br/><br>
    
                        <asp:Button Text="Submit" ID="createferrybutton" OnClick="CreateFerryButton_Click" runat="server"/><br><br>
    
                        <label id="createferrymessage" runat="server"></label>
                    </div>
                </div>   
            </div>    
            <div class="col-lg-7">
                <div class="panel panel-default">
                  <!-- Default panel contents -->
                  <div class="panel-heading">Ferries</div>
                  <div class="panel-body">
                    <p>Available ferries</p>
                      <br/>
                  </div>

                      <asp:ListView ID="ferryList" runat="server" 
                            ItemType="Toolbox3_Library_Hundige.Ferry" SelectMethod="GetFerries">
                        <EmptyDataTemplate>
                            <table >
                                <tr>
                                    <td>No data was returned.</td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>
                        <EmptyItemTemplate>
                            <td/>
                        </EmptyItemTemplate>
                        <GroupTemplate>
                            <tr id="itemPlaceholderContainer" runat="server">
                                <td id="itemPlaceholder" runat="server"></td>
                            </tr>
                        </GroupTemplate>
                        <LayoutTemplate>
                            <table runat="server" class="table table-hover" id="groupPlaceholderContainer">
                                <tr runat="server">
                                    <th runat="server">#</th>
                                    <th runat="server">Ferry Name</th>
                                    <th runat="server">Capacity (People)</th>
                                    <th runat="server">Capacity (Vehicles)</th>
                                    <th runat="server">Capacity (Weight in kg)</th>
                                </tr>
                                <tr id="groupPlaceholder"></tr>
                            </table>
                    
                        </LayoutTemplate>
                        <ItemTemplate>
                            <td>
                                <asp:Button ID="DeleteButton" runat="server" OnCommand="DeleteButton_OnCommand" Text="Delete" />          
                            </td>
                            <td runat="server">
                                <%#: Item.Name%>
                            </td>
                            <td runat="server">
                                <%#: Item.PeopleCapacity%>
                            </td>
                            <td runat="server">
                                <%#: Item.VehicleCapacity%>
                            </td>
                            <td runat="server">
                                <%#: Item.WeightCapacityInKg%>
                            </td>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
            </div>
            <div class="col-lg-5"> 
                <div class="panel panel-default">
                    <div class="panel-heading">Create Departure</div>
                    <div class="panel-body">
                        <p>Create a new departure in the system, that reservations can make use of.</p><br/><br/>

                        Ferry: <select id="selectedFerry" runat="server">
                        </select><br><br>
    
                        Date: <input type="datetime-local" id="createDepatureDate"  runat="server" /> 
    
                        <asp:Button Text="Submit" ID="Button2" OnClick="CreateDeparture_OnClick" runat="server"/><br><br>
    
                        <label id="Label2" runat="server"></label>
                    </div>
                </div>   
            </div>
            <div class="col-lg-7">
                <div class="panel panel-default">
                  <!-- Default panel contents -->
                  <div class="panel-heading">Departures</div>
                  <div class="panel-body">
                    <p>Available departures</p>
                      <br/>
                  </div>

                      <asp:ListView ID="ListViewDepartures" runat="server" 
                            ItemType="Toolbox3_Library_Hundige.Departure" SelectMethod="GetDepartures">
                        <EmptyDataTemplate>
                            <table >
                                <tr>
                                    <td>No data was returned.</td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>
                        <EmptyItemTemplate>
                            <td/>
                        </EmptyItemTemplate>
                        <GroupTemplate>
                            <tr id="itemPlaceholderContainer" runat="server">
                                <td id="itemPlaceholder" runat="server"></td>
                            </tr>
                        </GroupTemplate>
                        <LayoutTemplate>
                            <table runat="server" class="table table-hover" id="groupPlaceholderContainer">
                                <tr runat="server">
                                    <th runat="server">#</th>
                                    <th runat="server">Date</th>
                                    <th runat="server">Ferry Name</th>
                                    <th runat="server">Capacity (People)</th>
                                    <th runat="server">Capacity (Vehicles)</th>
                                    <th runat="server">Capacity (Weight in kg)</th>
                                </tr>
                                <tr id="groupPlaceholder"></tr>
                            </table>
                    
                        </LayoutTemplate>
                        <ItemTemplate>
                            <td>
                                <asp:Button ID="DeleteButtonDeparture" runat="server" Text="Delete" />          
                            </td>
                            <td runat="server">
                                <%#: Item.DateAndTime%>
                            </td>
                            <td runat="server">
                                <%#: Item.SailingFerry.Name%>
                            </td>
                            <td runat="server">
                                <%#: Item.SailingFerry.PeopleCapacity%>
                            </td>
                            <td runat="server">
                                <%#: Item.SailingFerry.VehicleCapacity%>
                            </td>
                            <td runat="server">
                                <%#: Item.SailingFerry.WeightCapacityInKg%>
                            </td>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
            </div>   
        </div>
    </div>
</asp:Content>

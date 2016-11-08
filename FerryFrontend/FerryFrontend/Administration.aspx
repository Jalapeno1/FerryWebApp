<%@ Page Title="Administration" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administration.aspx.cs" Inherits="FerryFrontend.Administration" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <div class="page-header">
        <h2><%: Title %></h2>
    </div>
    <div class="container">
        
        <div class="row">
            <div class="col-lg-5">
                <h3>Create Ferry</h3>
                <p>Create a new ferry in the system, which departures can make use of.</p>


                Ferry Name: <input type="text" id="ferryname" runat="server" /><br><br>
    
                Capacity (People): <input type="text" id="peoplecapacity"  runat="server" /> 
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="peoplecapacity" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator><br><br>
    
                Capacity (Vehicles): <input type="text" id="vehiclecapacity" runat="server"/> 
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="vehiclecapacity" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator><br><br>
    
                Capacity (Weight in kg): <input type="text" id="weightcapacity" runat="server"/> 
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="weightcapacity" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator><br><br>
                Is in reserve: <input type="checkbox" id="isreserve" runat="server"/><br/><br/>
    
                <asp:Button Text="Submit" ID="createferrybutton" OnClick="CreateFerryButton_Click" runat="server"/><br><br>
    
                <label id="createferrymessage" runat="server"></label>
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
                                    <th runat="server">Ferry Name</th>
                                    <th runat="server">Capacity (People)</th>
                                    <th runat="server">Capacity (Vehicles)</th>
                                    <th runat="server">Capacity (Weight in kg)</th>
                                </tr>
                                <tr id="groupPlaceholder"></tr>
                            </table>
                    
                        </LayoutTemplate>
                        <ItemTemplate>
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
        </div>
    </div>
</asp:Content>

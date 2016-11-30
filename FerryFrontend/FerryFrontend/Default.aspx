<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FerryFrontend._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
        
            <div class=jumbotron>        
                    <h1>CPH Ferries</h1>
                    <p class="lead">Welcome to CPH Ferries. Everybody's preferred way of travel.</p>
                    <p><a href="/Tickets.aspx" class="btn btn-primary btn-lg">Order Tickets &raquo;</a></p> 
            </div>
        
   
    <div class="row">
        <div class="col-md-4">
           
            <div class="thumbnail"> 
                <img src="image/Ferrycartoon.png" class="img-circle" alt="Cinque Terre">
                <h2>Ferry Schedule</h2>
                <p>
                View when and where to the CPH Ferries sails. 
                </p>
                    <p>
                        <a class="btn btn-default" href="/Schedule.aspx">View Schedule &raquo;</a>
                    </p>
            </div>
        </div>
 
        <div class="col-md-4">            
                <div class="thumbnail">
                    <img src="image/Ticketcartoon.jpg" class="img-circle" alt="Cinque Terre" > 
                    <h2>Tickets</h2>
                    <p>
                       Book you ticket here    
                    </p>
                        <p>
                            <a class="btn btn-default" href="/Tickets.aspx">Order Tickets &raquo;</a>
                        </p>
                </div>
        </div>
        <div class="col-md-4">
            <div class="thumbnail">
                <img src="image/questionmark.png" class="img-circle" alt="Cinque Terre" >
                <h2>About Us</h2>
                <p>
                    Learn more about CPH Ferries..
                </p>
                <p>
                    <a class="btn btn-default" href="/About.aspx">Learn more &raquo;</a>
                </p>
            </div>
        </div>
    </div>


</asp:Content>

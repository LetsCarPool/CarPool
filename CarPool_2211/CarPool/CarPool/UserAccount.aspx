<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UserAccount.aspx.cs" Inherits="UserAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">

    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 368px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<%-- Modlog Start: Seema--%>    
      <table>
      <tr><td></td><td></td><td></td></tr>
      <tr><td></td><td></td><td></td></tr>
      <tr><td></td><td></td><td></td></tr>
      <tr>
      <td><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Car1.jpg" BorderStyle="Solid" ToolTip="Start Carpool"
                    onclick="ibStart_Click" Height="75px" Width="120px"
                    /></td>
                    <td><h6 style="color:Black; font-weight:bold">Start CarPool:</h6></td>
                    <td> <h6>You can register your car, and start the carpool by selecting the vehicle and route.</h6></td>
      </tr>
      <tr><td></td><td></td><td></td></tr>
      <tr>
      <td><asp:ImageButton ID="ImageButton2" runat="server"  
                    ImageUrl="~/Images/Car2.jpg" BorderStyle="Solid" ToolTip="Join Carpool" onclick="ibJoin_Click"  Height="75px" Width="120px"                    
                    /></td>
                    <td><h6 style="color:Black; font-weight:bold">Join CarPool:</h6></td>
                    <td> <h6>Helps you to join the car pool by selecting the date, start and destination places.</h6></td>
      </tr>
      </table>
      <div>
      <table class="style1">
      <tr><td ></td></tr>
            <tr><td align="right" >
      <asp:ImageButton ID="ImageButton4" runat="server"  
                    ImageUrl="~/Images/CarPoolText.jpg" Height="60px" Width="300px" />
      </td></tr>
      </table>
      </div>
<%--Modlog End: Seema --%>     
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="JoinedPassengers.aspx.cs" Inherits="JoinedPassengers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
           margin-top:100px;        
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="style1">
        <tr>
            <td align="center">
    <asp:GridView ID="grdPassengerInfo" runat="server" AutoGenerateColumns="False" Visible ="false" >
        <Columns>
            <asp:TemplateField HeaderText="Reg. Vehicle Number">
                <ItemTemplate>
                    <asp:Label ID="lblVNumber" runat="server" Text='<%#Eval("RouteDetails.VehicleNumber") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Passengers Info">
                <EditItemTemplate>
                    <asp:TextBox ID="txtPassenger" runat="server" Text='<%#Eval("Passengers") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblPassenger" runat="server" Text='<%#Eval("Passengers") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>           
            
             <asp:TemplateField HeaderText="Travel">
                <ItemTemplate>
                    <asp:Label ID="lblTravel" runat="server" Text='<%#Eval("Travel") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
         <HeaderStyle BackColor="#6666FF" ForeColor="White" />
    </asp:GridView>

            </td>
        </tr>
         <tr>
            <td align="center">
    <asp:GridView ID="grdJoinedPassengerInfo" runat="server" AutoGenerateColumns="False" 
                    Visible ="false" onrowdeleting="grdJoinedPassengerInfo_RowDeleting" >
        <Columns>
            <asp:TemplateField HeaderText="Reg. Vehicle Number">
                <ItemTemplate>
                    <asp:Label ID="lblVNumber" runat="server" Text='<%#Eval("RouteDetails.VehicleNumber") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="First Name">
                <EditItemTemplate>
                    <asp:TextBox ID="txtPassenger" runat="server" Text='<%#Eval("Passengers") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblPassenger" runat="server" Text='<%#Eval("Passengers") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Travel">
                <ItemTemplate>
                    <asp:Label ID="lblTravel" runat="server" Text='<%#Eval("Travel") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>            
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
         <HeaderStyle BackColor="#6666FF" ForeColor="White" />
    </asp:GridView>

            </td>
        </tr>
        <tr>
            <td align="center">
&nbsp;&nbsp;
                <asp:Button ID="btnBack" runat="server" Text="Back" class="btnStyle"
                    PostBackUrl="~/UserAccount.aspx" />
            </td>
        </tr>
    </table>
</asp:Content>


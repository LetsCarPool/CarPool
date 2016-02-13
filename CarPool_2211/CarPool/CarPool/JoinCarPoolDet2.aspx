<%@ Page Language="C#"  MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="JoinCarPoolDet2.aspx.cs" Inherits="JoinCarPoolDet2" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        
        .style3
        {
            height: 26px;
        }
                
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table style="width: 500px; margin-left:100px;margin-top :00px" >        
    
    <tr>
    <td style="text-align:center" colspan="3">
        <asp:Label ID="LblEnterDetails" runat="server" Font-Bold="True" 
            Font-Italic="False" Text="PLEASE SELECT CARPOOL"></asp:Label>
        <br />
        </td>
    </tr>
      <tr>
            <td>
                <asp:Label ID="lblPassengers" runat="server" Text="No. Of Passengers"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlNoOfPass" runat="server">
                    <asp:ListItem Selected="True" Value="0">--Select--</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvNoOfPass" runat="server" 
                    ControlToValidate="ddlNoOfPass" ErrorMessage="Please Select no. of passengers" 
                    Font-Size="X-Small" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                <br />
            </td>
            
        </tr>
    <tr>
    <td colspan="3">
    <asp:GridView ID="gvBookCar" runat="server" AutoGenerateColumns="False" 
        Height="109px"  Width="580px">
        <Columns>
            <asp:TemplateField HeaderText="Select">
                  <ItemTemplate>
                        <asp:CheckBox ID="chkCar" runat="server" />
                   </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Reg. Vehicle Number">
                <ItemTemplate>
                    <asp:Label ID="lblVehicleNumber" runat="server" 
                        Text='<%#Eval("VehicleNumber") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Travel Date">
                <ItemTemplate>
                    <asp:Label ID="lblStartDate" runat="server" Text='<%# Eval("TravelDt") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CarId" Visible="False">
                <ItemTemplate>
                    <asp:Label ID="lblSeatLeft" runat="server" Text='<%#Eval("CarId") %>' 
                        Visible="False"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="RouteId" Visible="False">
                <ItemTemplate>
                    <asp:Label ID="lblSeatLeft0" runat="server" Text='<%#Eval("RouteId") %>' 
                        Visible="False"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Start point">
                <ItemTemplate>
                    <asp:Label ID="lblStartPnt" runat="server" Text='<%# Eval("StartPnt") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="End point">
                <ItemTemplate>
                    <asp:Label ID="lblEndPnt" runat="server" Text='<%# Eval("EndPnt") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Running Days">
                <ItemTemplate>
                    <asp:Label ID="lblRunningDays" runat="server" Text='<%# Eval("RunningDays") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="AllWayPoints">
                <ItemTemplate>
                    <asp:Label ID="lblAllWayPoints" runat="server" 
                        Text='<%#Eval("AllWayPoints") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <HeaderStyle BackColor="#6666FF" ForeColor="White" />
    </asp:GridView>
    </td>
    </tr>
    <tr>
     <td>
        <asp:Button ID="btnBook" runat="server" Text="Next" onclick="btnBook_Click" 
             style="height: 26px" />   
        </td> 
     <td>
        <asp:Button ID="Button1" runat="server" Text="back" onclick="Button1_Click"  />   
     </td> 
    </tr>
    </table>
</asp:Content>

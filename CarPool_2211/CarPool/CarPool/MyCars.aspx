<%@ Page Title="" Language="C#"  MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MyCars.aspx.cs" Inherits="MyCars" %>
  <%--24-10-2013Swati: Removed style="margin-top: 201px"  and added text allign --%>        
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;             
           text-align:center;        
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="style1" >
        <tr>
            <td align="center">
            <%--Seema: Removed style="margin-left: 201px" from GridView--%>
    <asp:GridView ID="grdCarsInfo" runat="server" AutoGenerateColumns="False" 
        Height="109px" Width="580px" 
                    onrowediting="grdCarsInfo_RowEditing" 
                    onrowupdating="grdCarsInfo_RowUpdating" 
                    onrowcancelingedit="grdCarsInfo_RowCancelingEdit" 
                    onrowdeleting="grdCarsInfo_RowDeleting">
        <Columns>
            <asp:TemplateField HeaderText="Reg. Vehicle Number">
                <EditItemTemplate>
                    <asp:Label ID="lblVNumberEdit" runat="server" Text='<%#Eval("VehicleNumber") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblVNumber" runat="server" Text='<%#Eval("VehicleNumber") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Manufacturer">
                <EditItemTemplate>
                    <asp:TextBox ID="txtManufacturer" runat="server" Text='<%#Eval("Manufacturer") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblManufacturer" runat="server" Text='<%#Eval("Manufacturer") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Make">
                <EditItemTemplate>
                    <asp:TextBox ID="txtMake" runat="server" Text ='<%# Eval("Make") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblMake" runat="server" Text ='<%# Eval("Make") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Capacity">
                <EditItemTemplate>
                    <asp:TextBox ID="txtCapacity" runat="server" Text ='<%# Eval("Capacity") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblCapacity" runat="server" Text ='<%# Eval("Capacity") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Color">
                <EditItemTemplate>
                    <asp:TextBox ID="txtColor" runat="server" Text ='<%# Eval("Color") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblColor" runat="server"  Text ='<%# Eval("Color") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="True" ControlStyle-ForeColor="black" />
            <asp:CommandField ShowDeleteButton="True" ControlStyle-ForeColor="black"/>
        </Columns>
         <HeaderStyle BackColor="Black" ForeColor="White" />
    </asp:GridView>

            </td>
        </tr>
        <tr>
            <td align="center">
&nbsp;&nbsp;
                <asp:Button ID="btnBack" runat="server" Text="Back" class="btnStyle"
                    PostBackUrl="~/UserAccount.aspx" BackColor="Black" />
            </td>
        </tr>
        <tr>
        <td align="center">
        <asp:LinkButton ID="lnkNewCar" runat="server" onclick="lnkNewCar_Click" ControlStyle-ForeColor="black">LinkButton</asp:LinkButton>
        </td> 
        </tr>
    </table>

</asp:Content>


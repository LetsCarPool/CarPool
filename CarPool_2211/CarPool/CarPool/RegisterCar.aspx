<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RegisterCar.aspx.cs" Inherits="RegisterCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">

        .style1
        {
            width: 98%;
            height: 73px;
        }
        .style21
        {
            width: 291px;
            height: 30px;
        }
        .style5
        {
            width: 141px;
            height: 30px;
        }
        .style6
        {
            height: 30px;
        }
        .style22
        {
            width: 291px;
            height: 40px;
        }
        .style3
        {
            width: 141px;
            height: 40px;
        }
        .style4
        {
            height: 40px;
        }
        .style23
        {
            width: 291px;
            height: 34px;
        }
        .style7
        {
            width: 141px;
            height: 34px;
        }
        .style8
        {
            height: 34px;
        }
        .style24
        {
            width: 291px;
            height: 35px;
        }
        .style9
        {
            width: 141px;
            height: 35px;
        }
        .style10
        {
            height: 35px;
        }
        .style25
        {
            width: 291px;
            height: 41px;
        }
        .style11
        {
            width: 141px;
            height: 41px;
        }
        .style12
        {
            height: 41px;
        }
       
        .style26
        {
            width: 291px;
        }
        .style27
        {
            width: 125px;
        }
       
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style21">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
            <td class="style5">
                &nbsp;</td>
            <td class="style6">
                <asp:Label ID="lblEnterCarDetails" runat="server" Font-Size="Medium" 
                    SkinID="skin3" Text="Enter your car details"></asp:Label>
            </td>
        </tr>
    </table>
    <asp:UpdatePanel ID="upMainDetails" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <table class="style1">
                <tr>
                    <td class="style22">
                &nbsp;</td>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style22">
                &nbsp;</td>
                    <td class="style3">
                        <asp:Label ID="lblRegNum" runat="server" SkinID="Skin2" Text="Vehicle Number"></asp:Label>
                    </td>
                    <td class="style4">
                        <asp:TextBox ID="txtVehicleNum" runat="server" MaxLength="15"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvVehicleNumber" runat="server" 
                            ControlToValidate="txtVehicleNum" ErrorMessage="Please Enter the EmployeeId" 
                            ToolTip="Please Enter the EmployeeId">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style23">
                &nbsp;</td>
                    <td class="style7">
                        <asp:Label ID="lblManufacturer" runat="server" SkinID="Skin2" 
                            Text="Manufacturer"></asp:Label>
                    </td>
                    <td class="style8">
                        <asp:TextBox ID="txtManufacturer" runat="server" MaxLength="10"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style24">
                &nbsp;</td>
                    <td class="style9">
                        <asp:Label ID="lblMake" runat="server" SkinID="Skin2" Text="Make"></asp:Label>
                    </td>
                    <td class="style10">
                        <asp:TextBox ID="txtMake" runat="server" MaxLength="25"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="style24">
                &nbsp;</td>
                    <td class="style9">
                        <asp:Label ID="Label1" runat="server" SkinID="Skin2" Text="Color"></asp:Label>
                    </td>
                    <td class="style10">
                        <asp:TextBox ID="txtColor" runat="server" MaxLength="25"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="style25">
                &nbsp;</td>
                    <td class="style11">
                        <asp:Label ID="lblCapacity" runat="server" SkinID="Skin2" Text="Capacity"></asp:Label>
                    </td>
                    <td class="style12">
                        <asp:DropDownList ID="ddlCapacity" runat="server" 
                            Width="129px" >
                            <asp:ListItem Value="-1">--Select--</asp:ListItem>
                            <asp:ListItem Value="0">1</asp:ListItem>
                            <asp:ListItem Value="1">2</asp:ListItem>
                            <asp:ListItem Value="2">3</asp:ListItem>
                            <asp:ListItem Value="3">4</asp:ListItem>
                            <asp:ListItem Value="4">5</asp:ListItem>
                            <asp:ListItem Value="5">6</asp:ListItem>
                            <asp:ListItem Value="6">7</asp:ListItem>
                            <asp:ListItem Value="7">8</asp:ListItem>
                            <asp:ListItem Value="8">9</asp:ListItem>
                            <asp:ListItem Value="9">10</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvPwd" runat="server" 
                    ControlToValidate="ddlCapacity" ErrorMessage="Select the capacity" 
                    ToolTip="Select the capacity" InitialValue="-1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                 </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    
    <table class="style1">
        <tr>
            <td class="style26">
                &nbsp;</td>
            <td class="style27">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server"  >
                 <ContentTemplate>
                        <table style="width: 331px">
                        <tr>
                        <td><asp:Button ID="btnRegister" runat="server" 
                            Text="Register Car" Width="94px" class="btnStyle"
                            onclick="btnRegister_Click" CssClass="btnStyle"  />
                        </td>
                        <td>
                         <asp:Button ID="btnSelectWayPoints" runat="server" 
                            Text="Select Way Points" Width="127px" class="btnStyle"
                            onclick="btnSelectWayPoints_Click" CssClass="btnStyle" 
                            CausesValidation="False" Enabled="False"   />
                        </td>
                        </tr></table>
                        
                             
                  </ContentTemplate>
                </asp:UpdatePanel></td>
            <td>
               
                      
               
            </td>
        </tr>
    </table>
     
</asp:Content>


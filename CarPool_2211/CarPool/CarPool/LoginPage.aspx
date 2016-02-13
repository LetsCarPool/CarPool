<%@ Page Title="" Language="C#"  MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>
<%@ Register TagName ="Ads" TagPrefix ="UC" Src ="~/AdsUp.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
    {
        width: 100%;
            height: 227px;
            margin-top: 0px;
        }
        .style14
        {
            width: 573px;
            height: 262px;
        }
        .style31
        {
            width: 363px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table>
    <tr>
        <td style="margin-left:500px">
             <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
               <UC:Ads id="ucAdsUpImgCtrl" runat="server"></UC:Ads>
        
                </ContentTemplate>
             </asp:UpdatePanel>
            </td>
        <td align="center" class="style31"  >       
<%-- Modlog Start: Seema            <asp:Panel 
                ID="Panel1" runat="server"  
                BackColor="#A4A4C1" BorderWidth="2px" >--%>
                              
                <table style="background-color:#A4A4C1; border-style:solid; border-color:Gray" >
                <tr><td></td><td></td></tr>
                    <tr>
                        <td align="center" style="height:10px">
                            <asp:Label ID="lblHeader" runat="server" Font-Bold="False" Font-Underline="true"
                                Font-Names="Calisto MT" Font-Size="Small" ForeColor="Black" SkinID="skin1" 
                                Text="Login Here"></asp:Label>
                        </td>
                        <td></td>
                    </tr>               
                    <tr>
                        <td>
                            <asp:Label ID="lblEmpId" runat="server" SkinID="skin1" Text="Employee Id" 
                                Width="140px" style="text-align:right"></asp:Label> &nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtEmpId" runat="server" MaxLength="25" Width="200px" 
                                TabIndex="1"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="rfvUserId" runat="server" 
                                ControlToValidate="txtEmpId" ErrorMessage="Please Enter the User Id" 
                                Font-Size="Large" ForeColor="Red" ToolTip="Please Enter the User Id">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblPassword" runat="server" SkinID="skin1" Text="Password" 
                                Width="140px" style="text-align:right"></asp:Label> &nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" MaxLength="15" 
                                Width="200px" TabIndex="2"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                                ControlToValidate="txtPassword" ErrorMessage="Please Enter the PassWord" 
                                Font-Size="Large" ForeColor="Red" ToolTip="Please Enter the Password">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnLogin" runat="server" 
                                onclick="btnLogin_Click" Text="Login" Width="90px" class="btnStyle" 
                                CssClass="btnStyle" TabIndex="3" BackColor="Black" />
                        </td>
                        <td></td>
                    </tr>
                    <tr><td></td><td></td></tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblNewUser" runat="server"  Font-Bold="False" 
                                Font-Names="Calisto MT" Font-Size="Small" ForeColor="Black" SkinID="skin1"
                                Text="Are you a new user?"></asp:Label>
                        &nbsp;
                            <asp:LinkButton ID="lnkNewUser" runat="server" Font-Bold="True" 
                                Font-Names="Calisto MT" ForeColor="#FF6600" onclick="lnkNewUser_Click" 
                                CausesValidation="False" TabIndex="4">Register Here</asp:LinkButton>
                            
                        </td>
                        <td></td>
                    </tr>
                </table> 
<%--             </asp:Panel> Modlog End: Seema  --%>         
            </td>
    </tr>

    <tr>
        <td colspan="2" style="margin-left:500px">
&nbsp;<marquee behavior="scroll" direction="up" width="345" height="100" scrollamount="2" scrolldelay="80"  onmouseover="this.stop();" onmouseout="this.start();" 
id="MARQUEE1" style= "background:#7CEAE6;border:solid 2px Gray;font-family:Calisto MT;font-size:12px;
font-weight:900; text-align:center;" ><asp:Label ID="MqText" runat="server" ForeColor="Black"></asp:Label></marquee>
&nbsp;</td>
    </tr>
    </table>
</asp:Content>


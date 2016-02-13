<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="JoinCarpoolDet3.aspx.cs" Inherits="JoinCarpoolDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        
        .style3
        {
            height: 26px;
        }
                
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
       <script language="javascript" type="text/javascript" >
       
            </script>
    <table style="width: 536px; margin-left:100px;margin-top :00px" >
         <tr align="center">
                <td colspan=2 >
                     <asp:Label ID="LblEnterDetails" runat="server" 
                         Text="PLEASE FILL UP THE BELOW DETAILS" Font-Bold="True" Font-Italic="False" ></asp:Label>
                </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCarNo" runat="server" Text="Car Number"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCarNumber" runat="server" Enabled="false"></asp:TextBox>
            </td>
        </tr>
            
            <tr>
                <td >
                    <asp:Label ID="lblPassenger1" runat="server" Text="Passenger 1" Visible="False"></asp:Label>
                </td>
                <td >                    
                    <asp:TextBox ID="txtPassenger1" runat="server" Visible="False"></asp:TextBox>
                </td>
                 <td  colspan="2">
                     <asp:RequiredFieldValidator ID="rfvPass1" runat="server" 
                         ControlToValidate="txtPassenger1" Enabled="False" ErrorMessage="rfvPass1" 
                         Font-Size="X-Small" ForeColor="#CC0000">Please enter Passenger 1 Name</asp:RequiredFieldValidator>
                </td>
            </tr>
           <tr>
                <td >
                    <asp:Label ID="lblPassenger2" runat="server" Text="Passenger 2" Visible="False"></asp:Label>
                </td>
                <td >                    
                    <asp:TextBox ID="txtPassenger2" runat="server" Visible="False"></asp:TextBox>
                </td>
                 <td  colspan="2">
                     <asp:RequiredFieldValidator ID="rfvPass2" runat="server" 
                         ControlToValidate="txtPassenger2" Enabled="False" Font-Size="X-Small" 
                         ForeColor="#CC0000">Please enter Passenger 2 Name</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="lblPassenger3" runat="server" Text="Passenger 3" Visible="False"></asp:Label>
                </td>
                <td >                    
                    <asp:TextBox ID="txtPassenger3" runat="server" Visible="False"></asp:TextBox>
                </td>
                 <td colspan="2">
                     <asp:RequiredFieldValidator ID="rfvPass3" runat="server" 
                         ControlToValidate="txtPassenger3" Enabled="False" Font-Size="X-Small" 
                         ForeColor="#CC0000">Please enter Passenger 3 Name</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="lblPassenger4" runat="server" Text="Passenger 4" Visible="False"></asp:Label>
                </td>
                <td >                    
                    <asp:TextBox ID="txtPassenger4" runat="server" Visible="False"></asp:TextBox>
                </td>
                 <td colspan="2">
                     <asp:RequiredFieldValidator ID="rfvPass4" runat="server" 
                         ControlToValidate="txtPassenger4" Enabled="False" Font-Size="X-Small" 
                         ForeColor="#CC0000">Please enter Passenger 4 Name</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3" >
                    <asp:Label ID="lblPassenger5" runat="server" Text="Passenger 5" Visible="False"></asp:Label>
                </td>
                <td class="style3" >                    
                    <asp:TextBox ID="txtPassenger5" runat="server" Visible="False"></asp:TextBox>
                </td>
                 <td   colspan="2">
                     <asp:RequiredFieldValidator ID="rfvPass5" runat="server" 
                         ControlToValidate="txtPassenger5" Enabled="False" Font-Size="X-Small" 
                         ForeColor="#CC0000">Please enter Passenger 5 Name</asp:RequiredFieldValidator>
                     </td>
            </tr>
            <tr>
                <td class="style3" >
                    <asp:Label ID="lblPassenger6" runat="server" Text="Passenger 6" Visible="False"></asp:Label>
                </td>
                <td class="style3" >                    
                    <asp:TextBox ID="txtPassenger6" runat="server" Visible="False"></asp:TextBox>
                </td>
                 <td  colspan="2">
                     <asp:RequiredFieldValidator ID="rfvPass6" runat="server" 
                         ControlToValidate="txtPassenger6" Enabled="False" Font-Size="X-Small" 
                         ForeColor="#CC0000">Please enter Passenger 6 Name</asp:RequiredFieldValidator>
                     </td>
            </tr>
                        <tr>
                <td class="style3" >
                    <asp:Label ID="lblPassenger7" runat="server" Text="Passenger 7" Visible="False"></asp:Label>
                </td>
                <td class="style3" >                    
                    <asp:TextBox ID="txtPassenger7" runat="server" Visible="False"></asp:TextBox>
                </td>
                 <td  colspan="2">
                     <asp:RequiredFieldValidator ID="rfvPass7" runat="server" 
                         ControlToValidate="txtPassenger7" Enabled="False" Font-Size="X-Small" 
                         ForeColor="#CC0000">Please enter Passenger 7 Name</asp:RequiredFieldValidator>
                     </td>
            </tr>
            <tr>
                <td class="style3" >
                    <asp:Label ID="lblPassenger8" runat="server" Text="Passenger 8" Visible="False"></asp:Label>
                </td>
                <td class="style3" >                    
                    <asp:TextBox ID="txtPassenger8" runat="server" Visible="False"></asp:TextBox>
                </td>
                 <td  colspan="2">
                     <asp:RequiredFieldValidator ID="rfvPass8" runat="server" 
                         ControlToValidate="txtPassenger8" Enabled="False" Font-Size="X-Small" 
                         ForeColor="#CC0000">Please enter Passenger 8 Name</asp:RequiredFieldValidator>
                     </td>
            </tr>
                        <tr>
                <td class="style3" >
                    <asp:Label ID="lblPassenger9" runat="server" Text="Passenger 9" Visible="False"></asp:Label>
                </td>
                <td class="style3" >                    
                    <asp:TextBox ID="txtPassenger9" runat="server" Visible="False"></asp:TextBox>
                </td>
                 <td  colspan="2">
                     <asp:RequiredFieldValidator ID="rfvPass9" runat="server" 
                         ControlToValidate="txtPassenger9" Enabled="False" Font-Size="X-Small" 
                         ForeColor="#CC0000">Please enter Passenger 9 Name</asp:RequiredFieldValidator>
                     </td>
            </tr>
                        <tr>
                <td class="style3" >
                    <asp:Label ID="lblPassenger10" runat="server" Text="Passenger 10" 
                        Visible="False"></asp:Label>
                </td>
                <td class="style3" >                    
                    <asp:TextBox ID="txtPassenger10" runat="server" Visible="False"></asp:TextBox>
                </td>
                 <td  colspan="2">
                     <asp:RequiredFieldValidator ID="rfvPass10" runat="server" 
                         ControlToValidate="txtPassenger10" Enabled="False" Font-Size="X-Small" 
                         ForeColor="#CC0000">Please enter Passenger 10 Name</asp:RequiredFieldValidator>
                     </td>
            </tr>
        <tr>
            <td style="text-align:center" colspan="2">
                <asp:Button ID="btnBook" runat="server" Text="Book" onclick="btnBook_Click"  />
                <%--<asp:CustomValidator id="RadioButtonValidator" runat="server" Display="Dynamic" ErrorMessage="Please select a date of journey." 
                 ClientValidationFunction="ClientValidate" ForeColor="Red" ></asp:CustomValidator>--%>
            </td>           
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="hpPrevious" runat="server" NavigateUrl="~/JoinCarpool.aspx">Back</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>
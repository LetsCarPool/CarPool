<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile ="~/Site.master" CodeFile="SelectDates.aspx.cs" Inherits="SelectDates" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <script type="text/javascript">
    function popupCalendar() {

        var dateField = document.getElementById('dateField');

        if (((document.getElementById('txtDate').value == "") || (document.getElementById('txtDate1').value == null)) && (document.referrer.search('insert_event') != -1)) {
            document.getElementById('dateField').style.display = 'block';

        }

        // toggle the div
        if (dateField.style.display == 'none')
            dateField.style.display = 'block';
        else
            dateField.style.display = 'none';
    }
</script>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
  
        <table  align="center" border="Red" frame="border" rules="all" style="background:#A4A4C1;width:55%">
        <tr>
            <td  >
                                <table  align="center">
                                    <tr>
                                        <td  colspan="2">
                                            <asp:RadioButton ID="rbSingleTrip" runat="server" Text="Single Trip" 
                                                AutoPostBack="True" GroupName="Group1" 
                                                oncheckedchanged="RadioButton1_CheckedChanged" Font-Bold="True" />
                                            
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:RadioButton 
                                                ID="rbRegularTrips" runat="server" Text="Regular Trips" 
                                                AutoPostBack="True" GroupName="Group1" 
                                                oncheckedchanged="rbRegularTrips_CheckedChanged" 
                                                ForeColor="Black" Font-Bold="True" />
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                                            <asp:Label ID="lblMsg" runat="server" ForeColor="Red" 
                                                Text="Selection of trips is mandatory" Visible="False"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td >
                                            <asp:Label ID="lblStartdate" runat="server" Text="Start Date" Font-Bold="False"></asp:Label>
                                        </td>
                                        <td>
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <ContentTemplate>
                                        <table>
                                        <tr>
                                        <td >
                                            <asp:TextBox ID="txtStartDate" runat="server" Width="119px" ReadOnly="True"></asp:TextBox>
                                            <br />
                                            <asp:Calendar ID="CalStartDate" runat="server" 
                                                onselectionchanged="CalStartDate_SelectionChanged" Visible="False">
                                                <SelectedDayStyle BackColor="White" ForeColor="#FF3300" />
                                                <TodayDayStyle BackColor="#FFFFCC" ForeColor="#FF3300" />
                                            </asp:Calendar>
                                        </td>
                                        <td >
                                            <br />
                                            <br />
                                            <asp:ImageButton ID="ImgBtnStartDate" runat="server" Height="28px" 
                                                ImageUrl="~/Images/Calendar.jpg" Width="25px" ImageAlign="Top" 
                                                onclick="ImgBtnStartDate_Click1"  ViewStateMode="Enabled" CausesValidation="False" />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                ControlToValidate="txtStartDate" ErrorMessage="Select the Travel/ Start Date" 
                                                ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                ControlToValidate="txtStartDate" 
                                                ErrorMessage="Booking cannot be done for the past dates" ForeColor="Red" 
                                                Operator="GreaterThanEqual" SetFocusOnError="True" Type="Date"></asp:CompareValidator>
                                        </td>
                                        </tr></table>                                      
                                        
                                        </ContentTemplate>
                                        </asp:UpdatePanel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td >
                                            <asp:Label Align="Top" ID="lblEndDate" runat="server" Text="End Date"></asp:Label>
                                        </td>
                                        <td>
                                          <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                        <ContentTemplate>                                        
                                        <table>
                                        <tr>
                                        <td >
                                            <asp:TextBox ID="txtEndDate" runat="server" Width="119px" ReadOnly="True"></asp:TextBox>
                                            <br />
                                            <asp:Calendar ID="CalEndDate" runat="server" 
                                                onselectionchanged="CalEndDate_SelectionChanged" 
                                                SelectedDate="10/05/2011 11:18:37" Visible="False">
                                                <TodayDayStyle BackColor="#FFFFCC" ForeColor="#FF3300" />
                                            </asp:Calendar>
                                        </td>
                                        <td >
                                            <br />
                                            <asp:ImageButton ID="ImgBtnEndDate" runat="server" Height="28px" 
                                                ImageUrl="~/Images/Calendar.jpg" Width="25px" ClientIDMode="Static" 
                                                onclick="ImgBtnEndDate_Click" CausesValidation="False" />
                                            <asp:RequiredFieldValidator ID="RfvEnddate" runat="server" 
                                                ControlToValidate="txtEndDate" ErrorMessage="Select the End Date" 
                                                ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                            <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                                ControlToValidate="txtEndDate" 
                                                ErrorMessage="Booking cannot be done for the past dates" ForeColor="Red" 
                                                Operator="GreaterThanEqual" SetFocusOnError="True" Type="Date"></asp:CompareValidator>
                                        </td>
                                        </tr>
                                        </table>
                                        </td>
                                      
                                         </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </tr>
                                </table>
                                <br />
                                <table >
                                    <tr>
                                        <td >
                                            <asp:CheckBox ID="ChkMon" runat="server" Text="Mon" 
                                                ValidationGroup="Group1" />
                                        </td>
                                        <td class="style2" >
                                            <asp:CheckBox ID="ChkTue" runat="server" Text="Tue" 
                                                ValidationGroup="Group1" />
                                        </td>
                                        <td >
                                            <asp:CheckBox ID="ChkWed" runat="server" Text="Wed" 
                                                ValidationGroup="Group1" />
                                        </td>
                                        <td class="style1" >
                                            <asp:CheckBox ID="ChkThu" runat="server" Text="Thu" 
                                                ValidationGroup="Group1" />
                                        </td>
                                        <td >
                                            <asp:CheckBox ID="ChkFri" runat="server" Text="Fri" 
                                                ValidationGroup="Group1" />
                                        </td>
                                        <td >
                                            <asp:CheckBox ID="ChkSat" runat="server" Text="Sat" 
                                                ValidationGroup="Group1" />
                                        </td>
                                        <td >
                                            <asp:CheckBox ID="ChkSun" runat="server" Text="Sun" 
                                                ValidationGroup="Group1" />
                                        </td>
                                    </tr>
                                    <tr>
                                    <td colspan=2 align="center">
                                    <asp:Button ID="btnBook" runat="server" Text="Book" onclick="btnBook_Click" 
                                    CssClass="btnStyle" Width="80px" />
                                    </td>
                                    <td colspan=2 align="center">
                                    <asp:Button ID="Button4" runat="server" Text="Cancel" CausesValidation="False" 
                                    CssClass="btnStyle" Width="85px" />
                                    </td>
                                    <td colspan=3 align="center"> 
                                        <asp:Button ID="btnBack" runat="server" Text="Back" CausesValidation="False" 
                                    CssClass="btnStyle" onclick="btnBack_Click" Width="71px" /></td>
                                    </tr>
                                </table>
                            <br />
            </td>
        </tr>
    </table> 
</asp:Content>


<asp:Content ID="Content2" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 57px;
        }
        .style2
        {
            width: 56px;
        }
    </style>
</asp:Content>




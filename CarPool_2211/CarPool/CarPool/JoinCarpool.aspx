<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="JoinCarpool.aspx.cs" Inherits="JoinCarpool" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        
        .style3
        {
            height: 28px;
        }
        
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <script type="text/javascript">
    </script>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <table style="width: 500px; margin-left:100px;margin-top :00px" >        
    <tr>
            <td>
                <asp:Label ID="lblStartPt" runat="server" Text="Start Point:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlStPoint" runat="server" AppendDataBoundItems="True">
                    <asp:ListItem Selected="True" Value="0">--Select--</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="ddlStPoint" ErrorMessage="RequiredFieldValidator" 
                    Font-Size="XX-Small" ForeColor="Red" InitialValue="0">Please Select a Start Point</asp:RequiredFieldValidator>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDestination" runat="server" Text="Destination:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlDestination" runat="server" 
                    AppendDataBoundItems="True">
                    <asp:ListItem Selected="True" Value="0">--Select--</asp:ListItem>
                    <asp:ListItem>Wakad</asp:ListItem>
                    <asp:ListItem>Pimple </asp:ListItem>
                    <asp:ListItem>chinchwad</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="ddlDestination" ErrorMessage="RequiredFieldValidator" 
                    Font-Size="XX-Small" ForeColor="Red" InitialValue="0">Please select a Destination point.</asp:RequiredFieldValidator>
            </td>
           
        </tr>
        <tr>
              <td  colspan="1" class="style3">
                      <asp:RadioButton ID="rbSingleTrip" runat="server" Text="Single Trip" 
                      AutoPostBack="True" GroupName="Group1" 
                      oncheckedchanged="RadioButton1_CheckedChanged" Font-Bold="True" />
              </td>                                              
               <td class="style3">    
                      <asp:RadioButton ID="rbRegularTrips" runat="server" Text="Regular Trips" 
                       AutoPostBack="True" GroupName="Group1" 
                       oncheckedchanged="rbRegularTrips_CheckedChanged" 
                       ForeColor="Black" Font-Bold="True" />
              </td>
              <td class="style3">
                     <asp:Label ID="lblMsg" runat="server" ForeColor="Red" 
                      Text="Selection of trips is mandatory" Visible="False" Font-Size="X-Small"></asp:Label>
               </td>
         </tr>
        <tr>
            <td >
                <asp:Label ID="lblStartDate" runat="server" Visible="False"></asp:Label>
                <br />
                <asp:TextBox ID="txtStartDate" runat="server" Width="119px" ReadOnly="True"></asp:TextBox> 
               
                    <br />
                <asp:Calendar ID="CalStartDate" runat="server" 
                onselectionchanged="CalStartDate_SelectionChanged" Visible="False" 
                    Height="34px" Width="118px">
                <SelectedDayStyle BackColor="White" ForeColor="#FF3300" />
                <TodayDayStyle BackColor="#FFFFCC" ForeColor="#FF3300" />
                </asp:Calendar>

            </td>
            <td>
             <asp:ImageButton ID="ImgBtnStartDate" runat="server" Height="16px" 
                 ImageUrl="~/Images/Calendar.jpg" Width="16px" ClientIDMode="Static"   
                 CausesValidation="False" onclick="ImgBtnStartDate_Click" />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvStartDate" runat="server" ControlToValidate="txtStartDate" 
                ErrorMessage="Select the Travel/ Start Date" ForeColor="Red" 
                    SetFocusOnError="True" Font-Size="XX-Small"></asp:RequiredFieldValidator>
                    <br />
                <asp:CompareValidator ID="CmpStartDtValidator" runat="server"  ControlToValidate="txtStartDate" 
                 ErrorMessage="Cannot be done for the past dates" ForeColor="Red" 
                 Operator="GreaterThanEqual" SetFocusOnError="True" Type="Date" 
                    Font-Size="XX-Small"></asp:CompareValidator>
            </td>
            </tr>
            <tr>
            <td>
                <asp:Label ID="lblEndDate0" runat="server" Text="EndDate:" Visible="False"></asp:Label>
                <br />
                <asp:TextBox ID="txtEndDate" runat="server" Width="119px" ReadOnly="True"></asp:TextBox>

                 <br />
                 <asp:Calendar ID="CalEndDate" runat="server"  onselectionchanged="CalEndDate_SelectionChanged" 
                  Visible="False" Height="34px" Width="118px">
                  <SelectedDayStyle BackColor="White" ForeColor="#FF3300" />
                  <TodayDayStyle BackColor="#FFFFCC" ForeColor="#FF3300" />
                 </asp:Calendar>
              </td>
              <td>
                              <asp:ImageButton ID="ImgBtnEndDate" runat="server" Height="16px"  ImageUrl="~/Images/Calendar.jpg"
                  Width="16px" ClientIDMode="Static"  
                     CausesValidation="False" onclick="ImgBtnEndDate_Click" />
              </td>
            <td> 
                    <br />
                <br />
                 <asp:RequiredFieldValidator ID="RfvEnddate" runat="server" ControlToValidate="txtEndDate"
                  ErrorMessage="Select the End Date" ForeColor="Red" SetFocusOnError="True" 
                    Font-Size="XX-Small" Enabled="False"></asp:RequiredFieldValidator>
                 <br />
                 <asp:CompareValidator ID="CmpEndDtValidator" runat="server"  ControlToValidate="txtEndDate" 
                   ErrorMessage="Cannot be done for the past dates" ForeColor="Red" 
                   Operator="GreaterThanEqual" SetFocusOnError="True" Type="Date" 
                    Font-Size="XX-Small" Enabled="False"></asp:CompareValidator>
                <br />
                </td>
            </tr>
        <tr>
            <td>        
                <asp:CheckBox ID="chkExact" runat="server" Text="Search Exact Match" />        
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center" >
                <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btnStyle" 
                    onclick="btnSearch_Click" />
            </td>
            
        </tr>
        <tr>
            <td colspan="2" align="center" >
            <asp:Label ID="MsgShow" runat="server" Visible="False"></asp:Label>
            </td>                    
        </tr>
        <tr align="left">
            <td colspan="3" align="left" >
                <%--<asp:GridView ID="gvSearchRoute" runat="server">
                </asp:GridView>--%>

                    <asp:GridView ID="gvSearchRoute" runat="server" AutoGenerateColumns="False" 
                     Height="109px" Width="580px" 
                    onselectedindexchanged="gvSearchRoute_SelectedIndexChanged" >
        <Columns>

            <asp:TemplateField HeaderText="Reg. Vehicle Number">
                <ItemTemplate>
                    <asp:Label ID="lblVehicleNumber" runat="server" Text='<%#Eval("VehicleNumber") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CarId" Visible="False">
                <ItemTemplate>
                    <asp:Label ID="lblSeatLeft" runat="server" Text='<%#Eval("CarId") %>' Visible="False"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField> 
            <asp:TemplateField HeaderText="RouteId" Visible="False">
                <ItemTemplate>
                    <asp:Label ID="lblSeatLeft" runat="server" Text='<%#Eval("RouteId") %>' Visible="False"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>  
            <asp:TemplateField HeaderText="Start Date" >
                <ItemTemplate>
                    <asp:Label ID="lblStartDate" runat="server" Text ='<%# Eval("StartDt") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>  
            <asp:TemplateField HeaderText="End Date" >
                <ItemTemplate>
                    <asp:Label ID="lblEndDate" runat="server" Text ='<%# Eval("EndDt") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>   
            <asp:TemplateField HeaderText="Start point">               
                <ItemTemplate>
                    <asp:Label ID="lblStartPnt" runat="server" Text ='<%# Eval("StartPnt") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField> 
             <asp:TemplateField HeaderText="End point">
                <ItemTemplate>
                    <asp:Label ID="lblEndPnt" runat="server" Text ='<%# Eval("EndPnt") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Running Days">
                <ItemTemplate>
                    <asp:Label ID="lblRunningDays" runat="server" Text ='<%# Eval("RunningDays") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>  
            <asp:TemplateField HeaderText="AllWayPoints">
                <ItemTemplate>
                    <asp:Label ID="lblAllWayPoints" runat="server" Text='<%#Eval("AllWayPoints") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>   
 
            <asp:HyperLinkField HeaderText="Book"  Text="Book" 
            DataNavigateUrlFields="VehicleNumber, CarId, RouteId, StartDt, EndDt" DataNavigateUrlFormatString="~/JoinCarpoolDet2.aspx?VehicleNumber={0}&CarId={1}&RouteId={2}&StartDt={3}&EndDt={4}" />
        </Columns>
         <HeaderStyle BackColor="#6666FF" ForeColor="White" />
    </asp:GridView>       

            </td>            
        </tr>
    </table>
</asp:Content>


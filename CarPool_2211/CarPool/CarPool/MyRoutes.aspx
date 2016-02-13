<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MyRoutes.aspx.cs" Inherits="MyRoutes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server" >
    <style type="text/css">
  .Grid
{
  table-layout: fixed;
  width: 100%;
}

        .style1
        {
            height: 21px;
        }

  </style>
  <%--24-10-2013Swati: Removed style="margin-top: 201px"  and added text allign --%>
<table style="width:100%; text-align:center;">
        <tr>
            <td align="center">
    <asp:GridView ID="grdRoutesInfo" runat="server" AutoGenerateColumns="False" 
                    onrowcancelingedit="grdRoutesInfo_RowCancelingEdit" 
                    onrowdeleting="grdRoutesInfo_RowDeleting" 
                    onrowediting="grdRoutesInfo_RowEditing" 
                    onrowupdating="grdRoutesInfo_RowUpdating"  CssClass="Grid"  >
        <Columns>
         <asp:TemplateField HeaderText="Route Id" Visible="false" >
                <EditItemTemplate>
                    <asp:Label ID="lblrtIdEdit" runat="server" Text='<%#Eval("RouteID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblrtId" runat="server" Text='<%#Eval("RouteID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>  
            <asp:TemplateField HeaderText="Reg. Vehicle Number" >
            <HeaderStyle Width="10%" />
            <ItemStyle Width="10%" />
                <EditItemTemplate >
                    <asp:Label ID="lblVNumberEdit" runat="server"  Text='<%#Eval("VehicleNumber") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblVNumber" runat="server" Text='<%#Eval("VehicleNumber") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Start Date">
            <HeaderStyle Width="9%" />
            <ItemStyle Width="9%" />
                <EditItemTemplate>
                    <asp:TextBox ID="txtStartDt" runat="server" Text='<%#Eval("StartDt") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblStartDt" runat="server" Text='<%#Eval("StartDt") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="End Date">
            <HeaderStyle Width="9%" />
            <ItemStyle Width="9%" />
                <EditItemTemplate>
                    <asp:TextBox ID="txtEndDt" runat="server" Text ='<%# Eval("EndDt") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblEndDt" runat="server" Text ='<%# Eval("EndDt") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Start Point">
            <HeaderStyle Width="10%" />
            <ItemStyle Width="10%" />
                <EditItemTemplate>
                    <asp:TextBox ID="txtStartPoint" runat="server" Text='<%#Eval("StartPnt") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblStartPoint" runat="server" Text='<%#Eval("StartPnt") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="End Point" >
            <HeaderStyle Width="10%" />
            <ItemStyle Width="10%" />
                <EditItemTemplate>
                    <asp:TextBox ID="txtEndPnt" runat="server" Text ='<%# Eval("EndPnt") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblEndPnt" runat="server" Text ='<%# Eval("EndPnt") %>'></asp:Label>
                </ItemTemplate>
              
            </asp:TemplateField>
            <asp:TemplateField HeaderText="RunningDays (M Tu W Th F Sa Su)">
            <HeaderStyle Width="10%" />
            <ItemStyle Width="10%" />
                <EditItemTemplate>
                    <asp:TextBox ID="txtRunningDays" runat="server" Text ='<%# Eval("RunningDays") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblRunningDays" runat="server" Text ='<%# Eval("RunningDays") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Way Points">
            <HeaderStyle Width="20%" />
            <ItemStyle Width="20%" Wrap ="true" />
                <EditItemTemplate>
                    <asp:TextBox ID="txtWayPoints" runat="server" Text ='<%# Eval("AllWayPoints") %>' TextMode="MultiLine"  ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblIntermediatepoint1" runat="server"  Text ='<%# Eval("AllWayPoints") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>                     
            
            <asp:CommandField ShowEditButton="True"  ControlStyle-ForeColor="black"/>
            <asp:CommandField ShowDeleteButton="True"  ControlStyle-ForeColor="black"/>
        </Columns>
        <HeaderStyle BackColor="black" ForeColor="White" />
    </asp:GridView>

            </td>
        </tr>
        <tr>
        <td align="center">
        <div style="color :Red " id="divNote" runat ="server">
        Note: In Running Days <b>1:</b> Shows Car Pool  available to the corresponding day<br />
                              <b>0:</b> Shows Car Pool not available to the corresponding day
        </div>
        <%--<asp:GridView ID="grdRouteDetail" runat="server" AutoGenerateColumns="False" 
                    onrowcancelingedit="grdRouteDetail_RowCancelingEdit" 
                    onrowdeleting="grdRouteDetail_RowDeleting" onrowediting="grdRouteDetail_RowEditing" 
                    onrowupdating="grdRouteDetail_RowUpdating" >
        <Columns>
            <asp:TemplateField HeaderText="Route Id" Visible="false">
                <EditItemTemplate>
                    <asp:Label ID="lblrtIdEdit" runat="server" Text='<%#Eval("RouteID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblrtId" runat="server" Text='<%#Eval("RouteID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>       
            <asp:TemplateField HeaderText="Reg. Vehicle Number">
                <EditItemTemplate>
                    <asp:Label ID="lblVNumberEdit" runat="server" Text='<%#Eval("VehicleNumber") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblVNumber" runat="server" Text='<%#Eval("VehicleNumber") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Start Date">
                <EditItemTemplate>
                    <asp:TextBox ID="txtStartDt" runat="server" Text='<%#Eval("StartDate") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblStartDt" runat="server" Text='<%#Eval("StartDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="End Date">
                <EditItemTemplate>
                    <asp:TextBox ID="txtEndDt" runat="server" Text ='<%# Eval("EndDate") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblEndDt" runat="server" Text ='<%# Eval("EndDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Start Point">
                <EditItemTemplate>
                    <asp:TextBox ID="txtStartPoint" runat="server" Text='<%#Eval("StartPnt") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblStartPoint" runat="server" Text='<%#Eval("StartPnt") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="End Point" >
                <EditItemTemplate>
                    <asp:TextBox ID="txtEndPnt" runat="server" Text ='<%# Eval("EndPnt") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblEndPnt" runat="server" Text ='<%# Eval("EndPnt") %>'></asp:Label>
                </ItemTemplate>
              
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Running Days">
                <EditItemTemplate>
                    <asp:TextBox ID="txtRunningDays" runat="server" Text ='<%# Eval("RunningDays") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblRunningDays" runat="server" Text ='<%# Eval("RunningDays") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:HyperLinkField DataNavigateUrlFields="StartPnt,EndPnt , IMPnt1,IMPnt2 , IMPnt3 , IMPnt4 ,IMPnt5 ,IMPnt6,IMPnt7 , IMPnt8 ,IMPnt9 , IMPnt10 " 
                Text="Show Way Points" DataNavigateUrlFormatString="~/ShowWayPoints.aspx?strtPt={0}&endPt={1}&imPt1={2}&imPt2={3}&imPt3={4}&imPt4={5}&imPt5={6}&imPt6={7}&imPt7={8}&imPt8={9}&imPt9={10}&imPt10={11}"  />

            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
            <HeaderStyle BackColor="#6666FF" ForeColor="White" />
    </asp:GridView>--%>
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
        <td align="center" class="style1">
        <asp:LinkButton ID="lnkNewRoute" runat="server" onclick="lnkNewRoute_Click" ControlStyle-ForeColor="black" >Add New Route</asp:LinkButton>
        </td> 
        </tr>
    </table>
</asp:Content>


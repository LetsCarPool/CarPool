<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdsUp.ascx.cs" Inherits="AdsUp" %>
 <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
    <table class="style1">
    <tr>
        <td class="style14">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
            <asp:Image ID="imgchange" runat="server" Height="236px" Width="341px" BorderStyle="Solid" />       
                <asp:Timer ID="imgtimer" runat="server" Interval="7000" ontick="imgtimer_Tick">
                </asp:Timer>

            </ContentTemplate>

            </asp:UpdatePanel>
            </td>
            </tr>
            </table>
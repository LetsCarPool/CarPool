<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Waypoints.aspx.cs" Inherits="Waypoints" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Directions Waypoints</title>
<link href="Styles/Site.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false&libraries=places"></script>
<script type="text/javascript">

    function Initialize() {

        directionsDisplay = new google.maps.DirectionsRenderer();
        var mapOptions = {
            center: new google.maps.LatLng(20.59, 78.96),
            types: ['(cities)'],
            zoom: 6,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        var map = new google.maps.Map(document.getElementById('GMap1'), mapOptions);

        directionsDisplay.setMap(map);

        var input = document.getElementById('txtStartPoint');
        var autocomplete = new google.maps.places.Autocomplete(input);
        var output = document.getElementById('txtEndPoint');
        var autocomplete = new google.maps.places.Autocomplete(output);
        var waypts = document.getElementById('txtWaypoints');
        var autocomplete = new google.maps.places.Autocomplete(waypts);
        autocomplete.bindTo('bounds', map);

        google.maps.event.addListener(autocomplete, 'place_changed', function () {

            var place = autocomplete.getPlace();
            if (place.geometry.viewport) {
                map.fitBounds(place.geometry.viewport);
            } else {
                map.setCenter(place.geometry.location);
                map.setZoom(17);
            }
        });

    }
    google.maps.event.addDomListener(window, 'load', Initialize);

</script>
<script src="Scripts/waypoints.js" type="text/javascript"></script>
    <style type="text/css">
        #lstWayPoints
        {
            width: 239px;
            height: 103px;
        }
        .style1
        {
            height: 107px;
        }
        .style2
        {
            width: 101px;
        }
        .style3
        {
            height: 107px;
            width: 101px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color:#7CEAE6;">
            <div>
               <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/HomeImg.png" Height="70px" Width="100%"                 
                    />
            </div>
            <div  style="background-image:url('Images/login.png');  margin-top:0px; height:20px; background-repeat:repeat" >
            <table >
            <tr>
            <td align="right" style="height:20px; width:1500px">
                <asp:Label ID="lblWelcome" runat="server" Text="Welcome " Visible="False" 
                    Font-Bold="True" ForeColor="White" ></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="lnkLogin" runat="server" onclick="lnkLogin_Click" 
                    CausesValidation="False" Font-Bold="True" ForeColor="White" >Log In</asp:LinkButton>
                    </td>
                    </tr>
            </table>   
            </div>
            <div class="clear hideSkiplink" >
                <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/UserAccount.aspx" Text="Home"/>
                        <asp:MenuItem NavigateUrl="~/About.aspx" Text="About"/>
                                                <asp:MenuItem NavigateUrl="~/MyCars.aspx" Text="My Cars"/>
                        <asp:MenuItem NavigateUrl="~/MyRoutes.aspx" Text="My Routes"/>
                                                <asp:MenuItem NavigateUrl="~/JoinedPassengers.aspx" Text="Joined"/>
                    </Items>
                </asp:Menu>
            </div>
</div>
    <div style="float:left;width:60%;height:100%;">
    <%--<input type="text" id="TextBox1" />--%>
    <div id="GMap1" style="height: 500px; width:800px" ></div>
    </div>
    <div id="Controls" style="float:right;width:40%;background:#A4A4C1">
    <table>
        <tr>
            <td>
               <b> Car Details:</b>
            </td>
            <td><asp:DropDownList ID="ddlCarInfo" runat="server" ></asp:DropDownList>
            </td>
            <td></td>
        </tr>
        <tr>
            <td colspan="3"><a href="RegisterCar.aspx" >Register Another Car</a></td>
        </tr>
        <tr>
            <td><b>Start Point:</b></td>
            <td>
            <input type="text" id="txtStartPoint" size="40" runat="server"/>
            </td>
            <td></td>
        </tr>
        <tr>
            <td><b>End Point:</b></td>
            <td>
            <input type="text" id="txtEndPoint" size="40" runat="server" />
            </td>
            <td></td>
        </tr>
        <tr><td><b>Waypoints:</b></td>
            <td>
            <asp:ListBox ID="lstWayPoints" runat="server"  Width="275px"></asp:ListBox>
            </td>
            <td>
                        <input type="button" value="Add &#010; WayPoints" 
                onclick="appendOptionLast(count1++);" 
                style="width: 100px; " class="btnStyle" /> <br /> <br />
                            <input type="button" 
                value="Remove &#010; WayPoints" onclick="removeOptionSelected(); " 
                style="width: 100px" class="btnStyle" />


            </td>
        </tr>
        <tr>
            <td><b>Enter WayPoints:</b></td>
            <td><input type="text" id="txtWaypoints" size="40" /></td>
            <td>

            </td>
        </tr>
        <tr>
            <td align="left" colspan="3">            
            <input type="submit" 
                onclick="calcRoute();return false;" value="Get Route" class="btnStyle" style="width: 116px; height:30px " /> &nbsp;
            <asp:Button ID="btnSelectDates" runat="server" Text="Select Dates" 
                class="btnStyle" Width="131px" Height="30px" onclick="btnSelectDates_Click"/>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <table border="1" style="border-style:none;width:300px;">
                    <tr><th>Formatted Directions</th></tr>
                    <tr style="width:400px;height:210px">
                        <td><div id="directions_panel"  style="margin:20px;background-color:#FFF;width:400px;height:210px;overflow:auto;"></div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </div>
    <div class="clear">
        </div> 
        <div class="footer" style="color: #FFFFFF">
        
        CopyRight Reserved @Infosys</div>
    <asp:hiddenfield id ="hdnLstWayPoints" runat="server"></asp:hiddenfield>
    <asp:hiddenfield id ="hdnCarInfo" runat="server"></asp:hiddenfield>
    </form>
</body>
</html>

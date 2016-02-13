<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestMap.aspx.cs" Inherits="TestMap" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test Map Page</title>

    <style type="text/css">       
        #Search          
        {      
            z-index: 9999;         
            background-color: #fff;         
            padding: 5px;         
            border: 1px solid #999;       
            }     
     </style>

<script src="https://maps.googleapis.com/maps/api/js?v=3.exp&sensor=false&libraries=places" type="text/javascript"></script> 
<script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
<link href="http://code.google.com/apis/maps/documentation/javascript/examples/default.css" rel="stylesheet" type="text/css" />
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js" type="text/javascript"></script>
<script type="text/javascript">

    function Initialize() {

        var India = new google.maps.LatLng(20.59, 78.96);
        var myOptions = {
            zoom: 6,
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            center: India
        }
        var map = new google.maps.Map(document.getElementById('map_canvas'), myOptions);

        var input = document.getElementById('txtStart');
        var autocomplete = new google.maps.places.Autocomplete(input);
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

</head>
<body onload="Initialize()">
    <form id="form1" runat="server" style="height:100%">
    <div id="Search" style="z-index:9999">
        <asp:Label ID="lblStart" runat="server" Text="Start Point"></asp:Label>
        <input type="text" id="txtStart" size="50" style="width:500px;"  />
    </div>
    <div id="map_canvas" style="float:left;width:60%;height:100%"></div>
    </form>
</body>
</html>


    var directionDisplay;
    var directionsService = new google.maps.DirectionsService();
    var map;

 
//Modolog Seema: Commented the initialize function. It is now handled in the WayPoints.aspx page
//    function initialize() {
//        directionsDisplay = new google.maps.DirectionsRenderer();
//        var India = new google.maps.LatLng(20.59, 78.96);
//        var myOptions = {
//            zoom: 6,
//            mapTypeId: google.maps.MapTypeId.ROADMAP,
//            center: India
//        }
//        map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);
//        directionsDisplay.setMap(map);


//        //-----------------------Auto completion Starts--------------------------
//        var autocomplete;
//        var startInput = document.getElementById('txtStartPoint');
//        autocomplete = new google.maps.places.Autocomplete(startInput);
//        var startOutput = document.getElementById('txtEndPoint');
//        autocomplete = new google.maps.places.Autocomplete(startOutput);
//        var waypts = document.getElementById('txtWaypoints');
//        autocomplete = new google.maps.places.Autocomplete(waypts);
//        autocomplete.bindTo('bounds', map);

//        // var infowindow = new google.maps.InfoWindow();
//        // var marker = new google.maps.Marker({
//        //  map: map
//        // });

//        google.maps.event.addListener(autocomplete, 'place_changed', function () {
//            // infowindow.close();
//            var place = autocomplete.getPlace();
//            if (place.geometry.viewport) {
//                map.fitBounds(place.geometry.viewport);
//            } else {
//                map.setCenter(place.geometry.location);
//                map.setZoom(17);  // Why 17? Because it looks good.
//            }

//            var image = new google.maps.MarkerImage(
//              place.icon,
//              new google.maps.Size(71, 71),
//              new google.maps.Point(0, 0),
//              new google.maps.Point(17, 34),
//              new google.maps.Size(35, 35));
//            // marker.setIcon(image);
//            // marker.setPosition(place.geometry.location);

//            var address = '';
//            if (place.address_components) {
//                address = [(place.address_components[0] &&
//                        place.address_components[0].short_name || ''),
//                       (place.address_components[1] &&
//                        place.address_components[1].short_name || ''),
//                       (place.address_components[2] &&
//                        place.address_components[2].short_name || '')
//                      ].join(' ');
//            }

//            //infowindow.setContent('<div><strong>' + place.name + '</strong><br>' + address);
//            // infowindow.open(map, marker);
//        });
//        google.maps.event.addDomListener(window, 'load', initialize);

//        //-----------------------Auto completion Ends--------------------------
    //    }

    

    function calcRoute() {
       
        var start = document.getElementById("txtStartPoint").value;
        var end = document.getElementById("txtEndPoint").value;
        var waypts = [];     
        var checkboxArray = document.getElementById("lstWayPoints");
      
        if (checkboxArray.length != 0 ) { 
      
        for (var i = 0; i < checkboxArray.length; i++) {
            //if (checkboxArray.options[i].selected == true) {
                waypts.push({
                    location: checkboxArray[i].value,
                    stopover: true
                });
            //}
        }

        var request = {
            origin: start,
            destination: end,
            waypoints: waypts,
            optimizeWaypoints: true,
            travelMode: google.maps.DirectionsTravelMode.DRIVING
        };
        directionsService.route(request, function (response, status) {
            if (status == google.maps.DirectionsStatus.OK) {
                directionsDisplay.setDirections(response);
                var route = response.routes[0];
                var summaryPanel = document.getElementById("directions_panel");
                summaryPanel.innerHTML = "";
                // For each route, display summary information.
                for (var i = 0; i < route.legs.length; i++) {
                    var routeSegment = i + 1;
                    summaryPanel.innerHTML += "<b>Route Segment: " + routeSegment + "</b><br />";
                    summaryPanel.innerHTML += route.legs[i].start_address + " to ";
                    summaryPanel.innerHTML += route.legs[i].end_address + "<br />";
                    summaryPanel.innerHTML += route.legs[i].distance.text + "<br /><br />";
                }
            }
        });
    }
    else
        alert('Please select and add atleast one way point to the list!'); 
    }
    var count1 = 0;   

    function insertOptionBefore(num) {

        var elSel = document.getElementById('lstWayPoints');
        debugger;
        
       if (elSel.innerHTML != "") {
           if (elSel.selectedIndex >= 0) {
                var elOptNew = document.createElement('option');
                elOptNew.text = document.getElementById('txtWaypoints').value;
                elOptNew.value = document.getElementById('txtWaypoints').value//'insert' + num;
                //elOptNew.value = document.getElementById('txtWaypoints').value;
                //
               var elOptOld = elSel.options[elSel.selectedIndex];
                try {
                    if (elOptNew.text != "")
                        elSel.add(elOptNew, null);
                    else if (elOptNew.text == "")
                        alert('Please Enter WayPoint in The TextField')
                }
                catch (ex) {
                    elSel.add(elOptNew);
                    // IE only
                }
                document.getElementById('txtWaypoints').value = "";
         }
          else {
           alert('Select any one from the list to add new waypoint');
          }
        }
       else {

            var elOptNew = document.createElement('option');
            elOptNew.text = document.getElementById('txtWaypoints').value;
            elOptNew.value = document.getElementById('txtWaypoints').value//'insert' + num;
            //elOptNew.value = document.getElementById('txtWaypoints').value;
            //
            var elOptOld = 0//elSel.options[elSel.selectedIndex];
            try {

                if (elOptNew.text != "")
                    elSel.add(elOptNew, null);

                else if (elOptNew.text == "")
                    alert('Please Enter WayPoint in The TextField')
            }
            catch (ex) {
                elSel.add(elOptNew);
                // IE only
            }
            document.getElementById('txtWaypoints').value = "";
        }            

  }

    function removeOptionSelected() {
        var elSel = document.getElementById('lstWayPoints');
        var i;
        //var hdnItemList = document.getElementById('hdnLstWayPoints');
        var hdnItemList = document.getElementById('lstWayPoints');
        var itemLst = hdnItemList.value;
        var items = itemLst.split(';');
        hdnItemList = '';
       
        for (i = elSel.length - 1; i >= 0; i--) {
            if (elSel.options[i].selected) {
                items.splice(i, 1); 
                elSel.remove(i);
            }
        }

        for (var j = 0; j <= items.length - 1; j++) {           
            hdnItemList.value += items[j] + ';';
        }

        document.getElementById('hdnLstWayPoints').value = hdnItemList.value;
        
        
    }

    function appendOptionLast(num) {
         if (document.getElementById('txtWaypoints').value != "Enter a location" && document.getElementById('txtWaypoints').value != "") {
            var elOptNew = document.createElement('option');
            elOptNew.text = document.getElementById('txtWaypoints').value;
            elOptNew.value = document.getElementById('txtWaypoints').value;
            var elSel = document.getElementById('lstWayPoints');

             
                document.getElementById('hdnLstWayPoints').value += elOptNew.value + ";";
                try {
                    if (elSel.options.length <= 10) {
                        elSel.add(elOptNew, null); // standards compliant; doesn't work in IE
                    }
                }
                catch (ex) {
                    if (elSel.options.length <=10) {
                        elSel.add(elOptNew); // IE only
                    }
                }
                document.getElementById('txtWaypoints').value = "";
            }
            else {
                alert('Please select any one way point');
            }

        }
    

    function removeOptionLast() {
        var elSel = document.getElementById('lstWayPoints');
        if (elSel.length > 0) {
            elSel.remove(elSel.length - 1);
            removeLastOptionFrmHidden();
        }
    }

    function removeLastOptionFrmHidden() {
    var hdnItemList=document.getElementById('hdnLstWayPoints');
    var itemLst = hdnItemList.value;
    var items = itemLst.split(';');
    hdnItemList = '';
        for (var i = 0; i < items.length-2; i++) {
            hdnItemList.value += items[i] + ';';
        }
    }


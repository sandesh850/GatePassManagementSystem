
//Request for Gate Pass Page
function checkBox() {

    if ($("#checkStatus").is(":checked")) {

        $("#LblVehicleNo").html('<div>'+
            '<label style = "font-size:90%;color:blue"> VEHICLE NUMBER</label>'+
            '</div>');



        $("#VehicleNo").html('<div class="position-relative">'+
            '<input type = "text" class= "form-control" style = "font-size:100%;opacity:60%" placeholder = "e.g. ABC - 1234" >'+
            '</div>');    
            
    }
    else {
        $("#LblVehicleNo").html('');
        $("#VehicleNo").html('');
    }
}

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

/*User account creation page | Employee photo preview section*/
document.getElementById("photoInput").addEventListener("change", function (event) {

    const file = event.target.files[0];

    if (file) {

        const reader = new FileReader();

        reader.onload = function (e) {

            const image = document.getElementById("previewImage");

            image.src = e.target.result;
            image.style.width = "100%";
            image.style.height = "100%";
            image.style.objectFit = "cover";
            image.style.opacity = "1";

        };

        reader.readAsDataURL(file);

    }

});
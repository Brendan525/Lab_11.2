
function displayAddress() {
    if (document.getElementById('pickup').checked) {
        document.getElementById('pickUpTime').style.display = 'block';
    }
    else document.getElementById('pickUpTime').style.display = 'none';
}

//function displayDelivery() {
//    if (document.getElementById('delivery').checked) {
//        document.getElementById('DeliveryTime').style.display = 'block';
//    }
//    else document.getElementById('DeliveryTime').style.display = 'none';
//}
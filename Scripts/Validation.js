

function displayAddressOrPickUpTime() {
    if (document.getElementById('pick').checked) {
        document.getElementById('pickup').style.display = 'block';
    }
    else document.getElementById('pickup').style.display = 'none';
}
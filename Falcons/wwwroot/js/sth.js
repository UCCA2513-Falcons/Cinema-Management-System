function checkOut() {
    var selectedSeats = [];

    var $selectedSeat = $('#selected-seats li').each(function () {
        var selectedSeat = {};
        selectedSeat.seatID = $(this).data("seatId");
        selectedSeat.seatPrice = $(this).data("seatPrice");
        selectedSeats.push(selectedSeat);
    });

    //var myUrl = $("#AppUrl").val();
    var myUrl = "/"
    $.ajax({
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        type: 'POST',
        url: myUrl + 'api/SeatBooking',
        type: 'POST',
        data: JSON.stringify(selectedSeats),
        success: function (data) {
            alert('Tickets Booked Successfully...!!!');
            $('#selected-seats').empty();
            window.location = "/SeatBooking";
        },
        failure: function (response) {
            alert("Tickets Booking Failed...!!!");
        }
    });
}

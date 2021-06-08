
function calcClick() {
    alert("12");
}

$("#document").ready(function () {
    debugger;

    function calcClick() {
        alert("12");
    }

    $("#btnCalc6").click(function () {
        $("#toTxt").css('background-color', 'red')
        alert("1");
    });


    $("#btnCalc").click(function () {
        // alert("");
        var data = {};
        //data.FromCurrency = $("#toTxt").val();
        data.ToAmount = $("#toTxt").val();

        $.ajax({
            type: 'POST',
            url: '/Home/Calc',
            data:  'data: ' + JSON.stringify(data) + '}',
            dataType: 'json',
            contextType: 'application/json; charset=utf-8',
            success: function (data) {
                alert('Data: ' + data);
            },
            error: function (request, error) {
                alert("Request: " + JSON.stringify(request));
            }
        });
    });
});
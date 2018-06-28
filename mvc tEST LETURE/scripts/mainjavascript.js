$(document).ready(function () {
    var Students = {
        Name: $("#txtName").val(""),
        Address: $("#txtAddress").val(""),
        ContactNumber: $("#txtContact").val()
    }
    var formData = JSON.stringify($("#FormInsert").serializeArray());
    $ajax({
        url: "Main/InsertData",
        type: "POST",
        dataType: "JSON",
        data: Students,
        success:function(response)
        {
            alert("Done");
        }

    });
});
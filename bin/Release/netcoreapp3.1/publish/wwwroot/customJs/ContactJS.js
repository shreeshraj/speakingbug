
$(document).ready(function () {

    $("#btnSubmit").click(function () {
        if ($("#contact-form").valid()) {
            submitFeedback();
        }

    });
});
function submitFeedback() {
    var formData = {};
    formData.Name = $("#Name").val();
    formData.Email = $("#Email").val();
    formData.Subject = $("#Subject").val();
    formData.Message = $("#Message").val();
    console.log(JSON.stringify(formData));
    $.ajax({
        type: "POST",
        url: "/api/UserApi/Feedback",
        data: JSON.stringify(formData),

        contentType: "application/json; charset=utf-8",

        success: function (data) {
            $('input[type="text"]').val('');
            $("#lblMessage").html("<center><p>Thanks for connecting with Us!</center></p>");
            $("#modalRelatedContent").modal('show');

        },
        fail: function (jqXHR, textStatus) {
            alert("Request failed: " + textStatus);
        }
    });
}

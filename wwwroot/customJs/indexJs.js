
$(document).ready(function () {
    loadOnlineUsers();
    $("#btnSubmit").click(function () {

        addUser();
    });
});
function addUser() {

    if ($("#userForm").valid()) {
        var formData = {};
        formData.Name = $("#Name").val();
        formData.Age = $("#Age").val();
        formData.Sex = $("#ddlGender").children("option:selected").val();
        formData.Location = $("#ddlCountry").children("option:selected").val();;
        formData.Skype = $("#Skype").val();
        console.log(JSON.stringify(formData));
        $.ajax({
            type: "POST",
            url: "/api/UserApi/Registration",
            data: JSON.stringify(formData),

            contentType: "application/json; charset=utf-8",

            success: function (data) {
                $("#lblMessage").html("<p>Now You are Online!</p>");
                $("#modalRelatedContent").modal('show');
                $("#btnSubmit").attr("disabled", true);
                loadOnlineUsers();

            },
            fail: function (jqXHR, textStatus) {
                alert("Request failed: " + textStatus);
            }
        });
    }
}


function loadOnlineUsers() {

    var config =
    {
        url: '/api/UserApi/UsersList',
        data: { "limit": 0 },
        element: '.row'
    };
    populateCards(config);
}

var start = 0;
var working = false;
var counter = 0;
function populateCards(config) {

    $("#profileList").html('');
    $("#loading").show();
    if (config.element !== undefined) {
        $(config.element).unbind();
    }
    $.ajax({
        type: "GET",
        url: config.url,
        data: config.data,
        success: function (res) {
            console.log(res);
            if (res !== null) {
                $.each (res, function (index, value) {
                    $("#profileList").append(`<div class="col-xs-12 col-sm-6 col-md-4">
                        <div class="image-flip" ontouchstart="this.classList.toggle('hover');">
                        <div class="mainflip">
                        <div class="frontside">
                            <div class="card">
                                <div class="card-body text-center" id="lblSocialIcon">
                                   <p><img class=" img-fluid" src=/profilepic/${value.sex}.jpg alt=${value.sex}/></p>
                                    Name:-<b>${value.name}</b><br />
                                    Age:-<b>${value.age}</b><br />
                                    Country:-<b>${value.location}</b><br />

                                    <a class="social-icon" style="padding:4%;" target="_blank" href=${value.skype}><i class="fa fa-skype fa-2x"></i> </a>
                                  
                                </div>
                            </div>
                        </div>
                    </div></div></div>`);
                });

                counter = counter + 1;
                config.data.limit = counter;
                infiniteScroll(config);
            }
            else {

                $("#lblMessage").html("<center><p>No Online User Found!</center></p>");
                $("#modalRelatedContent").modal('show');

            }
            $("#loading").hide();
        },
        error: function (err) {
            $("#loading").hide();
            console.log(err);

        }
    });
}
var infiniteScroll = function (config = {}) {
    $(window).scroll(function () {
        if ($(window).scrollTop() == $(document).height() - $(window).height()) {

            if (working === false) {
                $("#loading").show();
                working = true;
                $.ajax({
                    type: "GET",
                    url: config.url,
                    data: config.data,
                    cache: false,

                    success: function (res) {
                        console.log(res);
                        if (res.length > 0) {
                            $.each(res, function (index, value) {
                                $("#profileList").append(`<div class="col-xs-12 col-sm-6 col-md-4">
                                <div class="image-flip" ontouchstart="this.classList.toggle('hover');">
                                <div class="mainflip">
                                <div class="frontside">
                                    <div class="card">
                                        <div class="card-body text-center" id="lblSocialIcon">
                                           <p><img class=" img-fluid" src=/profilepic/${value.sex}.jpg alt=${value.sex}/></p>
                                            Name:-<b>${value.name}</b><br />
                                            Age:-<b>${value.age}</b><br />
                                            Country:-<b>${value.location}</b><br />
        
                                            <a class="social-icon" style="padding:4%;" target="_blank" href=${value.skype}><i class="fa fa-skype fa-2x"></i> </a>
                                          
                                        </div>
                                    </div>
                                </div>
                            </div></div></div>`);
                            });
                            working = false;

                        }
                        else {
                            $("#loading").hide();
                            $("#lblMessage").html("<center><p>No More Online User Found!</center></p>");
                            $("#modalRelatedContent").modal('show');


                        }


                        var alreadyFrom = config.data.limit;
                        start = alreadyFrom + 1;

                        config.data.limit = start;
                        $("#loading").hide();
                    },
                    error: function (err) {
                        $("#loading").hide();
                        console.log(err);


                    }
                });
            }
        }

    });
}


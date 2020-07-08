
$(document).ready(function () {
    loadWords();
});
var start = 0;
var working = false;
var counter = 0;
function loadWords() {
    var config =
    {
        url: '/api/UserApi/AllWords',
        data: { "limit": 0 },
        element: '.row'
    };
    populateCards(config);
}

function populateCards(config) {
    $.ajax({
        type: "GET",
        url: config.url,
        data: config.data,
        success: function (res) {
            if (res.length > 0) {
                $.each(res, function (index, value) {
                    $("#appendWord").append(`<div class="card text-center" style="margin-top:2%">

            <div class="card-body">
                <h5 class="card-title">${value.word}</h5>
                <p class="card-text">${value.description}</p>
                <a href=https://www.google.com/search?q=${value.word}+meaning target="_blank" class="btn btn-primary btn-sm">Go To Source</a>
            </div>
            <div class="card-footer text-muted">
               ${value.Date}
            </div>
        </div>`);
                });

                counter = counter + 1;
                config.data.limit = counter;
                infiniteScroll(config);
            }
            else {
                $("#lblMessage").html("<center><p>No More New Words Found!</center></p>");
                $("#modalRelatedContent").modal('show');
            }


        }

    });
}

var infiniteScroll = function (config = {}) {
    $(window).scroll(function () {
        if ($(window).scrollTop() == $(document).height() - $(window).height()) {

            if (working === false) {
                working = true;
                $.ajax({
                    type: "GET",
                    url: config.url,
                    data: config.data,
                    cache: false,
                    success: function (res) {
                        if (res.length > 0) {
                            $.each(res, function (index, value) {
                                $("#appendWord").append(`<div class="card text-center" style="margin-top:2%">

                                        <div class="card-body">
                                        <h5 class="card-title">${value.word}</h5>
                                        <p class="card-text">${value.description}</p>
                                           <a href=https://www.google.com/search?q=${value.word}+meaning target="_blank" class="btn btn-primary btn-sm">Go To Source</a>
                                        </div>
                                       <div class="card-footer text-muted">
                                      ${value.date}
                                      </div> </div>`);
                            });
                            working = false;
                        }

                        else {
                            $("#loading").hide();
                            $("#lblMessage").html("<center><p>No More New Words Found!</center></p>");
                            $("#modalRelatedContent").modal('show');

                        }
                        var alreadyFrom = config.data.limit;
                        start = alreadyFrom + 1;

                        config.data.limit = start;

                    },
                    error: function (err) {

                        console.log(err);


                    }
                });
            }
        }

    });
}


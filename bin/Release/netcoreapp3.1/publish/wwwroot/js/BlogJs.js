
$(document).ready(function () {
    loadBlogs();
});
var start = 0;
var working = false;
var counter = 0;
function loadBlogs() {
    var config =
    {
        url: '/api/ResourcesApi/GetAllBlogs',
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
                $.each(res, function (index, bloPost) {
                    $("#bloPost").append(`<div class="card " style="margin-top:2%">

            <div class="card-body">
                <div class="row">
                 
                    <div class="col-12">
                        <h5 class="card-title">${bloPost.Title}</h5>
                        <p class="card-text">
                           ${bloPost.Description}
                            <a href=/Home/DisplayBlog?Id=${bloPost.Id}>View More</a>
                        </p>

                    </div>

                </div>

            </div>

        </div>`);
                });

                counter = counter + 1;
                config.data.limit = counter;
                infiniteScroll(config);
            }
            else {
                $("#lblMessage").html("<center><p>No More New Post Found!</center></p>");
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
                            $.each(res, function (index, bloPost) {
                                $("#bloPost").append(`<div class="card " style="margin-top:2%">

            <div class="card-body">
                <div class="row">
                 
                    <div class="col-12">
                        <h5 class="card-title">${bloPost.Title}</h5>
                        <p class="card-text">
                           ${bloPost.Description}
                            <a href=/Home/DisplayBlog?Id=${bloPost.Id}>View More</a>
                        </p>

                    </div>

                </div>

            </div>

        </div>`);
                            });
                            working = false;

                        }
                        else {
                            $("#loading").hide();
                            $("#lblMessage").html("<center><p>No More New Post Found!</center></p>");
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

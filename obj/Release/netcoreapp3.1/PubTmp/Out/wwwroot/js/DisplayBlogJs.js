
$(document).ready(function () {

    const params = new URLSearchParams(window.location.search);
    const Id = params.get("Id");
    populateCards(Id);
});
function populateCards(blogId) {
    $.ajax({
        type: "GET",
        url: '/api/ResourcesApi/GeBlog',
        data: { "Id": blogId },
        success: function (res) {

            $("#bloPost").append(`<div class="card " style="margin-top:2%">

            <div class="card-body">
                <div class="row">

                    <div class="col-12">
                        <h5 class="card-title">${res.Title}</h5>
                        <p class="card-text">
                           ${res.Description}
                           
                        </p>

                    </div>

                </div>

            </div>

        </div>`);
        }
    });
}

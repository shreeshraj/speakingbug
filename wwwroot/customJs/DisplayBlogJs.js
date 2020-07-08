
$(document).ready(function () {

    const params = new URLSearchParams(window.location.search);
    const Id = params.get("Id");
    populateCards(Id);
});
function populateCards(blogId) {
    $.ajax({
        type: "GET",
        url: '/api/UserApi/Blog',
        data: { "Id": blogId },
        success: function (res) {

            $("#bloPost").append(`<div class="card " style="margin-top:2%">

            <div class="card-body">
                <div class="row">

                    <div class="col-12">
                        <h5 class="card-title">${res.title}</h5>
                        <p class="card-text">
                           ${res.description}
                           
                        </p>

                    </div>

                </div>

            </div>

        </div>`);
        }
    });
}

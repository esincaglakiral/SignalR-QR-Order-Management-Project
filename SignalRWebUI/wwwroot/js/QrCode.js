$(function () {
    $(".btnqdecoder").click(async function () {
        var image = document.querySelector(".image");
        $.ajax({
            url: '/qrCode/IndexJson/',
            data: { 'image': image.src },
            type: 'post',
            success: function (data) {

            }
        });
    });
});

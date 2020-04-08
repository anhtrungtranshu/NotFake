// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $(function () {
        $('[data-toggle="tooltip"]').tooltip()
    });

    // slick
    $(".slick-carousel__home").slick({
        lazyLoad: 'ondemand',
        slidesToShow: 4,
        slidesToScroll: 2,
        prevArrow: "<button class='slic-prev slick-arrow'><i class='fas fa-chevron-left'></i></button>",
        nextArrow: "<button class='slic-next slick-arrow'><i class='fas fa-chevron-right'></i></button>"
    });

    $(".slick-carousel__detail").slick({
        slidesToShow: 4,
        slidesToScroll: 2,
        prevArrow: "<button class='slic-prev slick-arrow'><i class='fas fa-chevron-left'></i></button>",
        nextArrow: "<button class='slic-next slick-arrow'><i class='fas fa-chevron-right'></i></button>"
    });


    // var mediaPlayer = $("#main-video")[0];
    // mediaPlayer.controls = false;

    // $("#play-pause-button").on("click", function () {
    //     if (mediaPlayer.paused || mediaPlayer.ended) {
    //         $(this).title = "pause";
    //         // $(this).empty();
    //         $(this).innerHTML = "<i class='fas fa-pause'></i>";
    //         mediaPlayer.play();
    //     }
    //     else {
    //         $(this).title = "pause";
    //         // $(this).empty();
    //         $(this).innerHTML = "<i class='fas fa-play'></i>";
    //         mediaPlayer.pause();
    //     }
    // })
})
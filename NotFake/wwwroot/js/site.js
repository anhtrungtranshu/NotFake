// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $(function () {
        $('[data-toggle="tooltip"]').tooltip()
    });

    // slick
    $(".slick-carousel").slick({
        lazyLoad: 'ondemand',
        slidesToShow: 1,
        slidesToScroll: 1,
        variableWidth: true,
        prevArrow: "<button class='slick-prev slick-arrow'><i class='fas fa-chevron-left'></i></button>",
        nextArrow: "<button class='slick-next slick-arrow'><i class='fas fa-chevron-right'></i></button>",
    })
})
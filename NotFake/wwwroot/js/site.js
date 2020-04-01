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
        slidesToShow: 4,
        slidesToScroll: 2,
        prevArrow: "<button class='slic-prev slick-arrow'><i class='fas fa-chevron-left'></i></button>",
        nextArrow: "<button class='slic-next slick-arrow'><i class='fas fa-chevron-right'></i></button>",
    });

    // $('#filmDetailsTabs a').on('click', function (e) {
    //     e.preventDefault()
    //     $(this).tab('show')
    // });
})
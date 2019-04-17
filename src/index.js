import './scss/index.scss';
import 'bootstrap';
import 'picturefill';
import 'slick-carousel';
var $ = require("jquery");
require('waypoints/lib/noframework.waypoints.min');

// Footer module
var footer = (function() {
    function hasSpaceBelow(windowHeight, bottom) {
        return bottom < windowHeight;
    }

    return {
        // stick footer to bottom of screen if there is space below it
        handleSticky: function() {
            var $element = $('footer').removeClass('sticky'),
                windowHeight = $(window).height(),
                top = $element.offset().top,
                height = $element.outerHeight(),
                bottom = top + height
            ;
    
            $element.toggleClass('sticky', hasSpaceBelow(windowHeight, bottom));
        }
    };
}());

// actions need both on ready and resize events
function readyResize() {
    footer.handleSticky();
}

function attachAnimation(baseName) {
    $('.js-' + baseName).each(function() {
        var that = $(this);

        // Add waypoint which, when triggered, will add a class to begin CSS animation
        new Waypoint({
            element: that[0], 
            handler: function() {
                that.addClass(baseName);
            }, 
            offset: '95%'
        });
    });
}

function handleProductSlider() {
    $('.js-products-slider').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: false,
        fade: true,
        asNavFor: '.js-products-slider-nav'
    });
    
    $('.js-products-slider-nav').slick({
        arrows: true,
        slidesToShow: 4,
        slidesToScroll: 1,
        asNavFor: '.js-products-slider',
        dots: false,
        centerMode: false,
        focusOnSelect: true
    });
}

$(window).on('load', function($){
    footer.handleSticky();
});

$(document).ready(function ($) {
    $('.js-hamburger').click(function () {
        $('.js-menu-container').toggleClass('show');
    });

    readyResize();

    $('.carousel').slick({
        dots: false,
        infinite: true,
        arrows: true,
        slidesToShow: 4,
        slidesToScroll: 2,
        responsive: [{
            breakpoint: 1200,
            settings: {
                slidesToShow: 3,
                slidesToScroll: 1,
                infinite: true,
                arrows: true
            }
        },
        {
            breakpoint: 990,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 2,
                infinite: true,
                arrows: true
            }
        },
        {
            breakpoint: 790,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 2,
                infinite: true,
                arrows: true
            }
        },
        {
            breakpoint: 640,
            settings: {
                slidesToShow: 1,
                slidesToScroll: 1,
            }
        }]
    });

    $('.banner-slider').slick({
        dots: false,
        infinite: true,
        arrows: true,
        slidesToShow: 1,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 7*1000
    });

    attachAnimation('animate-fade-appear');
    attachAnimation('animate-slide-appear');
    handleProductSlider();
});

$(window).resize(function ($) {
    readyResize();
});
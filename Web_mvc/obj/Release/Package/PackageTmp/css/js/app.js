// Check is on screen
(function ($) {
    const $window = $(window);

    $.fn.isOnScreen = function (percent = 1) {
        const $el = $(this);
        let scrollTop = $window.scrollTop();
        let screenHeight = $window.outerHeight();
        let offsetTop = $el.offset().top;
        let height = $el.outerHeight();

        return scrollTop > offsetTop - screenHeight + percent * height && scrollTop < offsetTop + (1 - percent) * height;
    };
})(jQuery);

// count To
(function ($) {
    $.fn.countTo = function (options) {
        // merge the default plugin settings with the custom options
        options = $.extend({}, $.fn.countTo.defaults, options || {});

        // how many times to update the value, and how much to increment the value on each update
        var loops = Math.ceil(options.speed / options.refreshInterval),
            increment = (options.to - options.from) / loops;

        return $(this).each(function () {
            var _this = this,
                loopCount = 0,
                value = options.from,
                interval = setInterval(updateTimer, options.refreshInterval);

            function updateTimer() {
                value += increment;
                loopCount++;
                // $(_this).html(value.toFixed(options.decimals));
                $(_this).html(Math.floor(value).toLocaleString("en"));

                if (typeof options.onUpdate == "function") {
                    options.onUpdate.call(_this, value);
                }

                if (loopCount >= loops) {
                    clearInterval(interval);
                    value = options.to;

                    if (typeof options.onComplete == "function") {
                        options.onComplete.call(_this, value);
                    }
                }
            }
        });
    };

    $.fn.countTo.defaults = {
        from: 0, // the number the element should start at
        to: 100, // the number the element should end at
        speed: 1000, // how long it should take to count between the target numbers
        refreshInterval: 100, // how often the element should be updated
        decimals: 0, // the number of decimal places to show
        onUpdate: null, // callback method for every time the element is updated,
        onComplete: null // callback method for when the element finishes updating
    };
})(jQuery);

jQuery(function ($) {
    // requirement
    if (!$.fn.isOnScreen) {
        console.warn("Jquery.isOnScreen function is required!");
        return;
    }

    const $window = $(window);
    const $count = $(".js-count");

    count();

    $(window).on("scroll", count);

    function count() {
        let vh = $window.outerHeight();
        let scrollTop = $window.scrollTop();

        $count.not(".actived").each(function () {
            let $el = $(this);

            if ($el.isOnScreen(1)) {
                $el.addClass("actived").countTo({
                    from: 0,
                    to: count,
                    speed: 2000,
                    refreshInterval: 5
                });
            }
        });
    }
});

// print content
$(function () {
    $(".js-print-content").on("click", function (e) {
        e.preventDefault();

        const target = $(this).data("target") || $(this).attr("href");

        if (!target) {
            console.log("Target Content is not found!");
            return;
        }

        var printContents = document.querySelector(target).innerHTML;
        var originalContents = document.body.innerHTML;

        document.body.innerHTML = printContents;

        window.print();

        document.body.innerHTML = originalContents;
    });
});

// menu toggle

$(function () {

    $(".menu-toggle").on("click", function () {

        var $toggle = $(this);

        $toggle.toggleClass("active").siblings(".menu-sub").slideToggle();

        $toggle.siblings(".menu-mega").children(".menu-sub").slideToggle();

        $toggle.parent().siblings(".menu-item-group").children(".menu-sub").slideUp();

        $toggle.parent().siblings(".menu-item-group").children(".menu-mega").children(".menu-sub").slideUp();

        $toggle.parent().siblings(".menu-item-group").children(".menu-toggle").removeClass("active");
    });
});

// navbar mobile toggle
$(function () {
    var $body = $("html, body");
    var $navbar = $(".js-navbar");
    var $navbarToggle = $(".js-navbar-toggle");

    $navbarToggle.on("click", function () {
        $navbarToggle.toggleClass("active");
        $navbar.toggleClass("is-show");
        $body.toggleClass("overflow-hidden");
    });
});

// require _scroll-to-dip.js
$(function () {
    var $moveTop = $(".btn-movetop");
    var $window = $(window);

    if (!$moveTop.length) return;

    $window.on("scroll", function () {
        if ($window.scrollTop() > 150) {
            $moveTop.fadeIn();

            return;
        }

        $moveTop.fadeOut();
    });
});

// swiper template
function addSwiper(selector, options = {}) {
    return Array.from(document.querySelectorAll(selector), function (item) {
        var $sliderContainer = $(item),
            $sliderEl = $sliderContainer.find(selector + "__container");

        if (options.navigation) {
            $sliderContainer.addClass("has-nav");
            options.navigation = {
                prevEl: $sliderContainer.find(selector + "__prev"),
                nextEl: $sliderContainer.find(selector + "__next")
            };
        }

        if (options.pagination) {
            $sliderContainer.addClass("has-pagination");
            options.pagination = {
                el: $sliderContainer.find(selector + "__pagination"),
                clickable: true
            };
        }

        return new Swiper($sliderEl, options);
    });
}

$(function () {
    addSwiper(".banner-slider", {
        navigation: true,
        loop: true,
        speed: 800,
        autoplay: {
            delay: 4000,
            disableOnInteraction: false
        }
    });
});

$(function () {
    addSwiper(".partner-slider", {
        navigation: true,
        loop: true,
        speed: 400,
        slidesPerView: 2,
        spaceBetween: 10,
        autoplay: {
            delay: 4000,
            disableOnInteraction: false
        },
        breakpoints: {
            576: {
                slidesPerView: 3
            },
            768: {
                slidesPerView: 4
            },
            992: {
                slidesPerView: 5
            },
            1200: {
                spaceBetween: 24,
                slidesPerView: 6
            }
        }
    });
});

// horizontal preview sync slider
$(function () {
    if (!$(".preview-slider, .thumb-slider").length) {
        return;
    }

    if (!window.addSwiper) {
        console.warn('"addSwiper" funtion is required!');
        return;
    }

    var thumbSlider = addSwiper(".thumb-slider", {
        slidesPerView: 4,
        freeMode: true,
        spaceBetween: 10,
        watchSlidesProgress: true,
        watchSlidesVisibility: true
    })[0];

    addSwiper(".preview-slider", {
        effect: "fade",
        allowTouchMove: false,
        thumbs: {
            swiper: thumbSlider
        }
    });
});

$(function () {
    addSwiper(".cart-slider", {
        navigation: true,
        loop: true,
        slidesPerView: 2,
        spaceBetween: 16,
        speed: 600,
        autoplay: {
            delay: 4000,
            disableOnInteraction: false
        },
        breakpoints: {
            992: {
                slidesPerView: 3
            }
        }
    });
});

// smooth scroll to div

$(function () {

    $(".js-scroll-to").on("click", function (e) {

        e.preventDefault();

        const $el = $(this),
            target = $el.data("target") || $el.attr("href"),
            offset = parseInt($el.data("offset")) || 0,
            duration = parseInt($el.data("duration")) || 800;

        if (!$(target).length) return;

        $("html, body").animate({

            scrollTop: $(target).offset().top - offset

        }, duration);
    });
});

// scroll to fixed div
(function ($) {
    $.fn.scrollFixed = function (options) {
        const $el = $(this);
        const $window = $(window);

        // merge the default plugin settings with the custom options
        options = $.extend({}, $.fn.scrollFixed.defaults, options || {});

        $window.on("scroll", function () {
            let scrollTop = $window.scrollTop();
            let offsetTop = $el.offset().top;
            let height = $el.outerHeight();

            if (scrollTop > offsetTop) {
                $el.addClass("is-fixed").css({
                    height: height,
                    position: "relative",
                    zIndex: 100
                }).children().css({
                    width: "100%",
                    position: "fixed",
                    top: 0,
                    left: 0
                });

                return;
            }

            $el.removeClass("is-fixed").children().css({
                position: "relative"
            });
        });
    };

    $.fn.scrollFixed.defaults = {};
    $(".js-scroll-fixed").scrollFixed();
})(jQuery);

// common.js
$(function () {
    $(window).on("scroll", function () {
        var trigger = false;

        $(".js-cat-section").each(function () {
            const $el = $(this);

            if (!$el.isOnScreen(0.5)) return;

            trigger = true;

            var index = $el.data("catIndex");

            $(".cat-menu__link.active").removeClass("active");

            $(`.cat-menu__link[data-target="[data-cat-index='${index}']"]`).addClass("active");
        });

        if (trigger) {
            $(".cat-menu").addClass("show");
        } else {
            $(".cat-menu").removeClass("show");
        }
    });
});
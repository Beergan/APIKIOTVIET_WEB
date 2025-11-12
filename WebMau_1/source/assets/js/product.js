// price filter
const rangeInput = $('.range4');
const rangeOutput = $('.rangeValue');
rangeInput.each(function (i) {
    const input = $(this);
    const output = rangeOutput.eq(i);
    output.text(input.val() + ' $');
})

rangeInput.on('input', function () {
    const index = rangeInput.index(this);
    const output = rangeOutput.eq(index);
    output.text($(this).val() + ' $');
});

// product slide
$('.slider-for').on('beforeChange', function (event, slick, currentSlide, nextSlide) {
    const $current = $(slick.$slides[currentSlide]);
    const $next = $(slick.$slides[nextSlide]);

    $current.find('.zoomImg').removeClass('animate__animated animate__fadeInRight animate__fadeOutLeft animate__faster');
    $next.find('.zoomImg').removeClass('animate__animated animate__fadeInRight animate__fadeOutLeft animate__faster');

    $current.find('.zoomImg').addClass('animate__animated animate__fadeOutLeft animate__faster');

    setTimeout(() => {
        $next.find('.zoomImg').addClass('animate__animated animate__fadeInRight animate__faster');
    }, 50);
});


$('.slider-for').slick({
    slidesToShow: 1,
    slidesToScroll: 1,
    arrows: false,
    fade: true,
    asNavFor: '.slider-nav'
});

$('.slider-nav').slick({
    slidesToShow: 4,
    slidesToScroll: 1,
    asNavFor: '.slider-for',
    focusOnSelect: true
});

// Zoom product
$('.zoomImg').ezPlus({
    zoomType: 'lens',
    containLensZoom: true,
    cursor: 'crosshair',
    zoomWindowFadeIn: 500,
    zoomWindowFadeOut: 500,
    lensFadeIn: 500,
    lensFadeOut: 500,
    scrollZoom: true
});

// sticky right menu
//var stickyEl = new Sticksy('.stickyRightMenu', {
//    topSpacing: 30
//})
//stickyEl.onStateChanged = function (state) {
//    if (state === 'fixed') stickyEl.nodeRef.classList.add('widget--sticky')
//    else stickyEl.nodeRef.classList.remove('widget--sticky')
//}



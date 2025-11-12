// carousel animation
$('.ol2').owlCarousel({
    loop: true,
    autoplay: true,
    margin: 10,
    nav: true,
    responsive: {
        0: {
            items: 1
        },
        600: {
            items: 1
        },
        1000: {
            items: 1
        }
    }
});

// nav2 dropdown item
$(document).on("click", ".searchMenuItem", function () {
    var item = $(this).text();
    $(".dropdownSearch").html(item + "&nbsp;<i class='fa-solid fa-chevron-down'></i>");
});

// nav3 show more button 
$(document).on("click", ".showMoreBtn", function () {
    $(`
    <div class="row moreCategories">
        <div class="col">
            <div class="mt-0">
                <img src="../assets/imgs/theme/icons/category-1.svg" alt="" width="30px">
                <a href="">Milk and Dairies</a>
            </div>
            <div>
                <img src="../assets/imgs/theme/icons/category-3.svg" alt="" width="30px">
                <a href="">Clothing & beauty</a>
            </div>
        </div>
        <div class="col">
            <div class="mt-0">
                <img src="../assets/imgs/theme/icons/category-6.svg" alt="" width="30px">
                <a href="">Wines & Drinks</a>
            </div>
            <div>
                <img src="../assets/imgs/theme/icons/category-7.svg" alt="" width="30px">
                <a href="">Fresh Seafood</a>
            </div>
        </div>
    </div>
    `)
        .hide()
        .insertBefore(".showMoreBtn")
        .slideDown(400);
    $(".plusIcon").html(`<i class="fa-solid fa-minus"></i>`);
    $(".showMoreBtn").attr("class", "text-center minusBtn");
});

$(document).on("click", ".minusBtn", function () {
    $(".moreCategories").last().slideUp(400, function () {
        $(this).remove();
    });
    $(".plusIcon").html(`<i class="fa-solid fa-plus"></i>`);
    $(".minusBtn").attr("class", "text-center showMoreBtn");
});

// featured categories animation
$('.featuredCategories').owlCarousel({
    margin: 10,
    dots: false,
    nav: true,
    responsive: {
        0: {
            items: 4
        },
        600: {
            items: 6
        },
        1000: {
            items: 10
        }
    }
})


//featured imgaes colors
const colors = [
    '#EAFBEF',
    '#FDEEE8',
    'aliceblue',
    '#FFF3FF',
    '#F9FFE7',
    '#FDEEEA',
    '#F4F8DD',
    '#FBF7E3',
    '#E9F5E7'
];

$(".featuredCategories .item").each(function () {
    const color = colors[Math.floor(Math.random() * colors.length)];
    $(this).css('background-color', color);
})

//wowjs declare
new WOW().init();

// best sell product animation
$('.bestSellProducts').owlCarousel({
    margin: 10,
    dots: false,
    nav: true,
    responsive: {
        0: {
            items: 1
        },
        600: {
            items: 2
        },
        1000: {
            items: 4
        }
    }
})

//xu ly dem duoc thoi gian
$(() => {
    var countDownDate = new Date("Dec 31, 2025 23:59:59").getTime();

    var timer = setInterval(() => {
        var now = new Date().getTime();
        var distance = countDownDate - now;

        var days = Math.floor(distance / (1000 * 60 * 60 * 24));
        var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
        var seconds = Math.floor((distance % (1000 * 60)) / 1000);

        $(".days").text(days);
        $(".hours").text(hours);
        $(".minutes").text(minutes);
        $(".seconds").text(seconds);

        if (distance < 0) {
            clearInterval(timer);
            $(".countdownNumber").text("00");
        }
    }, 1000);
})

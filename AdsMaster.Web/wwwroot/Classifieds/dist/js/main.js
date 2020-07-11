
/*
Theme Name:       Classix - Bootstrap 4 Classified Ads Template
Author:           UIdeck
Author URI:       http://uideck.com
Text Domain:      UIdeck
Domain Path:      /languages/

JS INDEX
================================================
1. preloader js
2. scroll to top js
3. slick menu js
4. sticky menu js
5. counter js
6. Testimonial owl carousel
7. New Products owl carouse
================================================*/

(function($) {

  var $main_window = $(window);

  /*====================================
  preloader js
  ======================================*/
  $main_window.on("load", function() {
      $("#loader").fadeOut("slow");
  });

  /*====================================
  scroll to top js
  ======================================*/
  $main_window.on("scroll", function() {
    if ($(this).scrollTop() > 250) {
      $(".back-to-top").fadeIn(200);
    } else {
      $(".back-to-top").fadeOut(200);
    }
  });
  $(".back-to-top").on("click", function() {
    $("html, body").animate(
      {
        scrollTop: 0
      },
      "slow"
    );
    return false;
  });


  /*====================================
  slick menu js
  ======================================*/
  var logo_path=$('.mobile-menu').data('logo');
  $('#main-navbar').slicknav({
      appendTo:'.mobile-menu',
      removeClasses:false,
      label:'',
      closedSymbol:'<i class="fas fa-chevron-right"><i/>',
      openedSymbol:'<i class="fas fa-chevron-down"><i/>',
      brand:'<a href="index.html"><img src="'+logo_path+'" class="img-responsive" alt="logo"></a>'
  });

  /*====================================
  sticky menu js
  ======================================*/
  $main_window.on('scroll', function () {  
    var scroll = $(window).scrollTop();
    if (scroll >= 10) {
        $(".scrolling-navbar").addClass("top-nav-collapse");
    } else {
        $(".scrolling-navbar").removeClass("top-nav-collapse");
    }
  });
  
  //WOW Scroll Spy
  var wow = new WOW({
    //disabled for mobile
    mobile: false
  });
  wow.init();

  /*=======================================
  counter
  ======================================= */
  if ($(".counter").length > 0) {
    $(".counter").counterUp({
      delay: 1,
      time: 800
    });
  }

  /*====================================
  Details  Owl Carousel
  ======================================*/
  var detailsslider = $("#owl-demo");
  detailsslider.owlCarousel({
    autoplay: true,
    nav: false,
    autoplayHoverPause:true,
    smartSpeed: 350,
    dots: true,
    margin:30,
    loop: true,
    responsiveClass: true,
    responsive: {
        0: {
            items: 1,
        },
        575: {
            items: 1,
        },
        991: {
            items: 1,
        }
      }
  });

/*====================================
  New Products Owl Carousel
  ======================================*/
  var newproducts = $("#new-products");
  newproducts.owlCarousel({
    autoplay: true,
    nav: true,
    autoplayHoverPause:true,
    smartSpeed: 350,
    dots: false,
    margin:5,
    loop: true,
    navText: [
      '<i class="fas fa-angle-left"></i>',
      '<i class="fas fa-angle-right"></i>'
    ],
    responsiveClass: true,
    responsive: {
        0: {
            items: 1,
        },
        575: {
            items: 3,
        },
        991: {
            items: 5,
        }
      }
  });

  $('.list,switchToGrid').click(function(e) {
    e.preventDefault();
    $('.grid').removeClass("active");
    $('.list').addClass("active");
    $('.item-list').addClass("make-list");
    $('.item-list').removeClass("make-grid");
    $('.item-list').removeClass("make-compact");
    $('.item-list .add-desc-box').removeClass("col-sm-9");
    $('.item-list .add-desc-box').addClass("col-sm-7");
  });
  $('.grid').click(function(e) {
    e.preventDefault();
    $('.list').removeClass("active");
    $(this).addClass("active");
    $('.item-list').addClass("make-grid");
    $('.item-list').removeClass("make-list");
    $('.item-list').removeClass("make-compact");
    $('.item-list .add-desc-box').removeClass("col-sm-9");
    $('.item-list .add-desc-box').addClass("col-sm-7");
  });

})(jQuery);

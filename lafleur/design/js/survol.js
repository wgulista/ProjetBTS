/*jQuery(function($){
	var current = null;
	/*var top = parseInt($(".produit a span.title").css("top"));
	var left = parseInt($(".produit a span.title").css("left"));

	$(".produit a").mouseover(function(){
		$(this).find('span.bg').hide().stop().fadeTo(500,0.7);
		/*$(this).find('span.title').css({
			opacity :0,
			top : top-50
		}).animate({
			opacity : 1,
			top : top
		});
		current = $(this);
	});
	$('.produit a').mouseleave(function(){
       current.find('span.bg').stop().fadeOut();
       current = null;
	});
});
jQuery(function ($) {
    $('.produit li').each(function () {
        var photo = $(this);
        var bg = photo.find('a span.bg');
        var bgDiv = photo.find('.infoProd div.bgDiv');
        var top = parseInt($("a span.title").css("top"));
		var left = parseInt($("a span.title").css("left"));
        // Le reste des variables déclarées t, l ...
        photo.hover(function () {
            // Ici on écrit les instructions à faire pour le mouseover
            bg.fadeTo(100, 0.7);
            bgDiv.fadeTo(100, 0.7);
            // Le reste de l'animation pour le titre et la description sans utiliser stop()
            photo.find('span.title').show().animate({
				top : top + 78,
				left : left + 90,
				opacity : 1
			});
        }, function () {
            // Ici on écrit les instructions à faire pour le mouseout
            bg.stop().fadeOut(100);
            bgDiv.stop().fadeOut(100);
            // Le reste de l'animation pour le titre et la description comme s'est écrit dans le tuto
        	photo.find('span.title').show().animate({
				top : top - 78,
				left : left - 90,
				opacity : 0
			});
        });
    });
});*/
jQuery(function($){
	function _getDir($el,event){
		var w 	= $el.width(),
			h	= $el.height(),
			cx  = $el.offset().left + w/2,
			cy  = $el.offset().top  + h/2,
			x	= (event.pageX - cx) * (w>h?(h/w) : 1),
			y   = -(event.pageY - cy) * (h>w?(w/h) : 1),
			direction = Math.round( ( (Math.atan2(x,y) + Math.PI) / (Math.PI/2)) + 2 ) % 4;
		var directions = {
			0 : {left:0, top:-h},
			1 : {left:w, top:0},
			2 : {left:0, top:h},
			3 : {left:-w,top:0}
		}
		return directions[direction]; 
	}

	$('.thumb').on('mouseenter',function(event){
		$(this).find('.alt').stop().css(_getDir($(this),event)).animate({top:0, left:0}, 300);
	});

	$('.thumb').on('mouseleave',function(event){
		$(this).find('.alt').stop().animate(_getDir($(this),event), 300);
	});
});
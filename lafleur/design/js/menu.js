	$(function(){
	    $('.nav1').flashyNav({
	        rolloverColor: '#31c718',   //the default color of the rollover element
	        rolloverDuration: 150, //the default duration for the rollover
	        easingMethod: 'easeInOutQuad'  //easing method used for animation
	    });
	});
	
	jQuery(function() {
	  jQuery('.nav1 li').each(function() {
		var href = jQuery(this).find('a').attr('href');
		if (href === window.location.href) {
		  jQuery(this).addClass('background');
		}
	  });
	});
/**
* plugin: jquery.flashyNav.js
* author: kt.cheung @ Brandammo
* website: www.brandammo.co.uk
* version: 1.0
* date: 17th apr 2011
* description: flashy navigation menu with easing and hoverIntent

Copyright (c) 2011 KT Cheung

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

**/

(function($){

  $.fn.flashyNav = function(options) {  
  
	//set up default options 
	var defaults = { 
		rolloverColor: 'red',	//the default color of the rollover element
		rolloverDuration: 800,	//the default duration for the rollover
		easingMethod: 'easeInOutQuint'	//easing method used for animation
	}; 
  	
	var opts = $.extend({}, defaults, options); 	

    return this.each(function() {  
		var $this = $(this);
		navWidth = $(this).width();
		
		$this.find('li').each(function(){}).append('<div class="flashyNavRollover"></div>');
	  	$this.find('.flashyNavRollover').css('display','block').css('position','absolute').css('width','100%').css('height','100%').css('top','0px').css('left', navWidth).css('background', opts.rolloverColor);
			  
		$this.find('li').hoverIntent(navRollOver, navRollOut);
    });
		
	function navRollOver(){
		$(this).find('.flashyNavRollover').animate({left: '0px'}, {duration:opts.rolloverDuration, easing: opts.easingMethod});
	}
	
	function navRollOut(){
		$(this).find('.flashyNavRollover').animate({left: navWidth}, {duration:opts.rolloverDuration, easing: opts.easingMethod});
	}
	
  };
})(jQuery);

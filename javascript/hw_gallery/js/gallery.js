$(function(){
    
    // image selector hover effect
    
    var hoverEffectDuration = 500;
    
    $('#image-selector img').hover(function() {     
        
        $(this).stop().animate({'opacity': '1'}, hoverEffectDuration);
        }, function() {
            $(this).stop().animate({'opacity': '.4'}, hoverEffectDuration);
            
    });
    
    // gallery slider script, manipulates top posision 
    // with easing effect from jQuery ui
    $('#image-selector img').on('click', function() {
       
        var bigImgClass = $(this).attr('class');
        var position = $('#slider .' + bigImgClass).position();
        
        $('#slider').animate({'top': -position.top}, 1000, "easeOutBack");
        
    });
    
}());


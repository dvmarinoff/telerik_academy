$(function() {
    $('.slider #1').show('fade',1000);
    $('.slider #1').delay(3000).hide('slide', {direction: 'left'}, 1000);
    
    var slideCounter = $('.slider-image').size();
    console.log(slideCounter);
    var count = 2;
    
    setInterval(function() {
        
        $('.slider #' + count).show('slide', {direction: 'right'}, 1000);
        $('.slider #' + count).delay(3000).hide('slide', {direction: 'left'}, 1000);
        
        if(count == slideCounter) {
            count = 1;
        } else {
            count++;
        }
        
    }, 5000);
    
}());
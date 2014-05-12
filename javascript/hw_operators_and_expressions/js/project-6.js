(function () {
    'use strict';
    
    var checkPoint = function() {
        var x, y, radius, result;
        
        // get input
        x = document.getElementById('pointXInput').value;
        y = document.getElementById('pointYInput').value;
        radius = document.getElementById('radius').value;
        
        // using the pytagorean theorem
        if((x * x + y * y) < (radius * radius)) {
            result = 'The point (' + x + ',' + y +') is in the circle (K, ' + radius + ')';
        } else {
            result = 'The point (' + x + ',' + y +') is not in the circle (K, ' + radius + ')';
        }
      
        // display result
        document.getElementById('result-6').innerHTML = result;
        
    }
    
    document.getElementById('btn-6').addEventListener('click', checkPoint);

} ());
(function() {
    'use strict';

    var checkPoint = function() {
        var x, y, adjustedX, adjustedY, radius, height, width, distance, inCircle, inRect, result;
        
        // get input
        x = document.getElementById('pointXCoord').value;
        y = document.getElementById('pointYCoord').value;
        
        x = parseInt(x);
        y = parseInt(y);
        
        // inCircle
        adjustedX = x - 1;
        adjustedY = y - 1;
        
        distance =Math.sqrt((adjustedX * adjustedY) + (adjustedX * adjustedY));
        
        inCircle = distance <= 3;
        
        // inRect
        inRect = (x >= -1 && x <= -1 + 6) && (y <= 1 && y >= 1 - 2);
        
        // result value conditions
        if(inCircle && inRect) {
            result = 'Point is in the circle and in the rectangle';
        }
        else if(inCircle && !inRect) {
            result = 'Point is in the circle, but not in the rectangle';
        }
        else if(inRect && !inCircle) {
            result = 'Point is in the rectangle, but not in the circle';
        }
        else {
            result = 'Point is not in the circle, neither in the rectangle';
        }
        
        // display result
        document.getElementById('result-9').innerHTML = result;
    };
    
    document.getElementById('btn-9').addEventListener('click', checkPoint);

} ());
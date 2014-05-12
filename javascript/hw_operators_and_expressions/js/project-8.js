(function () {
    'use strict';

    var calculateArea = function() {
        
        var sideA, sideB, height, result;
        
        // get input
        sideA = document.getElementById('sideA').value;
        sideB = document.getElementById('sideB').value;
        sideA = document.getElementById('sideA').value;
        heightTrapezoid = document.getElementById('heightTrapezoid').value;
        
        // parse input
        sideA = parseInt(sideA);
        sideB = parseInt(sideB);
        heightTrapezoid = parseInt(heightTrapezoid);
        
        // calculate area
        result = ((sideA + sideB) / 2) * heightTrapezoid;
        
        // display result
        document.getElementById('result-8').innerHTML = 'Trapezoid area = ' + result;
        
    }
    
    // event handler
    document.getElementById('btn-8').addEventListener('click', calculateArea);

} ());
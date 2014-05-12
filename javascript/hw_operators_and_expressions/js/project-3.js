(function () {
    'use strict';

    var calculateArea = function() {
        // get input
        var width, height, result;
        
        width = document.getElementById('width').value;
        height = document.getElementById('height').value;
        
        result = width * height;       
        
        // display result
        document.getElementById('result-3').innerHTML = result;
    };
    
    // attach event listener
    document.getElementById('btn-3').addEventListener('click', calculateArea);

} ());
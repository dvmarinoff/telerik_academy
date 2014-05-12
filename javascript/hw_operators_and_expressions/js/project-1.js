(function() {
    'use strict';
    
    var  checkOddOrEven = function() {
        var number, result;

        // get input
        number = document.getElementById('oddOrEvenInput').value;
        result = '';

        // normalize input
        if(typeof number === isNaN) {
           //throw 'Input must be an integer number!';
        }
        number = Math.floor(number);

        // check if odd or even
        if(number % 2 === 0) {
            result = 'The number ' + number + ' is ' + 'even';    
        } else {
            result = 'The number ' + number + ' is ' + 'odd';
        }

        // display result
        document.getElementById('result-1').innerHTML = result;

    };
    
    document.getElementById('btn-1').addEventListener("click", checkOddOrEven);
    
} ());
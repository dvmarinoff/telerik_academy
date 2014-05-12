(function () {
    'use strict';

    var checkPrime = function() {
        var number, result, maxDivide;
        
        number = document.getElementById('primeInput').value;
        
        number = parseInt(number);
        
        maxDivide =Math.sqrt(number);
        
        for (var i = 2; i <= maxDivide; i++) {
            if (number % i ===0) {
                result = 'The number ' + number + ' is NOT a prime number';
                break;
            } else {
                result = 'The number ' + number + ' is a prime number';
            }
        }
        
        document.getElementById('result-7').innerHTML = result;
    };
    
    document.getElementById('btn-7').addEventListener('click', checkPrime);

} ());
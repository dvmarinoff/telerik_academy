(function () {
    'use strict';

    var checkIfSeven = function() {
        var number, result;
        
        number = document.getElementById('sevenInput').value;
        
        if(number[number.length - 3] === '7') {
            result = 'The third digit of ' + number + ' is 7';
        } else {
            result = 'The third digit of ' + number + ' is not 7';
        }
        
        document.getElementById('result-4').innerHTML = result;
    }
    
    document.getElementById('btn-4').addEventListener('click', checkIfSeven);

} ());
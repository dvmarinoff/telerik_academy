(function() {
    'use strict';
    
    var printResult; 
    
    // reverses digit with help array
    function reversDigits(number) {
        var i, array;
        array = Array(number.length);
        for (var i = number.length - 1; i >= 0; i--) {
            array[number.length - 1 - i] = number[i];
        }

        return Number(array.join(''));
    }

    // gets input, calls reverse function and prints in the result section
    printResult = function() {
        var number, result;

        number = document.getElementById('input-2-1').value;

        result = reversDigits(number);

        document.getElementById('result-2').innerHTML = result;
    };

    // Event listener
    document.getElementById('btn-2-submit').addEventListener('click', printResult);

} ());
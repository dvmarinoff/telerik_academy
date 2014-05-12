(function() {
    'use strict';

    var checkIfDevisible = function () {
        var number, result;

        // get input
        number = document.getElementById('devisibleInput').value;
        result = '';

        // normalize input
        if(typeof number === isNaN) {
            throw 'Input must be an integer number!';
        }
        number = Math.floor(number);

        // check if odd or even
        if(number % 35 === 0) {
            result = 'The number ' + number + ' is ' + 'devisible by both';    
        } else {
            result = 'The number ' + number + ' is ' + 'is not devisible by both';
        }

        // display result
        document.getElementById('result-2').innerHTML = result;

    };

    document.getElementById('btn-2').addEventListener("click", checkIfDevisible);

} ());
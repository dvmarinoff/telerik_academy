(function() {
    'use strict';

    var printResult; 

    function countDivs() {
        var divElement;
        
        divElement = document.getElementsByTagName('div');
        return divElement.length;
    }

    // gets input, calls count function and prints in the result section
    printResult = function() {
        var result;

        result = countDivs();

        document.getElementById('result-4').innerHTML = result;
    };

    // Event listener
    document.getElementById('btn-4-submit').addEventListener('click', printResult);

} ());
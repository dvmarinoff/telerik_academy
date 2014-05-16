(function() {
    'use strict';

   var printResult, numbers, pushNextNumber; 
    
   numbers = [];

    // gets next number from input
   pushNextNumber = function() {
        var nextNumber;

        nextNumber = document.getElementById('input-5-2').value;
        nextNumber = parseInt(nextNumber);

        numbers.push(nextNumber);

        document.getElementById('result-5-2').innerHTML += nextNumber + ' ';
    };

    function countNumber(arr, num) {
        var i, res;
        res = 0;
        
        for (i = 0; i < arr.length; i++) {
            if (arr[i] === num) {
                res++;
            }
        }
        
        return res; 
    }

    // gets input, calls count function and prints in the result section
    printResult = function() {
        var number, result;

        number = document.getElementById('input-5-1').value;
        number = parseInt(number);
        
        result = countNumber(numbers, number);

        document.getElementById('result-5').innerHTML = result;
    };

    // Event listener
    document.getElementById('btn-5-add').addEventListener('click', pushNextNumber);
    document.getElementById('btn-5-submit').addEventListener('click', printResult);

} ());
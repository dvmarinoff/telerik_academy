(function() {
    'use strict';
    var printResult;
    
    // uses module to get the last digit and transletes it 
    function convertLastDigit(number) {
        switch (number % 10) {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "";
        }
    }
    
    // gets input, calls covert function and prints in the result section
    printResult = function() {
        var number, result;
        
        number = document.getElementById('input-1-1').value;
        number = parseInt(number);
        
        result = convertLastDigit(number);
        
        document.getElementById('result-1').innerHTML = result;
    };
    
    // Event listener
    document.getElementById('btn-1-submit').addEventListener('click', printResult);
    
} ());
(function() {
    'use strict';
    
    var printResult;
    
    function biggerThanNeighbours(arr, position) {
        //convert position to int number
        position = position | 0;
        if (position >= arr.length) {
            return false;
        }

        if (arr[position] == 0 || arr[position] == arr.length - 1) {
            return false;
        }

        if (arr[position] > arr[position-1] && arr[position] > arr[position+1]) {
            return true;
        } else {
            return false;
        }
    }
    
    // gets input, calls biggerThanNeighbours function and prints in the result section
    printResult = function() {
        var pos, array, result;
        array = [1, 2, 3, 4, 1, 2, 4, 2, 3, 1, 4, 2, 3, 2];
        
        pos = document.getElementById('input-6-1').value;
        pos = parseInt(pos, 10);
        
        result = biggerThanNeighbours(array, pos);

        document.getElementById('result-6').innerHTML = result;
    };

    // Event listener
    document.getElementById('btn-6-submit').addEventListener('click', printResult);

} ());
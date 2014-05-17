(function () {
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

    // calls biggerThanNeighbours function and prints in the result section
    printResult = function() {
        var pos, array, j, result;
        array = [1, 2, 3, 4, 1, 2, 4, 2, 3, 1, 4, 2, 3, 2];
        result = -1;
        
        for (j = 1; j < array.length-1; j++) {
            
            if (biggerThanNeighbours(array,j)) {
                result = j;
                break;
            }
        }

        document.getElementById('result-7').innerHTML = result;
    };

    // Event listener
    document.getElementById('btn-7-submit').addEventListener('click', printResult);

}());
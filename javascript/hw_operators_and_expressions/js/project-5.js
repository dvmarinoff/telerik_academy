(function () {
    'use strict';

    var checkThirdBit = function() {
        var position, bit, result, number;
        
        // get input
        number = document.getElementById('bitInput').value;
        
        number = parseInt(number);
        
        // mask
        position = 3;
        result = number & (1 << position);
        bit = result >> position;
        
        // display bit
        document.getElementById('result-5').innerHTML = bit;
    };
    
    document.getElementById('btn-5').addEventListener('click', checkThirdBit);

} ());
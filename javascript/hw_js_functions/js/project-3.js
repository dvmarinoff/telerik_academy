(function() {
    'use strict';

    var printResult; 

    function countWord(word, text, sensitive) {
        var caseSens, newString, words, occurrences, i, j, lower;
        
        caseSens = sensitive || false;
        newString = text.replace(/\W+/g, ' ');
        words = newString.split(' ');
        occurrences = 0;

        if (caseSens) {
            for (i = 0; i < words.length; i++) {
                if (words[i] === word) {
                    occurrences++;
                }
            }
        }
        else {
            lower = word.toLowerCase();

            for (j = 0; j < words.length; j++) {
                if (words[j].toLowerCase() === lower) {
                    occurrences++;
                }
            }
        }

        return occurrences;
    }

    // gets input, calls count function and prints in the result section
    printResult = function() {
        var word, text, result;

        text = document.getElementById('input-3-1').value;
        
        word = document.getElementById('input-3-2').value;

        result = countWord(word, text, document.getElementById('sensitive').checked);

        document.getElementById('result-3').innerHTML = result;
    };

    // Event listener
    document.getElementById('btn-3-submit').addEventListener('click', printResult);

} ());
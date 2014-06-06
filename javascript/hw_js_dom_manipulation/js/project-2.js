//Create a function that gets the value of <input
//type="text"> and prints its value to the console

'use strict';

(function () {
	var handelInput, input;

	handelInput = function () {

		input = document.getElementById('input-2').value;

		// prints in the console
		console.log(input);

		// print in the html
		document.getElementById('result-2').innerHTML = input;

	};

	document.getElementById('btn-2-submit').addEventListener('click', handelInput);
}());
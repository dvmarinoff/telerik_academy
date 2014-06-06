//Crеate a function that gets the value of <input
//type="color"> and sets the background of the body
//to this value

'use strict';

(function () {
	var handelInput, input;

	handelInput = function () {

		input = document.getElementById('input-3').value;

		// prints in the console
		console.log(input);

		// print in the html
		document.getElementById('result-3').style.background = input;

	};

	document.getElementById('btn-3-submit').addEventListener('click', handelInput);
}());
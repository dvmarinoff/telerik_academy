//Write a script that selects all the div nodes that are
//directly inside other div elements
//- Create a function using querySelectorAll()
//- Create a function using getElementsByTagName()

'use strict';

(function () {
	var getDivs, wrapper, allDivs;

	getDivs = function () {
		wrapper = document.getElementById('result-1');
		allDivs = wrapper.getElementsByTagName('div');

		for (var i = 0, len = allDivs.length; i < len; i += 1) {

			if (allDivs[i].parentNode.nodeName == 'DIV') {

				allDivs[i].style.background = '#449';
				console.log(allDivs[i]);
			}
		}
	}

	document.getElementById('btn-1-submit').addEventListener('click', getDivs);
}());
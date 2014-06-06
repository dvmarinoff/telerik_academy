//*Write a script that shims querySelector and
//querySelectorAll in older browsers

'use strict';
(function () {
	if (!document.querySelectorAll) {
		document.querySelectorAll = function (selector) {
			if (selector[0] == '#') {
				return document.getElementById(selector.substr(1));
			} else if (selector[0] == '.') {
				return document.getElementsByClassName(selector.substr(1));
			} else {
				return document.getElementsByName(selector.substr(1));
			}
		}
	}

	if (!document.querySelector) {
		document.querySelector = function (selector) {
			if (selector[0] == '#') {
				return document.getElementById(selector.substr(1));
			} else if (selector[0] == ".") {
				return document.getElementsByClassName(selector.substr(1))[0];
			} else {
				return document.getElementsByName(selector.substr(1))[0];
			}
		}
	}
}());
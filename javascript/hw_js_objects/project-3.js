//3. Write a function that makes a deep copy of an object
//	-The function should work for both primitive and reference types

'use strict';

(function () {
	function getDeepCopy(obj) {
		var prop,
			copyObj = {};

		if (typeof (obj) != 'object')
			return obj;
		else {
			for (prop in obj) {
				copyObj[prop] = getDeepCopy(obj[prop]);
			}
			return copyObj;
		}
	}
}());
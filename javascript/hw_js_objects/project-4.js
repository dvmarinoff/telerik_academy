//4. Write a function that checks if a given object contains a given property
//	var obj = ...;
//	var hasProp = hasProperty(obj, 'length');

'use strict';
(function () {

	function checkProperty(obj, property) {
		var prop,
			result = false;

		for (prop in obj) {
			if (obj[prop] === property) {
				result = true;
			}
		}

		return result;
	}

	//Test:
	var obj1 = {
		id: 1,
		date: '22/04/2014',
		sayHello: function () {
			return 'Hello JS!';
		}
	};

	console.log(checkProperty(obj1, obj1.id));

}());
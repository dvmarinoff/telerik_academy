//6. Write a function that groups an array of persons by
// age, first or last name. The function must return an
// associative array, with keys - the groups, and values -
// arrays with persons in this groups
//	- Use function overloading (i.e. just one function)
//		var persons = {...};
//		var groupedByFname = group(persons, 'firstname');
//		var groupedByAge= group(persons, 'age');

'use strict';

(function () {

	function groupPersons(personsArray, key) {
		var i = 0,
			prop = '',
			length = personsArray.length,
			result = {};

		for (prop in personsArray[0]) {
			if (prop === key) {
				for (i = 0; i < length; i++) {
					if (!result[personsArray[i][key]]) {
						result[personsArray[i][key]] = [];
					}
					result[personsArray[i][key]].push(personsArray[i]);
				}
			}
		}
		return result;
	}

	//Test:
	var personsArray = [{
		firstname: 'John',
		lastname: 'Osmani',
		age: '28'
	}, {
		firstname: 'Jim',
		lastname: 'Irish',
		age: '31'
	}, {
		firstname: 'James',
		lastname: 'Crockford',
		age: '50'
	}, {
		firstname: 'Jane',
		lastname: 'Fabbro',
		age: '30'
	}];

	console.log(groupPersons(personsArray, 'age'));
}());
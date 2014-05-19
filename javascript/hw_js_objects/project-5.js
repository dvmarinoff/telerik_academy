//5. Write a function that finds the youngest person in a 
// given array of persons and prints his/hers full name
//	- Each person have properties firstname, lastname and age, as shown:
//		var persons = [
//			{ firstname : 'Gosho', lastname: 'Petrov', age: 32 },
//			{ firstname : 'Bay', lastname: 'Ivan', age: 81},... ];

'use strict';

(function () {

	function findYoungest(persons) {
		var i = 0,
			current = 0,
			name = '',
			length = persons.length;

		for (i = 0; i < length; i++) {

			if (persons[i].age > current) {
				current = persons.age;
				name = persons[i].firstname + ' ' + persons[i].lastname;
			}
		};

		return name;
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

	console.log(findYoungest(personsArray));

}());
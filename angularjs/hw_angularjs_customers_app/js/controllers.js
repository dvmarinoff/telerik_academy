devApp.controller('customersCtrl', ['$scope',
	function ($scope) {
		$scope.customers =
			[{
				"firstname": "James",
				"lastname": "Osmani",
				"city": "New York",
				"joined": "Mar 25, 2001",
				"orders": ""
			}, {
				"firstname": "John",
				"lastname": "Crockford",
				"city": "LA",
				"joined": "May 10, 1995",
				"orders": ""
			}, {
				"firstname": "Paul",
				"lastname": "Irish",
				"city": "New York",
				"joined": "Mar 25, 2001",
				"orders": ""
			}, {
				"firstname": "Jane",
				"lastname": "Fabro",
				"city": "Seatle",
				"joined": "Oct 28, 2004",
				"orders": ""
			},

		]; // array users end
	} // function end
]);
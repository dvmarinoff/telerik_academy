devApp.controller('customersCtrl', ['$scope',
	function ($scope) {
		$scope.customers =
			[{
				"firstname": "James",
				"lastname": "Osmani",
				"city": "New York",
				"joined": "Mar 25, 2001",
				"orders": "",
				"orderTotal": 100.10
			}, {
				"firstname": "John",
				"lastname": "Crockford",
				"city": "LA",
				"joined": "May 10, 1995",
				"orders": "",
				"orderTotal": 120.30
			}, {
				"firstname": "Paul",
				"lastname": "Irish",
				"city": "New York",
				"joined": "Mar 25, 2001",
				"orders": "",
				"orderTotal": 190.40
			}, {
				"firstname": "Jane",
				"lastname": "Fabro",
				"city": "Seattle",
				"joined": "Oct 28, 2004",
				"orders": "",
				"orderTotal": 180.80
			},

		]; // array users end
	} // function end
]);

devApp.controller('OrdersCtrl', ['$scope',
	function ($scope) {

	}
]);
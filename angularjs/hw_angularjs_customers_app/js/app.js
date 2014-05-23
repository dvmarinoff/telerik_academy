var devApp = angular.module('devApp', ['ngRoute']);

devApp.config(['$routeProvider',
	function ($routeProvider) {
		$routeProvider.when('/customers', {
			controller: 'customersCtrl',
			templeteUrl: './views/customers.html'
		})
			.when('/orders', {
				controller: 'ordersCtrl',
				templeteUrl: 'views/orders.html'
			});
		$routeProvider.otherwise({
			redirectTo: '/customers'
		});
	}
]);
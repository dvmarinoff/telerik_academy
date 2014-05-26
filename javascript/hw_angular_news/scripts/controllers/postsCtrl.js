'use strict';

app.controller('PostsCtrl', function ($scope, PostFactory) {
	$scope.post = {
		url: 'http://',
		title: ''
	};
	$scope.posts = [];
	$scope.submitPost = function () {
		// gets the input
		//$scope.posts.push($scope.post);
		PostFactory.save($scope.post, function (ref) {
			$scope.posts[ref.name] = $scope.post;
			// resets the form
			$scope.post = {
				url: 'http://',
				title: ''
			};
		});
	};
	$scope.deletePost = function (index) {
		$scope.posts.splice(index, 1);
	};
});
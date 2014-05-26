'use strict';

app.factory('PostFactory', function ($resource)) {
	return $resource(' https://popping-fire-6330.firebaseio.com/posts/:id.json');
}
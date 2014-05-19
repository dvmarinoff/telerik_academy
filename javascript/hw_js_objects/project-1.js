//1.Write functions for working with shapes in standard Planar coordinate system
//	- Points are represented by coordinates P(X, Y)
//  - Lines are represented by two points, marking their beginning and ending
//  	L(P 1 (X 1 ,Y 1 ), P 2 (X 2 ,Y 2 ))
//  - Calculate the distance between two points
//  - Check if three segment lines can form a triangle
'use strict';

(function () {

	// point 'class'
	function Point(x, y) {
		this.x = x;
		this.y = y;
	}

	// line 'class'
	function Line(point1, point2) {
		this.point1 = point1;
		this.point2 = point2;
		this.length = getDistance(this.point1, this.point2);
	}

	// a^2 + b^2 = c^2 used to calculate distance, returns distance
	function getDistance(point1, point2) {
		var distance = Math.sqrt((point1.x - point2.x) * (point1.x - point2.x) + (point1.y - point2.y) * (point1.y - point2.y));
		return distance;
	}

	// any two line lengths sum must be bigger than the third line length, returns bool
	function formTriangle(line1, line2, line3) {
		var canFormTriangle = false,
			line1Length = line1.length,
			line2Length = line2.length,
			line3Length = line3.length;

		canFormTriangle = (line1Length + line2Length > line3Length) &&
			(line1Length + line3Length > line2Length) && (line2Length + line3Length > line1Length);

		return canFormTriangle;
	}

	// Test:
	var p1 = new Point(2, 2);
	var p2 = new Point(2, 4);
	var p3 = new Point(6, 4);
	var p4 = new Point(2, 8);

	var line1 = new Line(p1, p2);
	var line2 = new Line(p2, p3);
	var line3 = new Line(p1, p3); // with p1, p4 will return false

	console.log('Distance p1, p2: ' + getDistance(p1, p2));
	console.log('Line1, line2, line3, can form triangle: ' + formTriangle(line1, line2, line3));
}());
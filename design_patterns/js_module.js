// Item class
function Item(name, price, description) {
	this.name = name;
	this.price = price;
	this.description = description;
}

Item.prototype = {
	updatePrice: function (newPrice) {
		this.price = newPrice;
	},
	updateDescription: function (newDescription) {
		this.description = newDescription;
	},
	toString: function () {
		var result = 'Name: ' + this.name + ', Price: ' + this.price + ', Description: ' + this.description;
		return result;
	}
};
Item.prototype.constructor = Item;

// module pattern, basket is private and public modifier methods
var basket = (function () {
	var basket = [];

	return {
		addItem: function (item) {
			basket.push(item);
		},
		getItem: function (index) {
			return basket[index];
		},
		deleteItem: function (index) {
			basket.splice(index, 1);
		},
		toString: function () {
			var length = basket.length,
				i = 0,
				result = [];

			for (i = 0; i < length; i++) {
				result.push(basket[i].name);
			};

			return result.join(', ');
		}
	}
}());

// test
var bread = new Item('Bread', 1, 'Regular white bread.');
basket.addItem(bread);
var milk = new Item('Milk', 2, 'Semi-skimmed, 1.5% fat');
basket.addItem(milk);

console.log(basket.getItem(0));
console.log(basket.toString());
console.log(milk.toString());
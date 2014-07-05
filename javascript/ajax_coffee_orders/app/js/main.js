$(function () {
	var $orders = $('#orders');
	var $name = $('#name');
	var $drink = $('#drink');
	
	var orderTemplete = "<li>name: {{name}}, drink: {{drink}}</li>";
	
	function addOrder(order) {
		$orders.append();
	}
	
	$.ajax({
		type: 'GET',
		url: '/api/orders/',
		success: function(orders) {
			$.each(orders, function(i, order) {
				addOrder(order);			
			});
		},
		error: function() {
			console.log('error getting orders');
		}
	});
	
	$('#add-order').on('click', function(){
		
		var order = {
			name: $name.val(),
			drink: $drink.val()
		};
		
		$.ajax({
			type: 'POST',
			url: '/api/orders',
			data: order,
			success: function(newOrder){
				addOrder(order);
			},
			error: function() {
				console.log('error saving order');
			}
		});
	});
	
	// listens on orders for click event on .remove
	$orders.delegate('.remove', 'click', function() {
		
		var $li = $(this).closest('li');
		//var self = this;
		
		$.ajax({
			type: 'DELETE',
			url: '/api/orders/' + $(this).attr('data-id'),
			success: function() {
				//$(self);
				$li.fadeOut(300, functon() {
					$(this).remove();
				}
			}
		});
	});
	
	
	
}())
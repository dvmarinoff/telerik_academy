function Point(x, y) {
	return {
		xCoord: x,
		yCoord: y
	}
}

    function draw() {
        var canvas = document.getElementById("canvas");
        var ctx = canvas.getContext("2d");
        
        ctx.arc(200, 200, 1, 0, Math.PI*2, true);
        ctx.stroke();
        
        ctx.fillStyle = "rgba(0, 0, 200, 0.5)";
        ctx.fillRect (0, 0,500, 500);    
        
        ctx.beginPath();
        ctx.arc(200, 200, 50, 0, Math.PI*2, true);

        ctx.stroke();
     
    }



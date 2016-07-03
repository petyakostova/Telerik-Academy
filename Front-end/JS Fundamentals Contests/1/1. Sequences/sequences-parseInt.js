function solve(args) {
	var n = parseInt(args[0]), // n = +args[0],
		count = 1,
		last = parseInt(args[1]);

	for (var i = 2; i <= n; i++) {
		var current = parseInt(args[i]);

		if (last > current) {
			count++;
		}
		
		last = current;
	}

	console.log(count);
}

solve(['7', '1', '2', '-3', '4', '4', '0', '1']);
solve(['6', '1', '3', '-5', '8', '7', '-6']);
solve(['9', '1', '8', '8', '7', '6', '5', '7', '7', '6']);
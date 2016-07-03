function solve(args) {
	var n = +args[0]; // var n = parseInt(args[0]); // n = args.length
	var numbers = args.slice(1).map(Number);
	// doesn't work with parseInt (instead of Number) because
	// parseInt takes 2 parameters - the value for parsing and the system

	// other way for parsing the input array
	// var numbers = [];
	// for (var p = 1; p <= n; p += 1) {
	// 	numbers[p] = +args[p]; //numbers.push(parseInt(args[p]));
	// }

	var maxSum = numbers[0];
	// other way for maxSum
	//var maxSum = -2000000; // better than using the constant Number.MIN_VALUE

	for (var i = 0; i < n; i += 1) {
		var currentSum = 0;

		for (var j = i; j < n; j += 1) {
			currentSum += numbers[j];

			if (currentSum > maxSum) {
				maxSum = currentSum;
			}
		}
	}

	console.log(maxSum);
	//return maxSum;
}

solve(['8', '1', '6', '-9', '4', '4', '-2', '10', '-1']); // 16
solve(['6', '1', '3', '-5', '8', '7', '-6']); // 15
solve(['9', '-9', '-8', '-8', '-7', '-6', '-5', '-1', '-7', '-6']); // -1

// There is a smarter solution using prefix sums
// Prefix sums will remove the need of the most inner loop
// More information on prefix sums: http://en.wikipedia.org/wiki/Prefix_sum
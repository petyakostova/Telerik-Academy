function solve(args) {
    var i,
        j,
        minNumber,
        input = args[0].split('\n'),
        n = +input[0],             // numbers.length
        numbers = input.slice(1);  // copy the array from the first element => the numbers

    for (i = 0; i < n - 1; i += 1) {
        minNumber = +numbers[i];
        for (j = i + 1; j < n; j += 1) {
            if (+numbers[j] < minNumber) {
                minNumber = numbers[j];
                numbers[j] = numbers[i];
                numbers[i] = minNumber;
            }
        }

    }

    console.log(numbers.join('\n'));
}

solve(['6\n3\n4\n1\n5\n2\n6']);
solve(['10\n36\n10\n1\n34\n28\n38\n31\n27\n30\n20']);
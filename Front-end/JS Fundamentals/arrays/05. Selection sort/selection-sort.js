function solve(args) {
    var j,
        i,
        indexMin,
        swap,
        input = args[0].split('\n'),
        n = +input[0],             // numbers.length
        numbers = input.slice(1);  // copy the array from the first element => the numbers

    // Classical implementation of Selection Sort Algorithm
    for (j = 0; j < n - 1; j += 1) {
        // find the min element in the unsorted a[i..n-1]

        // assume the min is the first element           
        indexMin = j;

        // test against elements after i to find the smallest            
        for (i = j + 1; i < n; i += 1) {
            // if this element is less, then it is the new minimum
            if (numbers[i] < numbers[indexMin]) {
                // found new minimum; remember its index
                indexMin = i;
            }
        }

        // swaping
        if (indexMin !== j) {
            swap = numbers[j];
            numbers[j] = numbers[indexMin];
            numbers[indexMin] = swap;
        }
    }

    console.log(numbers.join('\n'));
}

solve(['6\n3\n4\n1\n5\n2\n6']);
solve(['10\n36\n10\n1\n34\n28\n38\n31\n27\n30\n20']);
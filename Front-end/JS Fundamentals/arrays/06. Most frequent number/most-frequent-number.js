function solve(args) {
    var input = args[0].split('\n'),
        n = +input[0],             // numbers.length
        numbers = input.slice(1),  // copy the array from the first element => the numbers
        count = 1,
        bestRepeatCount = 0,
        bestRepeatNumber = 0,
        i;

    // sorting the numbers in ascending order, so the elements with same value will be placed next to each other
    numbers.sort();

    // find the longest sequence of neighbor equal elements
    for (i = 0; i < n - 1; i += 1) {
        if (+numbers[i] === +numbers[i + 1]) {
            count++;
        }
        else {
            if (count > bestRepeatCount) {
                bestRepeatCount = count;
                bestRepeatNumber = +numbers[i];
            }
            count = 1;
        }
    }

    // in case when the last sequence is the maximal sequence of equal elements
    if (count > bestRepeatCount) {
        bestRepeatCount = count;
        bestRepeatNumber = +numbers[n - 1];
    }

    // output
    console.log(bestRepeatNumber + ' (' + bestRepeatCount + ' times)');
}

solve(['13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3']);
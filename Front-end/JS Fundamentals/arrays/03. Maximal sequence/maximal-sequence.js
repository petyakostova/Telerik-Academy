function solve(args) {
    var arr = args[0].split('\n'),
        n = +arr[0],
        numbers = arr.slice(1),  // copy the array from the first element 
        currentLength = 1,
        maxSeqLength = 0;

    for (i = 0; i < n - 1; i += 1) {
        if (+numbers[i] === +numbers[i + 1]) {
            currentLength += 1;
        } else {
            if (currentLength > maxSeqLength) {
                maxSeqLength = currentLength;
            }
            currentLength = 1;
        }
    }

    // in case when the last sequence is the maximal sequence of equal elements
    if (currentLength > maxSeqLength) {
        maxSeqLength = currentLength;
    }

    console.log(maxSeqLength);
}

solve(['10\n2\n1\n1\n2\n3\n3\n2\n2\n2\n1']);

function solve(args) {
    var input = args[0].split('\n'),
        n = +input[0], // numbers.length
        x = +input[n + 1], // the searched element
        numbers = input.slice(1), // copy the array from the first element
        leftRange = 0,
        rightRange = n - 1,
        middle = 0,
        index = -1;

    numbers.pop(); // remove the last element of the array

    // Binary search works only on sorted arrays
    input.sort(function (a, b) {
        if (+a < +b) {
            return -1;
        } else if (+a > +b) {
            return 1;
        } else {
            return 0;
        }
    });

    // Binary search
    while (leftRange <= rightRange) {
        middle = ((leftRange + rightRange) / 2) | 0; // middle muts be integer number
        if (+numbers[middle] < x) {
            leftRange = middle + 1;
        } else if (+numbers[middle] > x) {
            rightRange = middle - 1;
        } else {
            index = middle;
            break;
        }
    }

    console.log(index);
}

solve(['10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32']);
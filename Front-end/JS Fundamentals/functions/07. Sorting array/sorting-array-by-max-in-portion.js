function solve(args) {
    var i,
        maxElement,
        maxPosition, // the position of the max element
        len = +args[0],
        numbers = args[1].split(' ');

    // The Sorted array in ascending order
    ascendingSorter(numbers, len);
    console.log(numbers.join(' '));

    // The Sorted array in descending order
    // descendingSorter(numbers, len);
    // console.log(numbers.join(' '));

    function maxElementFromGivenIndex(numbersArray, length, startPosition) {
        maxElement = +numbersArray[startPosition];
        maxPosition = startPosition;

        for (i = startPosition + 1; i < length; i += 1) {
            if (maxElement < +numbersArray[i]) {
                maxElement = +numbersArray[i];
                maxPosition = i;
            }
        }

        return maxElement;
    }

    function ascendingSorter(numbersArray, length) {
        max = 0;
        maxPosition = 0;

        for (i = 0; i < length; i += 1) {
            max = maxElementFromGivenIndex(numbersArray, length - i, 0);
            numbersArray[maxPosition] = +numbersArray[length - 1 - i];
            numbersArray[length - 1 - i] = max;
        }

    }

    // function descendingSorter(numbersArray, length) {
    //     max = 0;
    //     maxPosition = 0;

    //     for (i = 0; i < length; i++)
    //     {
    //         max = maxElementFromGivenIndex(numbersArray, i, length);
    //         numbersArray[maxPosition] = numbersArray[i];
    //         numbersArray[i] = max;
    //     }

    // }

}

solve(['6', '3 4 1 5 2 6']);
solve(['10', '36 10 1 34 28 38 31 27 30 20']);
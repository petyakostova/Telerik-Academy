function solve(args) {
    'use strict';
    let heights = args[0].split(' ').map(Number),
        peaks = [0]; // the index

    for (let i = 1; i < heights.length - 1; i += 1) {
        if (isGreaterThanNeighbours(i, heights)) {
            peaks.push(i);
        }
    }

    peaks.push(heights.length - 1);

    let bestCount = -1;
    for (let i = 1; i < peaks.length; i += 1) {
        bestCount = Math.max(bestCount, peaks[i] - peaks[i - 1]);
    }

    //result
    console.log(bestCount);

    function isGreaterThanNeighbours(index, arr) {
        return arr[index] > arr[index - 1] && arr[index] > arr[index + 1];
    }
}

solve(['5 1 7 4 8']);
solve(['5 1 7 6 3 6 4 2 3 8']);
solve(['10 1 2 3 4 5 4 3 2 1 10']);
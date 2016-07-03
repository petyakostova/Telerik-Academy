function solve(args) {
    var n = +args[0],
        k = +args[1],
        arr = args[2].split(' ').map(Number),
        sums = [],
        i;

    for (i = 0; i <= n - k; i += 1) {
        // apply => convenient way to pass an array of data as parameters to a function
        sums.push(Math.min.apply(null, arr.slice(i, i + k)) +
            Math.max.apply(null, arr.slice(i, i + k)));
    }

    console.log(sums.join(','));
}

solve(['4', '2', '1 3 1 8']); // 4,4,9
solve(['5', '3', '7 7 8 9 10']); // 15,16,18
solve(['8', '4', '1 8 8 4 2 9 8 11']); // 9,10,11,11,13
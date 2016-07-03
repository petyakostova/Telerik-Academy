function solve(args) {
    var n = parseInt(args[0]),
        k = parseInt(args[1]),
        sums = [], // array for the sums of the min and max
        seqNumbers = args[2].split(' ').map(Number);  //console.log(seqNumbers);

    for (var i = 0; i < n - k + 1; i += 1) {
        var min = seqNumbers[i];
        var max = seqNumbers[i];

        for (var j = 1; j < k; j += 1) {
            min = Math.min(min, seqNumbers[i + j]);
            max = Math.max(max, seqNumbers[i + j]);
        }

        sums.push(min + max);
    }

    console.log(sums.join(','));
}

solve(['4', '2', '1 3 1 8']); // 4,4,9
solve(['5', '3', '7 7 8 9 10']); // 15,16,18
solve(['8', '4', '1 8 8 4 2 9 8 11']); // 9,10,11,11,13
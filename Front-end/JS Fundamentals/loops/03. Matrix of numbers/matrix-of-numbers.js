function solve(args) {
    var len = +args[0],
        i,
        j;

    for (i = 1; i <= len; i += 1) {
        for (j = i; j < len + i; j += 1) {
            process.stdout.write(j + ' ');
        }
        console.log();
    }
}

solve([2]);
solve([3]);
solve([4]);
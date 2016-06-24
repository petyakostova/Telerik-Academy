function solve(args) {
    var num = +args[0],
        i;

    process.stdout.write('1');

    for (i = 2; i <= num; i += 1) {
        process.stdout.write(' ' + i);
    }

    console.log();
}

solve([5]);
solve([1]);
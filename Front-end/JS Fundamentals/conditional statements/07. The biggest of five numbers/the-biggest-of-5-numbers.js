function solve(args) {
    var biggestNum = +args[0],
        i;

    for (i = 1; i < 5; i++) {
        if (+args[i] > biggestNum) {
            biggestNum = args[i];
        }
    }

    console.log(biggestNum);
}

solve([5, 2, 2, 4, 1]);
solve([-2, -22, 1, 0, 0]);
solve([-2, 4, 3, 2, 0]);
solve([0, -2.5, 0, 5, 5]);
solve([-3, -0.5, -1.1, -2, -0.1]);
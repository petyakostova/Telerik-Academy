function solve(args) {
    var numA = +args[0],
        numB = +args[1],
        numC = +args[2],
        biggestNum = numA;

    if (numB > biggestNum) {
        biggestNum = numB;
    }

    if (numC > biggestNum) {
        biggestNum = numC;
    }

    // other way
    //biggestNum = Math.max(Math.max(numA, numB), numC);

    console.log(biggestNum);
}

solve([5, 2, 2]);
solve([-2, -2, 1]);
solve([-2, 4, 3]);
solve([0, -2.5, 5]);
solve([-0.1, -0.5, -1.1]);
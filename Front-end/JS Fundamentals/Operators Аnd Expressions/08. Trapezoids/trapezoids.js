function solve(args) {
    var result;
    var a = +args[0];
    var b = +args[1];
    var h = +args[2];

    result = (a + b) * h / 2;

    console.log(result.toFixed(7));
}

solve([5, 7, 12]);
solve([2, 1, 33]);
solve([8.5, 4.3, 2.7]);
solve([100, 200, 300]);
solve([0.222, 0.333, 0.555]);
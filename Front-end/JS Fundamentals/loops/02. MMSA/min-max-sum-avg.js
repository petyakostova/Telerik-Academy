function solve(args) {
    var min = +args[0],
        max = +args[0],
        sum = +args[0],
        avg = 0,
        len = args.length;

    for (var i = 1; i < len; i += 1) {
        min = Math.min(min, +args[i]);
        max = Math.max(max, +args[i]);
        sum += +args[i];
    }

    avg = sum / len;
    
    console.log("min=" + min.toFixed(2));
    console.log("max=" + max.toFixed(2));
    console.log("sum=" + sum.toFixed(2));
    console.log("avg=" + avg.toFixed(2));
}

solve([2, 5, 1]);
solve([2, -1, 4]);
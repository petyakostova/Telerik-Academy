function solve(args) {
    var x = +args[0];
    var y = +args[1];

    var distance = Math.sqrt(x * x + y * y);

    // first way
    if (distance <= 2) {
        console.log('yes ' + distance.toFixed(2));
    } else {
        console.log('no ' + distance.toFixed(2));
    }

    // other way
    // var output = distance <= 2 ? 'yes ' + distance.toFixed(2) : 'no ' + distance.toFixed(2);
    // console.log(output);
}

solve([-2, 0]);
solve([-1, 2]);
solve([1.5, -1]);
solve([-1.5, -1.5]);
solve([100, -30]);
solve([0, 0]);
solve([0.2, -0.8]);
solve([0.9, -1.93]);
solve([1, 1.655]);
solve([0, 1]);
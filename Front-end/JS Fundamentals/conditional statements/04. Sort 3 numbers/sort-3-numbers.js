function solve(args) {
    var numA = +args[0],
        numB = +args[1],
        numc = +args[2];

    if (numA > numB && numA > numc) {
        if (numB > numc) {
            console.log(numA + ' ' + numB + ' ' + numc);
        } else {
            console.log(numA + ' ' + numc + ' ' + numB);
        }
    } else if (numB > numA && numB > numc) {
        if (numA > numc) {
            console.log(numB + ' ' + numA + ' ' + numc);
        } else {
            console.log(numB + ' ' + numc + ' ' + numA);
        }
    } else {
        if (numA > numB) {
            console.log(numc + ' ' + numA + ' ' + numB);
        } else {
            console.log(numc + ' ' + numB + ' ' + numA);
        }
    }
}

solve([5, 1, 2]);
solve([-2, -2, 1]);
solve([-2, 4, 3]);
solve([0, -2.5, 5]);
solve([-1.1, -0.5, -0.1]);
solve([10, 20, 30]);
solve([1, 1, 1]);
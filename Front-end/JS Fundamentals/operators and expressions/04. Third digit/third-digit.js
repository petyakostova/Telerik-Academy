function solve(args) {
    var num = +args[0];
    var thirdDigit = (num / 100 | 0) % 10;

    if (thirdDigit === 7) {
        console.log('true');
    } else {
        console.log('false ' + thirdDigit);
    }
}

solve([5]);
solve([701]);
solve([9703]);
solve([877]);
solve([777877]);
solve([9999799]);
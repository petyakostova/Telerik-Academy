function solve(args) {
    var negativeNumbersCount = 0,
        number;

    for (var i = 0; i < 3; i++) {
        number = +args[i];

        if (number === 0) {
            console.log(0);
            return;
        } else {
            if (number < 0) {
                negativeNumbersCount++;
            }
        }
    }

    if (negativeNumbersCount % 2 === 0) {
        //If the negative multiples are even number, the product is positive.
        console.log("+");
    } else {
        //If the count of the negative numbers is odd, the product is negative.
        console.log("-");
    }

}

solve([5, 2, 2]);
solve([-2, -2, 1]);
solve([-2, 4, 3]);
solve([0, -2.5, 4]);
solve([-1, -0.5, -5.1]);
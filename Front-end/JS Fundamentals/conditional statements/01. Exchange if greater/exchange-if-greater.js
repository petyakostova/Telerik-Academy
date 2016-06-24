function solve(args) {
    var numberA = +args[0],
        numberB = +args[1];

    if (numberA > numberB) {
        numberB += numberA;
        numberA = numberB - numberA;
        numberB -= numberA;

        // other way
        // var temp = numberA;
        // numberA = numberB;
        // numberB = temp;
    }

    console.log(numberA + " " + numberB);
}

solve([5, 2]);
solve([3, 4]);
solve([5.5, 4.5]);
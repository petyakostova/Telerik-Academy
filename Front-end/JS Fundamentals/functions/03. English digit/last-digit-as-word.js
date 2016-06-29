function solve(args) {
    var digit = +args % 10,
        digits = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];

    console.log(digits[digit]);

}

solve(42);
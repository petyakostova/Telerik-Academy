function solve(args) {
    var numbers = args[0].split(' ');

    function getMax(a, b) {
        if (a > b) {
            return a;
        } else if (b > a) {
            return b;
        } else {
            return a;
        }
    }

    return getMax(+numbers[0], getMax(+numbers[1], +numbers[2]));
}

solve('8 3 6');
solve('7 19 19');
function solve(args) {
    var numbers = args[0].split(' ');

    function GetMax(a, b) {
        if (a > b) {
            return a;
        } else if (b > a) {
            return b;
        } else {
            return a;
        }
    }

    return GetMax(+numbers[0], GetMax(+numbers[1], +numbers[2]));
}

solve('8 3 6');
solve('7 19 19');
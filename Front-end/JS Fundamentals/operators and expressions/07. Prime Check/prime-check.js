function solve(args) {
    var num = +args[0];

    if (num < 2) { // num < 0 or num === 0 or num === 1
        console.log('false');
        return;
    }

    var isPrime = true;

    if (num === 2 || num === 5) {
        isPrime = true;
    } else {
        if (num % 2 === 0 || num % 5 === 0) {
            isPrime = false;
        } else {
            var maxDivider = Math.sqrt(num);

            for (var i = 3; i <= maxDivider; i += 1) {
                if (num % i === 0) {
                    isPrime = false;
                    break;
                }
            }
        }
    }

    console.log(isPrime);
}

solve([2]);
solve([23]);
solve([-3]);
solve([0]);
solve([1]);
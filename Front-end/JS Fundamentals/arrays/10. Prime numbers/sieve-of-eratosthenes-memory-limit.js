function solve(args) {
    var i,
        j,
        n = +args,
        primes = new Array(n + 1),
        lengthPrimes = primes.length;

    for (i = 0; i < lengthPrimes; i += 1) {
        primes[i] = true; // array of boolean
    }

    // Find all prime numbers in the range [1...n]
    for (i = 2; i < Math.sqrt(lengthPrimes); i += 1) {
        // Skip those numbers that are not prime
        if (primes[i]) {
            for (j = i * i; j < lengthPrimes; j += i) {
                primes[j] = false;
            }
        }
    }

    for (i = lengthPrimes - 1; i >= 2; i--) {
        if (primes[i]) {
            console.log(i);
            break;
        }
    }

    // Print all prime numbers in the range [1...n]
    // process.stdout.write('2');
    // for (i = 3; i < lengthPrimes; i++) {
    //     // the numbers remaining not marked in the list are all the primes below n
    //     if (primes[i]) {
    //         process.stdout.write(', ' + i);
    //     }
    // }
    // console.log();

}

solve(13);
solve(126);
solve(26);
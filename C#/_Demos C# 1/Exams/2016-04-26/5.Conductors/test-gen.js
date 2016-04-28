// test generator
'use strict';

const randFloat = (low, high) => (Math.random() * (high - low)) + low,
    randInt = (low, high) => randFloat(low, high) | 0;

function test(p, n, step) {
    const test = [p, n],
        binaryP = p.toString(2);

    for (let i = 0; i < n; i += 1) {

        const matches = randInt(0, 32 / binaryP.length);

        let line = '';

        while ((line.length) < 32 && (matches > 0)) {

            line += binaryP;

            line += randInt(0, step).toString(2);

        }

        if (!line) {
            line = randInt(0, 1 << 20).toString(2);
        }

        const parsedLine = parseInt(line.substring(0, 31), 2);
        test.push(parsedLine);

    }

    return test;
}

const zeroTests = [
    [5, 2, 469, 13],
    [3, 4, 15, 14, 13, 7],
    [2, 2, 1, 10]
],
    tests = [
        test(3, 20, 8),
        test(5, 50, 16),
        test(21, 101, 4),
        test(7, 201, 7),
        test(2, 300, 3),
        test(21, 400, 4),
        test(33, 500, 10),
        test(1, 600, 2),
        test(2, 700, 33),
        test(7, 800, 2),

        // performance tests
        test(3, 10000, 2),
        test(7, 10000, 4),
        test(5, 25000, 1),
        test(13, 25000, 1),
        test(10, 25000, 2)
    ];

module.exports = {
    getZeroTests: () => zeroTests.slice(),
    getTests: () => tests.slice()
}
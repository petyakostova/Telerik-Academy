// test generator
'use strict';
const randFloat = (low, high) => (Math.random() * (high - low)) + low,
    randBool = (chance) => Math.random() < chance,
    randInt = (low, high) => randFloat(low, high) | 0;

function range(start, count) {
    const res = [];
    for (let i = start; i < start + count; i += 1) { res.push(i); }
    return res;
}

const zeroTests = [
    [17, 3, 14, 2, 17],
    [0, 2, 5, 1024],
    [9, 4, 1, 2, 3, 6].map(x => x.toString()),
    [2344, 2, 23, 25]
];

function sizedTest(size, compatRatio, baldnessRatio) {
    const test = [
        parseInt(range(0, 32).map(x => +randBool(baldnessRatio)).join(''), 2),
        size
    ];

    for (let i = 0; i < size; i += 1) {

        let nextComb = randInt(0, 2 << 20);

        if ((i % compatRatio) === 0) {
            nextComb &= ~test[0];

            const setOff = randInt(0, 10);
            for (let j = 0; j < setOff; j += 1) {
                nextComb &= ~(1 << randInt(0, 20));
            }
        }

        test.push(nextComb);
    }

    return test;
};

const tests = [
    sizedTest(2000, 2, 0.66),
    sizedTest(3000, 3, 0.50),
    sizedTest(4000, 4, 0.10),
    sizedTest(10000, 10, 0.33),
    sizedTest(20000, 4, 0.05),
    sizedTest(25000, 10, 0.65),
    sizedTest(40000, 3, 0.75),
    sizedTest(55000, 5, 0.80),
    sizedTest(70000, 20, 0.05),
    sizedTest(65000, 400, 0.9),
    sizedTest(95000, 2, 0.7),
    sizedTest(90000, 3, 0.5),
    sizedTest(90000, 2, 0.65),
    sizedTest(90000, 2, 0.9),
    sizedTest(90000, 3, 0.65)
];

module.exports = {
    getZeroTests: () => zeroTests.slice(),
    getTests: () => tests.slice()
}
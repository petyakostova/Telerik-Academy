function solve(args) {
    var number = +args[0];

    switch (number) {
        case 0: console.log('zero'); break;
        case 1: console.log('one'); break;
        case 2: console.log('two'); break;
        case 3: console.log('three'); break;
        case 4: console.log('four'); break;
        case 5: console.log('five'); break;
        case 6: console.log('six'); break;
        case 7: console.log('seven'); break;
        case 8: console.log('eight'); break;
        case 9: console.log('nine'); break;
        default: console.log('not a digit'); break;
    }
}

solve([2]);
solve([1]);
solve([0]);
solve([5]);
solve([-0.1]);
solve(['hi']);
solve([9]);
solve([10]);
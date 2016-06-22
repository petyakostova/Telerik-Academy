function solve(args) {
    var num = +args;
    if (num % 2) {
        console.log('odd ' + num);
    } else {
        console.log('even ' + num);
    }
}

solve("3");
solve("2");
solve("-2");
solve("-1");
solve("0");

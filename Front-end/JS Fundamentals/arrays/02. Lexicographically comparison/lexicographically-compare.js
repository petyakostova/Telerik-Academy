function solve(args) {
    var arr = args[0].split('\n'),
        firstStr = arr[0],
        secondStr = arr[1];

    if (firstStr > secondStr) {
        console.log('>');
    } else if (firstStr < secondStr) {
        console.log('<');
    } else {              // firstStr === secondStr
        console.log('=');
    }

}

solve(['hello\nhalo']);
solve(['food\nfood']);
function solve(args) {
    //var n = parseInt(args[0]); // n = args.length
    var countIncrSeq = 1;

    args = args.map(Number);  // converts the input data from string into a number

    //console.log(args); // print the sequence

    for (var i = 2; i < args.length; i += 1) {
        if (args[i - 1] > args[i]) {
            countIncrSeq += 1;
        }
    }

    console.log(countIncrSeq);
}

solve(['7', '1', '2', '-3', '4', '4', '0', '1']);
solve(['6', '1', '3', '-5', '8', '7', '-6']);
solve(['9', '1', '8', '8', '7', '6', '5', '7', '7', '6']);
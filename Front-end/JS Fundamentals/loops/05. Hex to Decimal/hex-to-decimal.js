function solve(args) {
    var hexNum = args[0].toUpperCase(),
        decNum = 0,
        i,
        multiplier;

    for (i = 0; i < hexNum.length; i += 1) {
        switch (hexNum[hexNum.length - i - 1]) {
            case 'A': multiplier = 10; break;
            case 'B': multiplier = 11; break;
            case 'C': multiplier = 12; break;
            case 'D': multiplier = 13; break;
            case 'E': multiplier = 14; break;
            case 'F': multiplier = 15; break;
            default: multiplier = hexNum[hexNum.length - i - 1]; break;
        }

        decNum += multiplier * Math.pow(16, i);
    }

    console.log(decNum);
}

solve(['FE']);
solve(['1AE3']);
solve(['4ED528CBB4']);
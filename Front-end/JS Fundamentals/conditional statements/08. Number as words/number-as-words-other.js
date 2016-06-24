function solve(args) {
    var number = parseInt(args[0]),
        temp = number,
        firstDigit,
        secondDigit,
        thirdDigit;

    thirdDigit = temp % 10;
    temp = Math.floor(temp / 10);
    secondDigit = temp % 10;
    temp = Math.floor(temp / 10);
    firstDigit = temp % 10;

    function OnesValue(thirdDigitTemp, secondDigitTemp, firstDigitTemp) {
        if (secondDigitTemp != 1) {
            switch (thirdDigitTemp) {
                case 1: return 'one';
                case 2: return 'two';
                case 3: return 'three';
                case 4: return 'four';
                case 5: return 'five';
                case 6: return 'six';
                case 7: return 'seven';
                case 8: return 'eight';
                case 9: return 'nine';
                case 0:
                    if (firstDigitTemp == 0 && secondDigitTemp == 0) {
                        return 'zero';
                    }
                    else {
                        return '';
                    }
                default: return 'How do you get here?';
            }
        }
        else {
            return '';
        }
    };

    function TensValue(thirdDigitTemp, secondDigitTemp) {
        if (secondDigitTemp == 1) {
            var tensTemp = 10 + thirdDigitTemp;
            switch (tensTemp) {
                case 10: return 'ten';
                case 11: return 'eleven';
                case 12: return 'twelve';
                case 13: return 'thirteen';
                case 14: return 'fourteen';
                case 15: return 'fifteen';
                case 16: return 'sixteen';
                case 17: return 'seventeen';
                case 18: return 'eighteen';
                case 19: return 'nineteen';
                default: return 'How do you get there?'
            }
        }
        else {
            switch (secondDigitTemp) {
                case 2: return 'twenty';
                case 3: return 'thirty';
                case 4: return 'forty';
                case 5: return 'fifty';
                case 6: return 'sixty';
                case 7: return 'seventy';
                case 8: return 'eighty';
                case 9: return 'ninety';
                case 0: return '';
                default: return 'How do you get there?';
            }
        }
    };

    function HudredsValue(firstDigitTemp) {
        switch (firstDigitTemp) {
            case 1: return 'one hundred';
            case 2: return 'two hundred';
            case 3: return 'three hundred';
            case 4: return 'four hundred';
            case 5: return 'five hundred';
            case 6: return 'six hundred';
            case 7: return 'seven hundred';
            case 8: return 'eight hundred';
            case 9: return 'nine hundred';
            case 0: return '';
            default: return 'How do you get there';
        }
    };

    function capitalizeFirstLetter(string) {
        return string.charAt(0).toUpperCase() + string.slice(1);
    };

    var result;

    if (firstDigit != '') {
        if (secondDigit == '' && thirdDigit == '') {
            result = HudredsValue(firstDigit);
        } else {
            result = HudredsValue(firstDigit) + ' and ' + TensValue(thirdDigit, secondDigit) + ' ' + OnesValue(thirdDigit, secondDigit, firstDigit);
        }
    } else {
        result = HudredsValue(firstDigit) + ' ' + TensValue(thirdDigit, secondDigit) + ' ' + OnesValue(thirdDigit, secondDigit, firstDigit);
    }

    console.log(capitalizeFirstLetter(result.trim().replace(/  +/g, ' ')));
}
function solve(args) {
    var number = + args[0],
        ones,
        tens,
        hundreds,
        numberAsWord = '',
        onesAsWord = ['', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten',
            'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'],
        tensAsWord = new Array('', '', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety');

    String.prototype.capitalizeFirstLetter = function () {
        return this.charAt(0).toUpperCase() + this.slice(1);
    };

    function NumberToWordFromOneToNintyNine() {
        if (number > 0 && number < 20) {
            numberAsWord = onesAsWord[number];
            return numberAsWord;
        } else if (number > 19 && number < 100) {
            numberAsWord = tensAsWord[tens] + ' ' + onesAsWord[ones];
            return numberAsWord;
        }
    }

    if (number === 0) {
        numberAsWord = 'Zero';
    } else if (number < 100) {
        ones = +args[0][1];
        tens = +args[0][0];
        numberAsWord = NumberToWordFromOneToNintyNine();
    } else {
        ones = +args[0][2];
        tens = +args[0][1];
        hundreds = +args[0][0];
        number = +(args[0].substring(1));

        numberAsWord = NumberToWordFromOneToNintyNine();
        if (number !== 0) {
            numberAsWord = onesAsWord[hundreds] + ' hundred and ' + numberAsWord;
        } else {
            numberAsWord = onesAsWord[hundreds] + ' hundred';
        }
    }

    console.log(numberAsWord.capitalizeFirstLetter());
}
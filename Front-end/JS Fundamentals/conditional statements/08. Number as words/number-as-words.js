function solve(args) {
    var number = +args[0],
        numAsString = args[0];

    if (number >= 100 && number <= 999) {
        switch (numAsString[0]) {
            case '1': process.stdout.write('One hundred'); break;
            case '2': process.stdout.write('Two hundred'); break;
            case '3': process.stdout.write('Three hundred'); break;
            case '4': process.stdout.write('Four hundred'); break;
            case '5': process.stdout.write('Five hundred'); break;
            case '6': process.stdout.write('Six hundred'); break;
            case '7': process.stdout.write('Seven hundred'); break;
            case '8': process.stdout.write('Eight hundred'); break;
            case '9': process.stdout.write('Nine hundred'); break;
        }

        if (numAsString[1] === '0') {
            switch (numAsString[2]) {
                case '0': console.log(); break;
                case '1': console.log(' and one'); break;
                case '2': console.log(' and two'); break;
                case '3': console.log(' and three'); break;
                case '4': console.log(' and four'); break;
                case '5': console.log(' and five'); break;
                case '6': console.log(' and six'); break;
                case '7': console.log(' and seven'); break;
                case '8': console.log(' and eight'); break;
                case '9': console.log(' and nine'); break;
            }
        } else if (numAsString[1] === '1') {
            switch (numAsString[2]) {
                case '0': console.log(' and ten'); break;
                case '1': console.log(' and eleven'); break;
                case '2': console.log(' and twelve'); break;
                case '3': console.log(' and thirteen'); break;
                case '4': console.log(' and fourteen'); break;
                case '5': console.log(' and fifteen'); break;
                case '6': console.log(' and sixteen'); break;
                case '7': console.log(' and seventeen'); break;
                case '8': console.log(' and eighteen'); break;
                case '9': console.log(' and nineteen'); break;
            }
        } else if (numAsString[1] !== '1') {
            switch (numAsString[1]) {
                case '2': process.stdout.write(' and twenty'); break;
                case '3': process.stdout.write(' and thirty'); break;
                case '4': process.stdout.write(' and fourty'); break;
                case '5': process.stdout.write(' and fifty'); break;
                case '6': process.stdout.write(' and sixty'); break;
                case '7': process.stdout.write(' and seventy'); break;
                case '8': process.stdout.write(' and eighty'); break;
                case '9': process.stdout.write(' and ninety'); break;
            }

            if (numAsString[2] !== '0') {
                switch (numAsString[2]) {
                    case '1': console.log(' one'); break;
                    case '2': console.log(' two'); break;
                    case '3': console.log(' three'); break;
                    case '4': console.log(' four'); break;
                    case '5': console.log(' five'); break;
                    case '6': console.log(' six'); break;
                    case '7': console.log(' seven'); break;
                    case '8': console.log(' eight'); break;
                    case '9': console.log(' nine'); break;
                }
            } else {
                console.log(); // for new line
                //process.stdout.write('\n');
            }
        }
    }

    if (number >= 20 && number < 100) {
        switch (numAsString[0]) {
            case '2': process.stdout.write('Twenty'); break;
            case '3': process.stdout.write('Thirty'); break;
            case '4': process.stdout.write('Forty'); break; // Fourty
            case '5': process.stdout.write('Fifty'); break;
            case '6': process.stdout.write('Sixty'); break;
            case '7': process.stdout.write('Seventy'); break;
            case '8': process.stdout.write('Eighty'); break;
            case '9': process.stdout.write('Ninety'); break;
        }

        if (numAsString[1] !== '0') {
            switch (numAsString[1]) {
                case '1': console.log(' one'); break;
                case '2': console.log(' two'); break;
                case '3': console.log(' three'); break;
                case '4': console.log(' four'); break;
                case '5': console.log(' five'); break;
                case '6': console.log(' six'); break;
                case '7': console.log(' seven'); break;
                case '8': console.log(' eight'); break;
                case '9': console.log(' nine'); break;
            }
        } else {
            console.log(); // for new line
            //process.stdout.write('\n');
        }
    }

    if (number >= 10 && number <= 19) {
        switch (numAsString[1]) {
            case '0': console.log('Ten'); break;
            case '1': console.log('Eleven'); break;
            case '2': console.log('Twelve'); break;
            case '3': console.log('Thirteen'); break;
            case '4': console.log('Tourteen'); break;
            case '5': console.log('Fifteen'); break;
            case '6': console.log('Sixteen'); break;
            case '7': console.log('Seventeen'); break;
            case '8': console.log('Eighteen'); break;
            case '9': console.log('Nineteen'); break;
        }
    }

    if (number >= 1 && number <= 9) {
        switch (numAsString[0]) {
            case '1': console.log('One'); break;
            case '2': console.log('Two'); break;
            case '3': console.log('Three'); break;
            case '4': console.log('Four'); break;
            case '5': console.log('Five'); break;
            case '6': console.log('Six'); break;
            case '7': console.log('Seven'); break;
            case '8': console.log('Eight'); break;
            case '9': console.log('Nine'); break;
        }
    } else if (numAsString[0] === '0') {
        console.log('Zero');
    }
}

solve(['0']);
solve(['9']);
solve(['10']);
solve(['12']);
solve(['19']);
solve(['25']);
solve(['98']);
solve(['273']);
solve(['400']);
solve(['501']);
solve(['617']);
solve(['711']);
solve(['999']);
solve(['20']);
solve(['410']);
solve(['420']);
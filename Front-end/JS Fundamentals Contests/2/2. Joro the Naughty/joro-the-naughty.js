function solve(input) {
    // прочитаме първия ред от входа, съдържащ редовете, колоните и броя скокове
    //var rowsColsAndJumps = input[0].split(' ').map(Number);  // сплитваме по интервал и превръща стринговете в числа
    var rowsColsAndJumps = parseNumbers(input[0]);

    // прочитаме втория ред от входа, който задава стартовата позиция
    //var startPosition = input[1].split(' ').map(Number);  // instead of that, we white it with function
    var startPosition = parseNumbers(input[1]);

    var rows = rowsColsAndJumps[0];
    var cols = rowsColsAndJumps[1];
    var allJumps = rowsColsAndJumps[2];

    var currentRow = startPosition[0];
    var currentCol = startPosition[1];

    return getAnswer(); // return the answer

    function getAnswer() {
        var field = initField();    // filling the matrix
        var jumps = readJumps();    // to check => console.log(jumps);

        var escaped = false;
        var sumOfNumbers = 0;   // в единия случай за резултата ни трябва сумата на числата
        var totalJumps = 0;     // в другия случай за резултата ни трябва броят подскоци
        var jumpsIndex = 0;     /*индекс, който показва къде сме в момента с подскоците; 
         *                          този индекс ще обикаля по jumps и ще връща правилния обект*/ 

        // цикълът ще обикаля по подскоците
        while (true) {
            // първо трябва да проверим къде break-ва цикълът
            if (currentRow < 0 || currentRow >= rows
                || currentCol < 0 || currentCol >= cols) {
                escaped = true;
                break;
            }

            // ако стъпи на нещо, посетено
            if (field[currentRow][currentCol] == 'X') {
                escaped = false;
                break;
            }

            // да го посетим
            sumOfNumbers += field[currentRow][currentCol];  // добавяме текущото място, на което сме подскочили, към сумата
            totalJumps+=1;   // увеличаваме броя на подскоците

            var currentJump = jumps[jumpsIndex++];  // обикаляме подскоците (минаваме на следващия подскок) => текущия скок
            if (jumpsIndex >= jumps.length) {   // ако сме обиколили всички подскоци,
                jumpsIndex = 0;                 // нулираме
            }
         
            field[currentRow][currentCol] = 'X';    // маркираме с X навсякъде, където стъпва => посещението

            currentRow += currentJump.row;
            currentCol += currentJump.col;
        }

        return escaped                      // if Joro has escaped
            ? 'escaped ' + sumOfNumbers     // return: escaped SUM_OF_NUMBERS
            : 'caught ' + totalJumps;       // otherwise: caught NUMBER_OF_JUMPS 
    }

    // function for filling the matrix
    function initField() {
        var field = [];
        var counter = 1;
        for (var i = 0; i < rows; i+=1) {
            field[i] = [];  // new array
            for (var j = 0; j < cols; j+=1) {
                field[i][j] = counter++;
            }
        }
        return field;
    }

    // function for reading the jumps
    function readJumps() {
        var jumps = [];
        // the jumps can be read directly from the input
        // args[2] to args[2+J] contains the jumps => Подскоците четем от втория ред до втория+всичките подскоци ред
        for (var i = 2; i < 2 + allJumps; i+=1) {    // 2 + allJumps = input.length
            var parsedJump = parseNumbers(input[i]);    // read the jumps from the input and parse them
            // we will use objects
            var currentJump = {
                row: parsedJump[0], 
                col: parsedJump[1]
            };
            jumps.push(currentJump);
        }

        return jumps; // the function returns an array
    }

    function parseNumbers(input) {
        return input.split(' ').map(Number);
    }

}

console.log(solve([
   '6 7 3',
   '0 0',
   '2 2',
   '-2 2',
   '3 -1',
])); 
// escaped 89
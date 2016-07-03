function solve(args) {
    // reading the first line from the input => rows, cols, number of jumps
    //var rowsColsAndJumps = args[0].split(' ').map(Number); // instead of that, we white it with function
    var rowsColsAndJumps = parseNumbers(args[0]);
    // reading the second line from the input => the start position
    //var startPosition = args[1].split(' ').map(Number);  
    var startPosition = parseNumbers(args[1]);

    var rows = rowsColsAndJumps[0]; // N
    var cols = rowsColsAndJumps[1]; // M
    var allJumps = rowsColsAndJumps[2]; // J
    var currentRow = startPosition[0]; // R
    var currentCol = startPosition[1]; // C

    return getAnswer(); // return the answer    


    function getAnswer() {
        var field = initField();    // filling the matrix with function
        var jumps = readJumps();    // reading the jumps with function

        var escaped = false;     
        var sumOfNumbers = 0;   // in the first case we need the sum of the numbers for the result
        var totalJumps = 0;     // in the other case we need the number of jumps for the result
        var jumpsIndex = 0;     /* index that shows where are we right now with jumps; 
                                   this index will be touring in jumps and returns the correct object */

        // the loop will tour in jumps
        while (true) {            
            // first we must check where the loop breaks
            if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols) {
                escaped = true;
                break;
            }

            // if Joro goes to a previously visited position
            if (field[currentRow][currentCol] === 'X') {
                //escaped = false;
                break;
            }

            // to visit
            sumOfNumbers += field[currentRow][currentCol];  // add the current location, we jumped, to sum
            totalJumps += 1;   // increasing the number of jumps

            // we must change the jump
            var currentJump = jumps[jumpsIndex++]; // touring jumps (pass on the next jump) => current jump
            if (jumpsIndex >= jumps.length) {   // if we toured all jumps,
                jumpsIndex = 0;                 // resetting
            }

            field[currentRow][currentCol] = 'X'; // mark by X wherever steps => the visit            

            currentRow += currentJump.row;
            currentCol += currentJump.col;
        }

        return escaped                    // if Joro has escaped
            ? 'escaped ' + sumOfNumbers   // return: escaped SUM_OF_NUMBERS
            : 'caught ' + totalJumps;     // otherwise: caught NUMBER_OF_JUMPS 
    }

    // function for reading the jumps
    function readJumps() {
        var jumps = [];
        // the jumps can be read directly from the input
        // args[2] to args[2+J] contains the jumps => we read the jumps from the second line to the (2+allJumps) line

        for (var i = 2; i < 2 + allJumps; i += 1) {    // 2 + allJumps = input.length

            //var parsedJump = args[i].split(' ').map(Number); // read the jumps from the input and parse them
            var parsedJump = parseNumbers(args[i]); // using the function parseNumbers

            // we will use objects
            var currentJump = {
                row: parsedJump[0],
                col: parsedJump[1]
            };

            jumps.push(currentJump);
            // if we want to get it => jumps[r].row => the variable at the row r
        }

        //console.log(jumps); // check
        return jumps; // the function returns an array
    }

    // function for filling the matrix
    function initField() {

        var field = [];
        var counter = 1;

        for (var i = 0; i < rows; i += 1) {
            field[i] = [];  // new array

            for (var j = 0; j < cols; j += 1) {
                field[i][j] = counter++;
            }
        }

        //console.log(field); // check
        return field;
    }

    function parseNumbers(input) {
        return input.split(' ').map(Number); // spliting by interval and converting strings in numbers
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
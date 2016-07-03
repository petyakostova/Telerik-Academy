// solution like horsy.js but using unique number with the formula:
// row * cols + col

function solve(args) {

    function getPoints(row, col) {
        return Math.pow(2, row) - col;
    }

    function getRowsAndCols(str) {
        var parts = str.split(' ');
        return [parseInt(parts[0]), parseInt(parts[1])];
    }

    function getValue(args, row, col) {
        return args[row + 1][col];
    }

    var rowsAndCols = getRowsAndCols(args[0]),
        rows = rowsAndCols[0],
        cols = rowsAndCols[1],
        row = rows - 1,
        col = cols - 1,
        points = 0,
        moves = 0,
        used = [];

    var horseMoves = [[-2, 1], [-1, 2], [1, 2], [2, 1],
        [2, -1], [1, -2], [-1, -2], [-2, -1]];

    while (true) {

        if (row < 0 || row >= rows || col < 0 || col >= cols) {
            console.log('Go go Horsy! Collected ' + points + ' weeds');
            break;
        }

        // using hash code => row * cols + col
        if (used[row * cols + col]) {
            console.log('Sadly the horse is doomed in ' + moves + ' jumps');
            break;
        }

        moves = moves + 1;
        points = points + getPoints(row, col);

        var move = horseMoves[getValue(args, row, col) - 1];

        // using hash code => row * cols + col
        used[row * cols + col] = true;

        row += move[0];
        col += move[1];
    }
}

solve(['3 5', '54561', '43328', '52388']);
console.log('Go go Horsy! Collected 1 weeds');

solve(['3 5', '54361', '43326', '52188']);
console.log('Sadly the horse is doomed in 7 jumps');
function solve(args) {
  var rowsCols = args[0].split(' '),
    bounds = {
      rows: +rowsCols[0],
      cols: +rowsCols[1]
    },

    matrix = args.slice(1)
      .map(function (line) {
        // 'dr dl dr ur ul'
        // ->
        // ['dr', 'dl', 'dr', 'ur', 'ul']
        return line.split(' ');
      }),
    //return matrix; 

    row = 0,
    col = 0,
    sum = 0,
    dir,
    deltas = {
      u: -1, // the row changes with -1
      d: +1, // the row
      l: -1, // the col
      r: +1  // the col
    },
    upDown,
    leftRight,
    used = {},
    key;

  while (true) {
    //if (row < 0 || row >= bounds.rows || col < 0 || col >= bounds.cols) {    
    if (!matrix[row] || !matrix[row][col]) {
      return 'successed with ' + sum;
    }

    key = row + ';' + col;

    if (used[key]) {
      return 'failed at (' + row + ', ' + col + ')';
    }

    used[key] = true;

    // update sum => the value in every cell is = (2 on power row) + col
    sum += (1 << row) + col;
    // sum += Math.pow(2, row) + col; // slower the bitwise operations

    dir = matrix[row][col]; // take the direction

    upDown = dir[0];
    leftRight = dir[1];
    // update row
    row += deltas[upDown];
    // update col
    col += deltas[leftRight];
  }

}

console.log(solve([
  '3 5',
  'dr dl dr ur ul',
  'dr dr ul ur ur',
  'dl dr ur dl ur'
]));
// successed with 20

console.log(solve([
  '3 5',
  'dr dl dl ur ul',
  'dr dr ul ul ur',
  'dl dr ur dl ur'
]));
// failed at (1, 1)
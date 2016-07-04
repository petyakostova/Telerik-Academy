function solve(args) {
  'use strict';
  var key, row, col, sum,

    lab = args.slice(1).map(function (line) {
      return line.split(' ');
    }),

    directions = {
      d: +1,
      u: -1,
      l: -1,
      r: +1
    },

    visited = {};

  function getValueAt(row, col) {
    return (1 << row) + col;
  }

  row = 0;
  col = 0;
  sum = 0;

  while (true) {

    if (!lab[row] || !lab[row][col]) {
      return 'successed with ' + sum;
    }

    key = row + ';' + col;

    if (visited[key]) {
      return 'failed at (' + row + ', ' + col + ')';
    }

    visited[key] = true;

    sum += getValueAt(row, col);

    var dir = lab[row][col];

    row += directions[dir[0]];
    col += directions[dir[1]];
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
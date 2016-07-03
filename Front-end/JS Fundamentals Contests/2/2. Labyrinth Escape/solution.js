 function Solve(args) {
     var nmStr = args[0].split(" ");
     var n = parseInt(nmStr[0]);
     var m = parseInt(nmStr[1]);
     var posStr = args[1].split(" ");
     var row = parseInt(posStr[0]);
     var col = parseInt(posStr[1]);
     var field = args.slice(2);
     var sum = 0;
     var count = 0;

     var dirs = {
         l: {
             row: 0,
             column: -1
         },
         r: {
             row: 0,
             column: 1
         },
         u: {
             row: -1,
             column: 0
         },
         d: {
             row: 1,
             column: 0
         },
     };

     var dir;

     var used = {};
     while (0 <= row && row < n && 0 <= col && col < m) {
         if (used[row * m + col]) {
             return "lost " + count;
         }
         used[row * m + col] = true;
         count++;
         sum += row * m + col + 1;
         dir = field[row][col];
         row += dirs[dir].row;
         col += dirs[dir].column;
     }
     return "out " + sum;
 }

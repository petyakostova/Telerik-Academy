function solve(args) {
      var num = +args;

      if (num % 35) {
            console.log('false ' + num);
      } else {
            console.log('true ' + num);
      }
}

solve("3");
solve("0");
solve("5");
solve("7");
solve("35");
solve("140");	
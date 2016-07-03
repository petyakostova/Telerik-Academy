function solve(args) {
  var s = +args[0], // the number of all wheels
    count = 0, // number of all possible combinations of cars, trucks and trikes with exactly S wheels
    w1 = 4, // car wheels
    w2 = 10, // truck wheels
    w3 = 3; // trike wheels

  for (var count1 = 0; count1 <= s / w1; count1 += 1) {
    for (var count2 = 0; count2 <= s / w2; count2 += 1) {
      for (var count3 = 0; count3 <= s / w3; count3 += 1) {

        if ((count1 * w1 + count2 * w2 + count3 * w3) === s) {
          count += 1;
        }

      }
    }
  }

  console.log(count);
}

solve(['7']); // 1
solve(['10']); // 2
solve(['40']); // 11

// other way for testing

// var tests = [
//   ['7'],
//   ['10'],
//   ['40']  
// ];

// tests.forEach(function (tests) {
//   console.log(solve(tests));
// });
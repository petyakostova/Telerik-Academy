function solve(params) {
  var s = params[0],
    c1 = params[1], c2 = params[2], c3 = params[3],
    maxMoneyAmount = 0;

  for (var count1 = 0; count1 < s / c1 + 1; count1 += 1) {
    for (var count2 = 0; count2 < s / c2 + 1; count2 += 1) {
      for (var count3 = 0; count3 < s / c3 + 1; count3 += 1) {

        var price = count1 * c1 + count2 * c2 + count3 * c3;

        if (price <= s) {
          maxMoneyAmount = Math.max(maxMoneyAmount, price);
        } else { // for optimization
          break;
        }

      }
    }
  }

  console.log(maxMoneyAmount);
  //return maxMoneyAmount;
}

solve([110, 13, 15, 17]); // 110
solve([20, 11, 200, 300]); // 11
solve([110, 19, 29, 39]); // 107

//console.log(solve([110, 13, 15, 17]) == 110);
//console.log(solve([20, 11, 200, 300]) == 11);
//console.log(solve([110, 19, 29, 39]) == 107);
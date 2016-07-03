function solve(input) {
    //var count = parseInt(input[0]);
    var result = 1;

    input = input.map(Number);  // преобразува входните данни от стринг в число

    //console.log(input); // изписва редицата

    for (var i = 2; i < input.length; i++) {
        if (input[i - 1] > input[i]) {
            result++;
        }
    }

    console.log(result);
}

solve([7,1,2,-3,4,4,0,1]);
solve([6,1,3,-5,8,7,-6]);
solve([9,1,8,8,7,6,5,7,7,6]);
function solve(args) {
    'use strict';
    let heights = args[0].split(' ').map(Number),
        bestCount = -1,
        count = 0,
        climbDown = true,
        current = heights[0];

    // to catch if the last valley is with best rocks count => must start climb down
    heights.push(-1);

    for (let i = 1; i < heights.length; i += 1) {
        let height = heights[i];

        if (climbDown) {
            // stop climb down => start to climbing
            if (current < height) {
                climbDown = false;
            }
        } else { // climbing
            // stop climb => start climb down
            if (current > height) {
                bestCount = Math.max(bestCount, count); // save count
                count = 0; // reset count
                climbDown = true; // climbDown = !climbDown;
            }
        }
        
        current = height; // update current        
        count += 1;
    }

    console.log(bestCount);
}

solve(['5 1 7 4 8']);
solve(['5 1 7 6 3 6 4 2 3 8']);
solve(['10 1 2 3 4 5 4 3 2 1 10']);
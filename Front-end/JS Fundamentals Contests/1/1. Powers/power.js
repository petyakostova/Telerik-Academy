function solve(params) {
    var nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number),
        result = 0,
        n = nk[0],
        k = nk[1],
        changed = new Array(n),
        pre,
        next;

    //console.log(s); // изписва редицата

    for (var i = 0; i < k; i++) {
        for (var j = 0; j < n; j++) {
            if (j == 0) {
                pre = n - 1;
                next = 1;
            } else if (j == n - 1) {
                pre = n - 2;
                next = 0;
            } else {
                pre = j - 1;
                next = j + 1;
            }

            if (s[j] == 0) {
                changed[j] = Math.abs(s[pre] - s[next]);
            }
            else if (s[j] == 1) {
                changed[j] = s[pre] + s[next];
            }
            else if (s[j] % 2 == 0) {    // even
                changed[j] = Math.max(s[pre], s[next]);
            }
            else {   // odd
                changed[j] = Math.min(s[pre], s[next]);
            }
        }
        s = changed.slice(0);
    }

    //console.log(changed);

    if (k != 0) {
        for (var z = 0; z < n; z++) {
            result += changed[z];
        }
    } else {
        for (var z = 0; z < n; z++) {
            result += s[z];
        }
    }

    console.log(result);
}

// за тестване
solve(['5 1', '9 0 2 4 1']);
solve(['10 3', '1 9 1 9 1 9 1 9 1 9']);
solve(['10 10', '0 1 2 3 4 5 6 7 8 9']);

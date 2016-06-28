function solve() {
    var intVariable = 1,
        floatVariable = 1.05,
        boolVariable = true,
        stringVariable = 'Hello',
        objectVariable = {
            name: 'Alf',
            age: 111
        },
        arrayVariable = [1, 2, 3, 4, 5],
        quotedString = '\'How you doin\'?\', Joey said.',
        arrayOfVariables = [
            intVariable,
            floatVariable,
            boolVariable,
            stringVariable,
            objectVariable,
            arrayVariable,
            quotedString
        ];

    for (var i = 0; i < arrayOfVariables.length; i += 1) {
        console.log('type of ' + arrayOfVariables[i] + ' is: ' + typeof (arrayOfVariables[i]));
    }        
}

solve();
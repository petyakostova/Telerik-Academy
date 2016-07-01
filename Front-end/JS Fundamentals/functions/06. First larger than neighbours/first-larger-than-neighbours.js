function solve(args) {
    var i,
    len = +args[0],
        numbers = args[1].split(' ');

        console.log(firstLargerThanNeighbours(numbers, len));
    
    function firstLargerThanNeighbours(numbersArray, length){
        for (i = 1; i < length - 1; i+=1)
        {
            if (+numbersArray[i] > +numbersArray[i - 1] && +numbersArray[i] > +numbersArray[i + 1])
            {
                return i;
            }
        }

        return -1;
    }

}

solve(['6', '-26 -25 -28 31 2 27']);
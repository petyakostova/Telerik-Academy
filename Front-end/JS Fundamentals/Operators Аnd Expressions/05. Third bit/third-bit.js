function solve(args) {
    var num = +args[0];

    var position = 3;

    var bit = (num >> position) & 1;   
    // other way    
    //var bit = (num & (1 << position)) >> position; 
        
    console.log(bit);  
}

solve([15]);
solve([1024]);
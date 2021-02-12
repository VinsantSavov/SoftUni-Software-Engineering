function solve(array, start, end){
    if(!Array.isArray(array)){
        return NaN;
    }

    if(start < 0){
        start = 0;
    }

    if(end > array.length - 1){
        end = array.length - 1;
    }

    return array.slice(start, end + 1).reduce((a, c) => a += Number(c), 0);
}

console.log(solve([10, 20, 30, 40, 50, 60], 3, 300));
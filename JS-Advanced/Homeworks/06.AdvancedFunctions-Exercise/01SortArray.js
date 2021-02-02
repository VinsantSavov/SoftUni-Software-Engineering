function solve(array, type){
    if(type == 'asc'){
        array = array.sort((a, b) => a - b);
    }else if(type == 'desc'){
        array = array.sort((a, b) => b - a);
    }

    return array;
}

console.log(solve([14, 7, 17, 6, 8], 'desc'));
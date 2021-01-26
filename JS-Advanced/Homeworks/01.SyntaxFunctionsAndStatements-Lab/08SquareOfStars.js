function printRectangle(size){
    let result = '';

    if(size == undefined){
        size = 5;
    }

    for(let row = 0; row < size; row++){
        for(let col = 0; col < size; col++){
            result += '* ';
        }
        result += '\n';
    }

    return result;
}

console.log(printRectangle());
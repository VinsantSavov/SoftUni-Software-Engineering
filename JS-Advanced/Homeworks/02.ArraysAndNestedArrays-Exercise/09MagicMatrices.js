function magicMatrix(matrix){
    const array = [];

    for(let row = 0;row < matrix.length; row++){
        let rowSum = 0;

        for(let col = 0;col < matrix[row].length; col++){
            rowSum += matrix[row][col];
        }

        array.push(rowSum);
    }

    for(let col = 0;col < matrix[0].length; col++){
        let colSum = 0;

        for(let row = 0;row < matrix.length; row++){
            colSum += matrix[row][col];
        }

        array.push(colSum);
    }

    for(let i = 0;i< array.length-1; i++){
        if(array[i] != array[i+1]){
            return false;
        }
    }
    return true;
}

console.log(magicMatrix([[11,32,45],[21,0,1],[21,1,1]]));
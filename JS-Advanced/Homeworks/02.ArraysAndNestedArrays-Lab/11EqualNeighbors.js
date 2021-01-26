const equalElements = (matrix) => {
    let count = 0;

    for(let row = 0; row < matrix.length; row++){
        for(let col = 0; col < matrix[row].length; col++){

            if(matrix[row + 1] != undefined){
                if(matrix[row][col] == matrix[row + 1][col]){
                    count++;
                }
            }

            if(matrix[row][col] == matrix[row][col + 1]){
                count++;
            }
        }
    }

    return count;
}

console.log(equalElements([['2', '3', '5', '7', '0'],
                            ['2', '3', '5', '4', '2']]));
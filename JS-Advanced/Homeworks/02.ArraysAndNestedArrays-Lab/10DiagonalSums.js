const getDiagonalSums = (matrix) => {
    const result = [];
    let mainSum = 0;
    let secondarySum = 0;

    for(let row = 0; row < matrix.length; row++){
        for(let col = 0; col < matrix.length; col++){
            if(row == col){
                mainSum += matrix[row][col];
            }

            if(row == matrix.length - col -1){
                secondarySum += matrix[row][col];
            }
        }
    }

    result.push(mainSum);
    result.push(secondarySum);

    return result.join(' ');
}
function modifyArray(inputMatrix){
    const matrix = [];
    for(let i = 0; i < inputMatrix.length; i++){
        let line = inputMatrix[i].split(' ');
        let lineArr = [];

        for(let num of line){
            lineArr.push(Number(num));
        }

        matrix.push(lineArr);
    }

    let mainDiagonalSum = 0;
    let minorDiagonalSum = 0;

    for(let row = 0; row < matrix.length; row++){
        for(let col = 0; col < matrix[row].length; col++){
            if(row == col){
                mainDiagonalSum += matrix[row][col];
            }

            if(row + col == matrix.length - 1){
                minorDiagonalSum += matrix[row][col];
            }
        }
    }

    if(mainDiagonalSum != minorDiagonalSum){
        printMatrix(matrix);
        return;
    }

    for(let row = 0; row < matrix.length; row++){
        for(let col = 0; col < matrix[row].length; col++){
            if(row != col && row + col != matrix.length - 1){
                matrix[row][col] = mainDiagonalSum;
            }
        }
    }

    printMatrix(matrix);
    return;

    function printMatrix(matrix){
        for(let i = 0; i < matrix.length; i++){
            console.log(matrix[i].join(' '));
        }
    }
}

modifyArray(['5 3 12 3 1',
'11 4 23 2 5',
'101 12 3 21 10',
'1 4 5 2 2',
'5 22 33 11 1']);
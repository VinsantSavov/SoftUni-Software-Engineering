function createSpiralMatrix(rows, cols){
    let matrix = [];

    for(let row = 0; row < rows; row++){
        let line = [];
        
        for(let col = 0; col < cols; col++){
            line.push(0);
        }

        matrix.push(line);
    }

    let currRow = 0;
    let currCol = 0;
    let direction = 'right';

    for(let i = 1; i <= rows * cols; i++){
        if(direction == 'right'){
            matrix[currRow][currCol] = i;
            currCol++;

            if(matrix[currRow][currCol] != 0){
                direction = "down";
                currCol--;
                currRow++;
                continue;
            }
        }
        else if(direction == 'down'){
            matrix[currRow][currCol] = i;
            currRow++;

            if(currRow >= matrix.length || matrix[currRow][currCol] != 0){
                direction = 'left';
                currRow--;
                currCol--;
                continue;
            }
        }
        else if(direction == 'left'){
            matrix[currRow][currCol] = i;
            currCol--;

            if(matrix[currRow][currCol] != 0){
                direction = 'up';
                currCol++;
                currRow--;
                continue;
            }
        }
        else if(direction == 'up'){
            matrix[currRow][currCol] = i;
            currRow--;

            if(currRow < 0 || matrix[currRow][currCol] != 0){
                direction = 'right';
                currRow++;
                currCol++;
                continue;
            }
        }
    }

    for(let row = 0; row < rows; row++){
        console.log(matrix[row].join(' '));
    }
}

createSpiralMatrix(3, 3);
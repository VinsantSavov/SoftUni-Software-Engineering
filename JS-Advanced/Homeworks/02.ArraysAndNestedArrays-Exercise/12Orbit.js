function createOrbit(info){
    let rows = info[0];
    let cols = info[1];
    let x = info[2];
    let y = info[3];

    let matrix = [];

    for(let row = 0; row < rows; row++){
        let line = [];
        for(let col = 0; col < cols; col++){
            line.push(0);
        }

        matrix.push(line);
    }

    matrix[x][y] = 1;

    for(let row = 0; row < rows; row++){
        for(let col = 0; col < cols; col++){
            let colDiff = Math.abs(col - y);
            let rowDiff = Math.abs(row - x);

            matrix[row][col] = colDiff > rowDiff ? colDiff + 1 : rowDiff + 1;
        }
    }

    for(let row = 0; row < rows; row++){
        console.log(matrix[row].join(' '));
    }
}

createOrbit([4, 4, 0, 0]);
function ticTacToe(moves){
    const board = [[false, false, false],
                   [false, false, false],
                   [false, false, false]];
    let symbolF = 'X';
    let symbolS = 'O';

    for(let move = 0; move < moves.length; move++){
        let coordinates = moves[move].split(' ');
        let x = coordinates[0];
        let y = coordinates[1];

        let firstWins = checkIfSomeoneWins(board, symbolF);
        
        if(firstWins){
            console.log(`Player ${symbolF} wins!`);
            printMatrix(board);
            break;
        }

        let secondWins = checkIfSomeoneWins(board, symbolS);

        if(secondWins){
            console.log(`Player ${symbolS} wins!`);
            printMatrix(board);
            break;
        }

        let gameEnded = checkIfGameEnded(board);

        if(gameEnded){
            console.log('The game ended! Nobody wins :(');
            printMatrix(board);
            break;
        }

        if(board[x][y] != false){
            console.log('This place is already taken. Please choose another!');
            //printMatrix(board);
            if(symbolF == 'X'){
                symbolF = 'O';
                symbolS = 'X';
            }else{
                symbolF = 'X';
                symbolS = 'O';
            }

            continue;
        }

        if(move % 2 == 0){
            board[x][y] = symbolF;
        }else if(move % 2 != 0){
            board[x][y] = symbolS;
        }
    }

    function checkIfGameEnded(board){
        let count = 0;

        for(let row = 0; row < board.length; row++){
            for(let col = 0; col < board.length; col++){
                if(board[row][col] == false){
                    count++;
                }
            }
        }

        if(count > 0){
            return false;
        }

        return true;
    }

    function checkIfSomeoneWins(board, symbol){
        let repetitions = 0;
        let pDiagonal = 0;
        let sDiagonal = 0;

        for(let row=0; row < board.length; row++){
            for(let col=0; col < board[row].length; col++){
                if(board[row][col] == symbol){
                    repetitions++;
                }

                if(row == col && board[row][col] == symbol){
                    pDiagonal++;
                }
                if(row + col == board.length - 1 && board[row][col] == symbol){
                    sDiagonal++;
                }
            }

            if(repetitions < 3){
                repetitions = 0;
            }else{
                return true;
            }
        }

        if(pDiagonal == 3 || sDiagonal == 3){
            return true;
        }

        return false;
    }

    function printMatrix(board){
        for(let i = 0; i < board.length; i++){
            console.log(board[i].join('\t'));
        }
    }
}

//ticTacToe(['0 1','0 0', '0 2', '2 0', '1 0', '1 1', '1 2', '2 2', '2 1', '0 0']);
ticTacToe(['0 0','0 0', '1 1', '0 1', '1 2', '0 2', '2 2','1 2','2 2', '2 1']);
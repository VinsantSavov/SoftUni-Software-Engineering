function solve() {
    document.querySelector('tfoot tr td > button').addEventListener('click', onCheck);
    document.querySelectorAll('tfoot tr td > button')[1].addEventListener('click', onClear);
    const rows = document.querySelectorAll('table > tbody tr');
    const divResult = document.querySelector('#check');
    const table = document.querySelector('#exercise > table');

    function onCheck(ev){
        const sudoku = [];
        const sRows = [];
        const sCols = [];
        let isCorrect = true;

        for(let row of rows){
            const sudokuRow = [];
            for(let col of row.children){
                const number = col.querySelector('input').value;

                if(Number(number) < 1 || Number(number) > 3){
                    isCorrect = false;
                }
                sudokuRow.push(number);
            }
            sudoku.push(sudokuRow);
        }

        for(let r = 0; r < sudoku.length; r++){
            let colAsString = '';
            for(let c = 0; c < sudoku[r].length; c++){
                colAsString += sudoku[c][r];
            }
            const rowAsString = sudoku[r].reduce((acc, c) => acc += c, '');
            sRows.push(rowAsString);
            sCols.push(colAsString);
        }

        let rCount = 0;
        let cCount = 0;

        for(let r = 0; r < sudoku.length; r++){
            for(let c = 0; c < sudoku[r].length; c++){
                rCount = sRows[r].split('').filter(x => x === sudoku[r][c]).length;
                cCount = sCols[r].split('').filter(x => x === sudoku[c][r]).length

                if(rCount > 1 || cCount > 1){
                    isCorrect = false;
                    break;
                }
            }
        }

        if(isCorrect){
            table.style.borderStyle = 'solid';
            table.style.borderWidth = '2px';
            table.style.borderColor = 'green';
            divResult.children[0].textContent = 'You solve it! Congratulations!';
            divResult.style.color = 'green';
        }
        else{
            table.style.borderStyle = 'solid';
            table.style.borderWidth = '2px';
            table.style.borderColor = 'red';
            divResult.children[0].textContent = 'NOP! You are not done yet...';
            divResult.style.color = 'red';
        }
    }

    function onClear(ev){
        for(let row of rows){
            for(let col of row.children){
                col.children[0].value = '';
            }
        }

        table.style.borderStyle = '';
        divResult.children[0].textContent = '';
    }
}
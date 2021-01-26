function creatingArray(commands){
    let initial = 1;
    let array = [];

    for(let command of commands){
        if(command == 'add'){
            array.push(initial);
        }else if(command == 'remove'){
            array.pop();
        }

        initial++;
    }

    return array.length > 0 ? array.join('\n') : 'Empty';
}
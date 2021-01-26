function orderArray(names){
    let count = 1;
    names = names.sort((a, b) => a.localeCompare(b));

    for(let name of names){
        console.log(`${count}.${name}`);
        count++;
    }
}

orderArray(['John', 'Bob', 'Christina', 'Ema']);

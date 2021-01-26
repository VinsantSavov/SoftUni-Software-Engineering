const evenPositions = (array) =>{
    const result = [];

    for(let i = 0; i < array.length; i+=2){
        result.push(array[i]);
    }

    return result.join(' ');
}
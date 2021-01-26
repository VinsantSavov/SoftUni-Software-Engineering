const orderedArray = (array) => {
    const result = [];

    for(let number of array){
        if(number < 0){
            result.unshift(number);
        }
        else{
            result.push(number);
        }
    }

    return result;
}
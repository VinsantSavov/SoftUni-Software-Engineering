function printElement(array, number){
    let result = [];

    for(let i = 0; i < array.length; i+=number){
        result.push(array[i]);
    }

    return result;
}

console.log(printElement([5, 20, 31,4, 20], 2));
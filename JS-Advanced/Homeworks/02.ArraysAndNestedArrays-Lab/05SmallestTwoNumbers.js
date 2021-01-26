const smallestNumbers = (array) =>{
    const result = array.sort((a, b) => a - b).slice(0, 2);
    return result;
}
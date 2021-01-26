const biggerHalf = (array) => {
    const result = array.sort((a, b) => a - b).slice(Math.floor(array.length / 2), array.length);
    return result;
}

console.log(biggerHalf([4, 7, 2, 5]));
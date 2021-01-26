const numbersSequence = (n, k) => {
    const result = [];
    result.push(1);

    for(let i = 1; i < n; i++){
        let start = result.length - k < 0 ? 0 : i - k;
        let number = result.slice(start, i).reduce((red, currElement) => red + currElement, 0);
        result.push(number);
    }

    return result;
}

console.log(numbersSequence(8, 2));
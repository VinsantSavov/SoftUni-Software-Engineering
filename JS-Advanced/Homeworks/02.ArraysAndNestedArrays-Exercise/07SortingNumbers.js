function sortNumbers(numbers){
    numbers.sort((a, b) => a - b);
    let sorted = [];
    let smallestNums = numbers.slice(0, numbers.length / 2);
    let biggestNums = numbers.slice(numbers.length / 2, numbers.length).reverse();

    for(let i = 0;i < numbers.length / 2;i++){
        if(smallestNums[i] != undefined){
            sorted.push(smallestNums[i]);
        }
        sorted.push(biggestNums[i]);
    }

    return sorted;
}
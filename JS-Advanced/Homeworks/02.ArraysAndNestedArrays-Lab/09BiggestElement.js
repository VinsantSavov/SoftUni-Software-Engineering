const getBiggestNumber = (matrix) => {
    const biggestNums = [];

    for(let row = 0; row < matrix.length; row++){
        let max = matrix[row].reduce((acc, curr) => {
            if(acc > curr){
                return acc;
            }

            return curr;
        });

        biggestNums.push(max);
    }

    const result = biggestNums.reduce((acc, curr) => {
        if(acc > curr){
            return acc;
        }

        return curr;
    });

    return result;
}

console.log(getBiggestNumber([[20, 50, 10], [8, 33, 145]]));
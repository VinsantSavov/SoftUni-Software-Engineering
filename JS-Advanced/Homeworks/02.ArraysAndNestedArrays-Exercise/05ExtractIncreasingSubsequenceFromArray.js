function increasingArray(array){
    let newArray = [];
    let temp = array[0];
    newArray.push(temp);

    for(let i = 0; i < array.length - 1; i++){
        if(temp <= array[i+1]){
            newArray.push(array[i+1]);
            temp = array[i+1];
        }
    }

    return newArray;
}

function withReduce(array){

    function reducer(acc, curr){
        if(acc[acc.length - 1] <= curr){
            acc.push(curr);
        }
        return acc;
    }

    let newArr = []
    
    //newArr.unshift(array[0]);
    newArr = array.reduce(reducer, array[0]);

    return newArr;
}

console.log(withReduce([1,3,8,4,10,12,3,2,24]));
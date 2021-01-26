function largestNum(num1, num2, num3){
    let temp = num1;
    let arr = [num1, num2, num3];

    for(let i = 0; i < arr.length; i++){
        if(arr[i] > temp){
            temp = arr[i];
        }
    }

    return `The largest number is ${temp}.`;
}
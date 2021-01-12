function gcd(firstNumber, secondNumber){
    let left = firstNumber / secondNumber;
    let smallerNum = secondNumber;

    if(Number.isInteger(left)){
        console.log(secondNumber);
    }else{
        while(true){
            smallerNum--;

            if(Number.isInteger(firstNumber/smallerNum) && Number.isInteger(secondNumber/smallerNum)){
                console.log(smallerNum);
                break;
            }
        }
    }
}
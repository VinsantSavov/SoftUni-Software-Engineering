function calculate(input){
    const numbers = [];
    const calculator = {};
    calculator['+'] = function increment(firstNum, secondNum){
        return firstNum + secondNum;
    }
    calculator['-'] = function increment(firstNum, secondNum){
        return firstNum - secondNum;
    }
    calculator['*'] = function increment(firstNum, secondNum){
        return firstNum * secondNum;
    }
    calculator['/'] = function increment(firstNum, secondNum){
        return firstNum / secondNum;
    }

    for(let i = 0; i < input.length; i++){
        if(typeof input[i] == 'number'){
            numbers.push(input[i]);
            continue;
        }

        if(numbers.length < 2){
            console.log('Error: not enough operands!');
            return;
        }

        let second = numbers.pop();
        let first = numbers.pop();
        let number = calculator[input[i]](first, second);

        numbers.push(number);
    }

    if(numbers.length == 1){
        console.log(numbers[0]);
    }
    else{
        console.log('Error: too many operands!');
    }
}

calculate([3,4,'+']);
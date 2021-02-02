function getFibonator(){
    const numbers = [0];

    return getNumber;

    function getNumber(){
        const num = numbers.slice(numbers.length - 2, numbers.length).reduce((acc, curr) => acc += curr, 0);
        if(num == 0){
            numbers.push(1);
            return 1;
        }
        numbers.push(num);
        return num;
    }
}

const fib = getFibonator();
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
function add(a){
    let sum = 0;
    sum += a;
    calc.toString = () => sum;
    
    return calc;

    function calc(num){
        sum += num;
        return calc;
    }
}

console.log(add(1).toString());
function add(a){
    let sum = a;
    return (b) =>{
        return sum += b;
    }
}

console.log(add(1)(6)(-3));
function differentOperations(args){
    let sum = 0;
    let sumOfInversedValues = 0;
    let concat = '';

    for(let i = 0; i < args.length; i++){
        sum += args[i];
        sumOfInversedValues += 1 / args[i];
        concat += args[i].toString();
    }

    console.log(sum);
    console.log(sumOfInversedValues);
    console.log(concat);
}

differentOperations([1, 2, 3]);
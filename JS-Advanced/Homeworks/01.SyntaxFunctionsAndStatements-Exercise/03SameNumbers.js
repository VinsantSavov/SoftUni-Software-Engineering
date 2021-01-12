function equalNumbers(number){
    var string = number.toString();
    let areEqual = true;
    let sum = 0;

    for(let i = 0; i < string.length - 1; i++){
        if(string[i] != string[i+1]){
            areEqual = false;
        }
        sum += parseInt(string[i]);
    }
    sum += parseInt(string[string.length - 1]);

    console.log(areEqual);
    console.log(sum);
}
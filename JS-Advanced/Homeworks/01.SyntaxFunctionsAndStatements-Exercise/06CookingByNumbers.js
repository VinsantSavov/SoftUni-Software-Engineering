function printNumbers(number, ...args){
    for(let i = 0; i < args.length; i++){
        if(args[i] == 'chop'){
            number = number / 2;
        }else if(args[i] == 'dice'){
            number = Math.sqrt(number);
        }else if(args[i] == 'spice'){
            number++;
        }else if(args[i] == 'bake'){
            number *= 3;
        }else if(args[i] == 'fillet'){
            number = number - number * 0.2;
        }

        console.log(number);
    }
}
function solution(){
    const elements = {
        protein: 0,
        carbohydrates: 0,
        fat: 0,
        flavours: 0,
    };

    const recipes = {
        apple: (quantity) => {
            const carbs = quantity * 1;
            const flav = quantity * 2;
            let error = '';

            if(elements.carbohydrates >= carbs){
                if(elements.flavours >= flav){
                    elements.carbohydrates -= carbs;
                    elements.flavours -= flav;
                    return 'Success';
                }
                error = 'flavour';
            }
            else{
                error = 'carbohydrate';
            }

            return `Error: not enough ${error} in stock`;
        },
        lemonade: (quantity) => {
            const carbs = quantity * 10;
            const flav = quantity * 20;
            let error = '';

            if(elements.carbohydrates >= carbs){
                if(elements.flavours >= flav){
                    elements.carbohydrates -= carbs;
                    elements.flavours -= flav;
                    return 'Success';
                }
                error = 'flavour';
            }
            else{
                error = 'carbohydrate';
            }

            return `Error: not enough ${error} in stock`;
        },
        burger: (quantity) => {
            const carbs = quantity * 5;
            const flav = quantity * 3;
            const fat = quantity * 7;
            let error = '';

            if(elements.carbohydrates >= carbs){
                if(elements.flavours >= flav){
                    if(elements.fat >= fat){
                        elements.carbohydrates -= carbs;
                        elements.flavours -= flav;
                        elements.fat -= fat;
                        return 'Success';
                    }
                    error = 'fat';
                }
                else{
                    error = 'flavour';
                }
            }
            else{
                error = 'carbohydrate';
            }

            return `Error: not enough ${error} in stock`;
        },
        eggs: (quantity) => {
            const protein = quantity * 5;
            const flav = quantity * 1;
            const fat = quantity * 1;
            let error = '';

            if(elements.protein >= protein){
                if(elements.flavours >= flav){
                    if(elements.fat >= fat){
                        elements.protein -= protein;
                        elements.flavours -= flav;
                        elements.fat -= fat;
                        return 'Success';
                    }
                    error = 'fat';
                }
                else{
                    error = 'flavour';
                }
            }
            else{
                error = 'protein';
            }

            return `Error: not enough ${error} in stock`;
        },
        turkey: (quantity) => {
            const protein = quantity * 10;
            const carb = quantity * 10;
            const flav = quantity * 10;
            const fat = quantity * 10;
            let error = '';

            if(elements.protein >= protein){
                if(elements.carbohydrates >= carb){
                    if(elements.flavours >= flav){
                        if(elements.fat >= fat){
                            elements.protein -= protein;
                            elements.carbohydrates -= carb;
                            elements.flavours -= flav;
                            elements.fat -= fat;
                            return 'Success';
                        }
                        error = 'fat';
                    }
                    else{
                        error = 'flavour';
                    }
                }
                else{
                    error = 'carbohydrate'
                }
            }
            else{
                error = 'protein';
            }

            return `Error: not enough ${error} in stock`;
        }
    }

    return cook;

    function cook(input){
        const args = input.split(' ');

        if(args[0] == 'restock'){
            const element = args[1] == 'carbohydrate' || args[1] == 'flavour'? args[1] + 's' : args[1];
            elements[element] += Number(args[2]);

            return 'Success';

        }else if(args[0] == 'prepare'){
            const recipe = args[1];
            const quantity = Number(args[2]);

            const result = recipes[recipe](quantity);
            return result;

        }else if(args[0] == 'report'){
            return `protein=${elements.protein} carbohydrate=${elements.carbohydrates} fat=${elements.fat} flavour=${elements.flavours}`;
        }
    }
}

let manager = solution();
console.log(manager("restock carbohydrate 10"));  // Success
console.log(manager("restock flavour 10"));  
console.log(manager("prepare apple 1"));  // Success
console.log(manager("restock fat 10"));  
console.log(manager("prepare burger 1"));  // Success
console.log(manager("report"));  

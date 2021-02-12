function carRegister(input){
    const register = new Map();

    for(let info of input){
        const args = info.split(' | ');
        const brand = args[0];
        const model = args[1];
        const producedCars = Number(args[2]);

        if(!register.has(brand)){
            register.set(brand, {[model]: 0});
        }

        if(register.get(brand)[model] == undefined){
            register.get(brand)[model] = 0;
        }

        register.get(brand)[model] = register.get(brand)[model] + producedCars;
    }

    for(let [key, value] of register){
        console.log(key);
        
        for(let model in value){
            console.log(`###${model} -> ${value[model]}`);
        }
    }
}

carRegister(['Audi | Q7 | 1000',
'Audi | Q6 | 100',
'BMW | X5 | 1000',
'BMW | X6 | 100',
'Citroen | C4 | 123',
'Volga | GAZ-24 | 1000000',
'Lada | Niva | 1000000',
'Lada | Jigula | 1000000',
'Citroen | C4 | 22',
'Citroen | C5 | 10']
);
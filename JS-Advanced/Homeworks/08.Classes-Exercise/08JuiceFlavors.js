function createJuice(input){
    const juices = new Map();
    const bottles = new Map();

    for(let info of input){
        const args = info.split(' => ');
        const name = args[0];

        if(!juices.has(name)){
            juices.set(name, 0);
        }

        let quantity = juices.get(name) + Number(args[1]);
        juices.set(name, quantity);

        if(quantity >= 1000){
            let count = Math.floor(quantity / 1000);
            quantity -= count * 1000;
            juices.set(name, quantity);

            if(!bottles.has(name)){
                bottles.set(name, 0);
            }

            let c = bottles.get(name) + count;
            bottles.set(name, c);
        }
    }

    for(let [key, value] of bottles){
        console.log(`${key} => ${value}`);
    }
}

createJuice(['Orange => 2000',
'Peach => 1432',
'Banana => 450',
'Peach => 600',
'Strawberry => 549']
);
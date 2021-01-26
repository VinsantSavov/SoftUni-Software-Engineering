function createTownRegister(array){
    const townRegister = {};

    for(let element of array){
        const info = element.split(' <-> ');

        if(townRegister[info[0]] == undefined){
            townRegister[info[0]] = 0
        }

        townRegister[info[0]] += Number(info[1]);
    }

    for(let [key, value] of Object.entries(townRegister)){
        console.log(`${key} : ${value}`);
    }
}

console.log(createTownRegister(['Sofia <-> 1200000']));

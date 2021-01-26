function herosRegister(heros){
    const register = [];

    for(let i = 0; i < heros.length; i++){
        let info = heros[i].split(' / ');
        let name = info[0];
        let level = Number(info[1]);
        let weapons = info[2] == null ? [] : info[2].split(', ');

        const hero = {name: null, level: 0, items: []};
        hero.name = name;
        hero.level = level;

        for(let weapon of weapons){
            hero.items.push(weapon);
        }

        register.push(hero);
    }

    return JSON.stringify(register);
}

console.log(herosRegister(['Isaac / 25 / ']));
function solve(...input){
    const words = [];
    const counts = [];

    for(let word of input){
        words.push({[typeof word]: word});
        const doesExist = counts.some(c => Object.keys(c)[0] == typeof word);

        if(!doesExist || counts.length == 0){
            counts.push({[typeof word]: 0});
        }

        const obj = counts.find(w => Object.keys(w)[0] == typeof word);
        obj[typeof word]++;
    }

    counts.sort((fw, sw) => sw[Object.keys(sw)[0]] - fw[Object.keys(fw)[0]]);

    for(let item of words){
        const key = Object.keys(item)[0];
        console.log(`${key}: ${item[key]}`);
    }

    for(let item of counts){
        const key = Object.keys(item)[0];
        console.log(`${key} = ${item[key]}`);
    }
}

solve({ name: 'bob'}, 3.333, 9.999);
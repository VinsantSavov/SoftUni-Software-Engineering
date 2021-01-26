function townsAsJSON(input){
    const result = [];

    for(let i = 1; i < input.length; i++){
        let line = input[i];
        let [town, latitude, longitude] = line.split('|').filter(n => n != '' && n != ' ').map(n => n.trim());
        
        const ob = {};
        ob.Town = town;
        ob.Latitude = Number(Number(latitude).toFixed(2));
        ob.Longitude = Number(Number(longitude).toFixed(2));

        result.push(ob);
    }

    return JSON.stringify(result);
}

console.log(townsAsJSON(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']));
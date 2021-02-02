function solve(area, vol, input){
    const array = JSON.parse(input);
    const result = [];

    for(let info of array){
        let areaObj = area.call(info);
        let volumeObj = vol.call(info);

        result.push({area: areaObj, volume: volumeObj});
    }

    return result;
}

function area() {
    return Math.abs(this.x * this.y);
};

function vol() {
    return Math.abs(this.x * this.y * this.z);
};


console.log(solve(area, vol, `[
    {"x":"1","y":"2","z":"10"},
    {"x":"7","y":"7","z":"10"},
    {"x":"5","y":"2","z":"10"}
    ]`
    ));
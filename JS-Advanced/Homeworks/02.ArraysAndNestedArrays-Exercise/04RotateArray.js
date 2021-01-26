function rotateArray(array, count){
    for(let i = 0; i < count; i++){
        let temp = array.pop();
        array.unshift(temp);
    }

    return array.join(' ');
}

console.log(rotateArray([1, 2, 3, 4], 2));
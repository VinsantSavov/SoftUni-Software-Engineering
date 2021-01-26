function createCalorieObject(array){
    const foods = {};

    for(let i = 0; i < array.length; i+=2){
        let food = array[i];
        let calories = Number(array[i+1]);

        foods[food] = calories;
    }

    return foods;
}
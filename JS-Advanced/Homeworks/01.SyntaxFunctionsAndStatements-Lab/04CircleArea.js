function circleArea(input){
    let type = typeof(input);
    let area = 0;

    if(type == 'number'){
        area = Math.PI * input * input;
        return area.toFixed(2);
    }
    else{
        return `We can not calculate the circle area, because we receive a ${type}.`
    }
}
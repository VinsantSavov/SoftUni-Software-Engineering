function rectangle(width, height, color){
    const rect = {};
    rect.width = width;
    rect.height = height;
    rect.color = color[0].toUpperCase() + color.slice(1);
    rect.calcArea = function calcArea(){
        return width * height;
    }

    return rect;
}

let rect = rectangle(4, 5, 'red');
console.log(rect.width);
console.log(rect.height);
console.log(rect.color);
console.log(rect.calcArea());
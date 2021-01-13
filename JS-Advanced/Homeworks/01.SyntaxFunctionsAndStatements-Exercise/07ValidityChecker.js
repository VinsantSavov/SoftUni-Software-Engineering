function validCoordinateSystem(x1, y1, x2, y2){
    let firstPointDistance = Math.sqrt(x1 * x1 + y1 * y1);
    let secondPointdistance = Math.sqrt(x2 * x2 + y2 * y2);

    if(firstPointDistance % 1 == 0){
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    }else{
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }
    if(secondPointdistance % 1 == 0){
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    }else{
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }

    let a = Math.abs(x1 - x2);
    let b = Math.abs(y1 - y2);
    let distanceBetweenPoints = Math.sqrt(a * a + b * b);

    if(distanceBetweenPoints % 1 == 0){
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    }else{
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }
}
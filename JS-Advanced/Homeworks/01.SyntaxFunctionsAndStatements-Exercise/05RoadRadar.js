function speedLimit(speed, area){
    let difference = 0;

    if(area == 'motorway'){
        difference = 130 - speed;

        if(difference >= 0){
            console.log(`Driving ${speed} km/h in a 130 zone`);
        }else{
            if(Math.abs(difference) <= 20){
                console.log(`The speed is ${Math.abs(difference)} km/h faster than the allowed speed of 130 - speeding`);
            }else if(Math.abs(difference) <= 40){
                console.log(`The speed is ${Math.abs(difference)} km/h faster than the allowed speed of 130 - excessive speeding`);
            }else{
                console.log(`The speed is ${Math.abs(difference)} km/h faster than the allowed speed of 130 - reckless driving`);
            }
        }
    }else if(area == 'interstate'){
        difference = 90 - speed;

        if(difference >= 0){
            console.log(`Driving ${speed} km/h in a 90 zone`);
        }else{
            if(Math.abs(difference) <= 20){
                console.log(`The speed is ${Math.abs(difference)} km/h faster than the allowed speed of 90 - speeding`);
            }else if(Math.abs(difference) <= 40){
                console.log(`The speed is ${Math.abs(difference)} km/h faster than the allowed speed of 90 - excessive speeding`);
            }else{
                console.log(`The speed is ${Math.abs(difference)} km/h faster than the allowed speed of 90 - reckless driving`);
            }
        }
    }else if(area == 'city'){
        difference = 50 - speed;

        if(difference >= 0){
            console.log(`Driving ${speed} km/h in a 50 zone`);
        }else{
            if(Math.abs(difference) <= 20){
                console.log(`The speed is ${Math.abs(difference)} km/h faster than the allowed speed of 50 - speeding`);
            }else if(Math.abs(difference) <= 40){
                console.log(`The speed is ${Math.abs(difference)} km/h faster than the allowed speed of 50 - excessive speeding`);
            }else{
                console.log(`The speed is ${Math.abs(difference)} km/h faster than the allowed speed of 50 - reckless driving`);
            }
        }
    }else if(area == 'residential'){
        difference = 20 - speed;

        if(difference >= 0){
            console.log(`Driving ${speed} km/h in a 20 zone`);
        }else{
            if(Math.abs(difference) <= 20){
                console.log(`The speed is ${Math.abs(difference)} km/h faster than the allowed speed of 20 - speeding`);
            }else if(Math.abs(difference) <= 40){
                console.log(`The speed is ${Math.abs(difference)} km/h faster than the allowed speed of 20 - excessive speeding`);
            }else{
                console.log(`The speed is ${Math.abs(difference)} km/h faster than the allowed speed of 20 - reckless driving`);
            }
        }
    }
}
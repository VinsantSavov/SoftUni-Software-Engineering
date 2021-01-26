function carFactory(requirements){
    const car = {
        model: null,
        engine: {
            power: 0,
            volume: 0,
        },
        carriage: {
            type: null,
            color: null,
        },
        wheels: [],
    };
    let wheelSize = 0;

    car.model = requirements.model;

    if(requirements.power <= 90){
        car.engine.power = 90;
        car.engine.volume = 1800;
    }
    else if(requirements.power > 90 && requirements.power <= 120){
        car.engine.power = 120;
        car.engine.volume = 2400;
    }
    else if(requirements.power > 120){
        car.engine.power = 200;
        car.engine.volume = 3500;
    }

    if(requirements.carriage == 'hatchback'){
        car.carriage.type = requirements.carriage;
    }
    else if(requirements.carriage == 'coupe'){
        car.carriage.type = requirements.carriage;
    }

    car.carriage.color = requirements.color;

    if(requirements.wheelsize % 2 == 0){
        wheelSize = requirements.wheelsize - 1;
    }
    else{
        wheelSize = requirements.wheelsize;
    }

    for(let i =0; i < 4; i++){
        car.wheels.push(wheelSize);
    }

    return car;
}

console.log(carFactory({model: 'VW Golf II', power: 90, color: 'blue', carriage: 'hatchback', wheelsize: 14}));
class Parking{
    constructor(capacity){
        this.capacity = capacity;
        this.vehicles = [];
    }

    addCar(carModel, carNumber){
        if(this.vehicles.length >= this.capacity){
            throw new Error('Not enough parking space.');
        }

        this.vehicles.push({
            carModel,
            carNumber,
            payed: false,
        });

        return `The ${carModel}, with a registration number ${carNumber}, parked.`;
    }

    removeCar(carNumber){
        const car = this.vehicles.find(c => c.carNumber == carNumber);

        if(car == null){
            throw new Error("The car, you're looking for, is not found.");
        }

        if(car.payed == false){
            throw new Error(`${car.carNumber} needs to pay before leaving the parking lot.`);
        }

        let index = this.vehicles.indexOf(car);
        this.vehicles.splice(index, 1);

        return `${carNumber} left the parking lot.`;
    }

    pay(carNumber){
        const car = this.vehicles.find(c => c.carNumber == carNumber);

        if(car == null){
            throw new Error(`${carNumber} is not in the parking lot.`);
        }

        if(car.payed){
            throw new Error(`${carNumber}'s driver has already payed his ticket.`);
        }

        car.payed = true;

        return `${carNumber}'s driver successfully payed for his stay.`;
    }

    getStatistics(carNumber){
        let result = '';

        if(carNumber == null){
            result += `The Parking Lot has ${this.capacity - this.vehicles.length} empty spots left.\n`;
            this.vehicles.sort((a, b) => a.carModel.localeCompare(b.carModel));

            this.vehicles.forEach(v => {
                result += `${v.carModel} == ${v.carNumber} - `;
                result += v.payed ? 'Has payed\n' : 'Not payed\n';
                return result;
            });

            return result.trim();
        }

        const car = this.vehicles.find(c => c.carNumber == carNumber);
        let res = `${car.carModel} == ${car.carNumber} - `;
        res += car.payed ? 'Has payed' : 'Not payed';
        return  res;
    }
}

const parking = new Parking(12);

console.log(parking.addCar('Volvo t600', 'TX3691CA'));
console.log(parking.getStatistics('TX3691CA'));

console.log(parking.pay('TX3691CA'));
console.log(parking.removeCar('TX3691CA'));
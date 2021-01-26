function cityTaxes(name, population, treasury){
    const city = { 
        taxRate: 10,
    };

    city.name = name;
    city.population = population;
    city.treasury = treasury;

    city.collectTaxes = collectTaxes;
    city.applyGrowth = applyGrowth;
    city.applyRecession = applyRecession;

    function applyGrowth(percentage){
        this.population += Math.ceil(this.population * percentage / 100);
    }

    function applyRecession(percentage){
        this.treasury -= Math.ceil(this.treasury * percentage / 100);
    }

    function collectTaxes(){
        this.treasury += this.population * this.taxRate;
    }

    return city;
}

const city =
cityTaxes('Tortuga',
7000,
15000);
console.log(city);
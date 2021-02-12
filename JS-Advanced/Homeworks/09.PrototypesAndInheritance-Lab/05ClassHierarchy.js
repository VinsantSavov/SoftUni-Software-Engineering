function classCreator(){
    class Figure{
        constructor(){
            this.units = 'cm';
            this.conv = {
                'cm cm': (val) => val,
                'm m': (val) => val,
                'mm mm': (val) => val,
                'cm m': (val) => val / 100,
                'cm mm': (val) => val * 10,
                'mm cm': (val) => val / 10,
                'm cm': (val) => val * 100,
                'm mm': (val) => val * 1000,
                'mm m': (val) => val / 1000,
            };
        }

        get units(){
            return this._units;
        }

        set units(value){
            const vals = ['m', 'cm', 'mm'];

            if(vals.includes(value)){
                this._units = value;
            }
        }

        get area(){
        }

        changeUnits(newUnits){
            this.units = newUnits;
        }

        toString(){
            return `Figures units: ${this.units}`;
        }
    }

    class Circle extends Figure{
        constructor(radius){
            super();
            this.radius = radius;
        }

        changeUnits(newUnits){
            this.radius = this.conv[`${this.units} ${newUnits}`](this.radius);

            this.units = newUnits;
        }

        get area(){
            return Math.PI * this.radius * this.radius;
        }

        toString(){
            return `Figures units: ${this.units} Area: ${this.area} - radius: ${this.radius}`;
        }
    }

    class Rectangle extends Figure{
        constructor(width, height, units){
            super();
            this.width = width;
            this.height = height;
            this.changeUnits(units);
        }

        changeUnits(newUnits){
            this.width = this.conv[`${this.units} ${newUnits}`](this.width);
            this.height = this.conv[`${this.units} ${newUnits}`](this.height);

            this.units = newUnits;
        }

        get area(){
            return this.width * this.height;
        }

        toString(){
            return `Figures units: ${this.units} Area: ${this.area} - width: ${this.width}, height: ${this.height}`;
        }
    }

    /*let c = new Circle(5);
    console.log(c.area); // 78.53981633974483
    console.log(c.toString()); // Figures units: cm Area: 78.53981633974483 - radius: 5
    
    let r = new Rectangle(3, 4, 'mm');
    console.log(r.area); // 1200 
    console.log(r.toString()); //Figures units: mm Area: 1200 - width: 30, height: 40
    
    r.changeUnits('cm');
    console.log(r.area); // 12
    console.log(r.toString()); // Figures units: cm Area: 12 - width: 3, height: 4
    
    c.changeUnits('mm');
    console.log(c.area); // 7853.981633974483
    console.log(c.toString()) // Figures units: mm Area: 7853.981633974483 - radius: 50*/

    return {Figure, Circle, Rectangle};
}

classCreator();
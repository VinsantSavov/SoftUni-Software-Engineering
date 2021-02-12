class Circle{
    constructor(r){
        this.r = r;
    }

    get radius(){
        return this.r;
    }

    set radius(value){
        this.r = value;
    }

    get diameter(){
        return this.r * 2;
    }

    set diameter(value){
        this.r = value / 2;
    }

    get area(){
        return Math.PI * Math.pow(this.r, 2);
    }
}

let c = new Circle(2);
console.log(c.diameter);
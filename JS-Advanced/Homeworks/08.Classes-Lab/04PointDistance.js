class Point{
    constructor(x, y){
        this.x = x;
        this.y = y;
    }

    /*get x(){
        return this._x;
    }

    set x(value){
        this._x = value;
    }

    get y(){
        return this._y;
    }

    set y(value){
        this._y = value;
    }*/

    static distance(a, b){
        if(a instanceof Point == false || b instanceof Point == false){
            throw new Error('Invalid input!');
        }
        let sideA = a.x - b.x;
        let sideB =  a.y - b.y;

        return Math.sqrt(Math.pow(sideA, 2) + Math.pow(sideB, 2));
    }
}

let p1 = new Point(5, 5);
let p2 = new Point(9, 8);
console.log(Point.distance(p1, p2));
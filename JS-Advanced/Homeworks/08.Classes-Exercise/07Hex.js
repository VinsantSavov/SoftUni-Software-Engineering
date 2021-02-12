class Hex{
    constructor(number){
        this.number = number;
    }

    valueOf(){
        return this.number;
    }

    toString(){
        return '0x' + this.number.toString(16).toUpperCase();
    }

    plus(value){
        if(value instanceof Hex){
            return new Hex(this.number + value.valueOf());
        }else if(typeof value == 'number'){
            return new Hex(this.number + value);
        }
    }

    minus(value){
        if(value instanceof Hex){
            return new Hex(this.number - value.valueOf());
        }else if(typeof value == 'number'){
            return new Hex(this.number - value);
        }
    }

    parse(value){
        return parseInt(value, 10);
    }
}

let FF = new Hex(255);
console.log(FF.toString());
FF.valueOf() + 1 == 256;
let a = new Hex(10);
let b = new Hex(5);
console.log(a.plus(b).toString());
console.log(a.plus(b).toString()==='0xF');

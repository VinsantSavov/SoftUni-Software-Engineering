class MyArray extends Array{
    constructor(...params){
        super(...params);
    }

    last(){
        return this[this.length - 1];
    }

    skip(n){
        return this.slice(n, this.length);
    }

    take(n){
        return this.slice(0, n);
    }

    sum(){
        return this.reduce((acc, curr) => acc += curr, 0);
    }

    average(){
        return this.reduce((acc, curr) => acc += curr, 0) / this.length;
    }
}

(function solve(){
    Array.prototype.last = function () {return this[this.length - 1]};
    Array.prototype.skip = function (n){
        if(n < 0){
            n = 0;
        }else if(n > this.length - 1){
            n = this.length - 1;
        }

        return this.slice(n, this.length);
    };
    Array.prototype.take = function (m){
        if(m < 0){
            m = 0;
        }else if(m > this.length - 1){
            m = this.length - 1;
        }

        return this.slice(0, m);
    };
    Array.prototype.sum = function (){ return this.reduce((acc, curr) => acc += curr, 0)};
    Array.prototype.average = function (){ return this.reduce((acc, curr) => acc += curr, 0) / this.length};
}());
(function solve(){
    String.prototype.ensureStart = function (str) {
        if(!this.startsWith(str)){
            let result = str.concat(this);
            return result;
        }

        return this.toString();
    }

    String.prototype.ensureEnd = function (str) {
        if(!this.includes(str)){
            return this + str;
        }

        return this.toString();
    }

    String.prototype.isEmpty = function () {
        if(this.length > 0){
            return false;
        }

        return true;
    }

    String.prototype.truncate = function (n){
        if(this.length <= n){
            return this.toString();
        }

        if(n < 4){
            return '.'.repeat(n);
        }

        if(this.includes(' ')){
            let result = '';
            const args = this.split(' ');

            for(let word of args){
                if(result.length + word.length + 3 <= n){
                    result += word + ' ';
                }else{
                    break;
                }
            }
            
            return result.trim() + '...';
        }

        return this.slice(0, n - 3) + '...';
    }

    String.format = function(string, ...params){
        let result = string;

        params.map((v, i) => {
            if(result.includes(`{${i}}`)){
                result = result.replace(`{${i}}`, v);
            }
        });

        return result;
    }
}())

let str = 'the quick brown fox jumps over the lazy dog';
str = str.truncate(10);
console.log(str);
/*let str = 'my string';
str = str.ensureStart('my');
str = str.ensureStart('hello ');
str = str.truncate(16);
str = str.truncate(14);
str = str.truncate(8);
str = str.truncate(4);
str = str.truncate(2);
str = String.format('The {0} {1} fox',
  'quick', 'brown');
str = String.format('jumps {0} {1}',
  'dog');*/

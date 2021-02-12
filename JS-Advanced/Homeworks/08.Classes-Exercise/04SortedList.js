class SortedList{
    constructor(){
        this.numbers = [];
        this.size = this.numbers.length;
    }

    add(element){
        this.numbers.push(element);
        this.numbers.sort((a, b) => a - b);
        this.size = this.numbers.length;
    }

    remove(index){
        if(index < 0 || index >= this.numbers.length){
            throw new Error('Invalid index!');
        }

        this.numbers.splice(index, 1);
        this.size = this.numbers.length;
    }

    get(index){
        if(index < 0 || index >= this.numbers.length){
            throw new Error('Invalid index!');
        }

        return this.numbers.find((n, i) => i == index);
    }
}

let list = new SortedList();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1)); 
list.remove(1);
console.log(list.get(1));
console.log(list.size)

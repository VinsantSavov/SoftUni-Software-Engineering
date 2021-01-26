function createSortedList(){
    const list = {};
    list.arr = []
    list.add = function add(element){
        this.arr.push(element);
        this.arr.sort((a, b) => a - b);
        this.size++;
    }
    list.remove = function remove(index){
        if(this.arr[index] != undefined){
            this.arr.splice(index, 1);
            this.arr.sort((a, b) => a - b);
            this.size--;
        }
    }
    list.get = function get(index){
        if(index >= 0 && index < this.arr.length){
            return this.arr[index];
        }
    }
    list.size = list.arr.length;

    return list;
}

let list = createSortedList();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));
console.log(list.size);
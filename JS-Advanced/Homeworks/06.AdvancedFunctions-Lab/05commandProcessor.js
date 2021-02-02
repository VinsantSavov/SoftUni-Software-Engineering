function solution(){
    let text = '';

    return {
        append: append,
        removeStart: removeStart,
        removeEnd: removeEnd,
        print: print,
    };

    function append(string){
        text += string;
    }

    function removeStart(n){
        text = text.substring(n);
    }

    function removeEnd(n){
        text = text.substring(0, text.length - n);
    }

    function print(){
        console.log(text);
    }
}

let firstZeroTest = solution();

firstZeroTest.append('hello');
firstZeroTest.append('again');
firstZeroTest.print();

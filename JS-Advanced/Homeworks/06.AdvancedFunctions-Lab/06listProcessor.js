function solve(input){
    let data = [];

    const func = {
        add: add,
        remove: remove,
        print: print,
    };

    input.map(item => {
        const args = item.split(' ');
        func[args[0]](args[1]);
    })

    function add(string){
        data.push(string);
    }

    function remove(string){
        data = data.filter(i => i != string);
    }

    function print(){
        console.log(data.join(','));
    }
}

solve(['add hello', 'add again', 'remove hello', 'add again', 'print']);
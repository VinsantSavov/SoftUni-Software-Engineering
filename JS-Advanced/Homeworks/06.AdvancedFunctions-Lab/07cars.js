function solve(input){
    const data = [];

    /*const obj = {
        create: create,
        inherits: inherits,
        set: set,
        print: print,
    };*/

    for(let i of input){
        const args = i.split(' ');

        if(args.some(el => el == 'inherit')){
            inherits(args[1], args[3]);
        }else if(args.some(el => el == 'create')){
            create(args[1]);
        }else if(args.some(el => el == 'set')){
            set(args[1], args[2], args[3]);
        }else if(args.some(el => el == 'print')){
            print(args[1]);
        }
    }

    /*input.map(i => {
        const args = i.split(' ');

        if(args.some('inherit')){
            inherits(args[1], args[3]);
        }else if(args.some('create')){
            create(args[1]);
        }else if(args.some('set')){
            set(args[1], args[2], args[3]);
        }else if(args.some('print')){
            print(args[1]);
        }
    });*/

    function create(name){
        data.push({[name]: {}});
    }

    function inherits(name, parent){
        data.push({
            [name]: data[parent],
        });
    }

    function set(name, key, value){
        //if(data[name] != undefined){
            data[name][key] = value;
        //}
    }

    function print(name){
        const keys = Object.keys(data[name]);
        keys.map(k => {
            console.log(`${k}:${data[name][k]}`);
        })
    }
}

solve(['create c1',
'create c2 inherit c1',
'set c1 color red',
'set c2 model new',
'print c1',
'print c2']
);
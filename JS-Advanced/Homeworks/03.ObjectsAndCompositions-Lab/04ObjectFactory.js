function factory(library, orders){
    const result = [];

    for(let order of orders){
        const createdOject = {};

        for(let [key, value] of Object.entries(order)){
            if(key == 'template'){
                createdOject.name = value.name;
            }
            else{
                for(let func of value){
                    createdOject[func] = library[func];
                }
            }
        }

        result.push(createdOject);
    }

    return result;
}

const library = {
    print: function () {
    console.log(`${this.name} is printing a page`);
    },
    scan: function () {
    console.log(`${this.name} is scanning a document`);
    },
    play: function (artist, track) {
    console.log(`${this.name} is playing &#39;${track}&#39; by ${artist}`);
    },
    };

    const orders = [
    {
    template: { name: 'ACME Printer'},
    parts: ['print']
    },
    {
    template: { name: 'Initech Scanner'},
    parts: ['scan']
    },
    {
    template: { name: 'ComTron Copier'},
    parts: ['scan', 'print']
    },
    {
    template: { name: 'BoomBox Stereo}'},
    parts: ['play']
    },
    ];

    const products = factory(library, orders);
    console.log(products);
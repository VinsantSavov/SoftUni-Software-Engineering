function printSortedProducts(input){
    const names = [];
    const products = {};

    for(let i = 0; i < input.length; i++){
        let [product, price] = input[i].split(' : ');
        price = Number(price);

        products[product] = price;
        names.push(product);
    }

    names.sort((a, b) => a.localeCompare(b));

    let category = names[0].slice(0, 1);
    console.log(category);

    for(let i = 0; i < names.length - 1; i++){
        console.log(  `  ${names[i]}: ${products[names[i]]}`);

        if(names[i + 1].slice(0, 1) != category){
            category = names[i + 1].slice(0, 1);
            console.log(category);
        }
    }

    console.log(  `  ${names[names.length - 1]}: ${products[names[names.length - 1]]}`)
}

printSortedProducts(['Apricot : 20', 'Fridge : 1500', 'TV : 1499', 'Apple : 1.25']);
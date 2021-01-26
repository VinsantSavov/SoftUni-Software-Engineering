function printLowestPrices(array){
    const products = {};

    for(let i = 0; i < array.length; i++){
        let [town, product, price] = array[i].split(' | ');
        price = Number(price);

        if(products[product] == undefined){
            products[product] = {};
            products[product].price = price;
            products[product].town = town;
        }else{
            if(products[product].price > price){
                products[product].price = price;
                products[product].town = town;
            }
        }
    }

    for(let item in products){
        console.log(`${item} -> ${products[item].price} (${products[item].town})`);
    }
}

printLowestPrices(['Sample Town | Sample Product | 1000']);
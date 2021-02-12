function result(){
    const myObj = {
        extend: function(template){
            for(let pName of Object.getOwnPropertyNames(template)){
                let descr = Object.getOwnPropertyDescriptor(template, pName);
                let proto = Object.getPrototypeOf(myObj);
    
                if(typeof descr.value == 'function'){
                    proto[pName] = descr.value;
                }else{
                    myObj[pName] = descr.value;
                }
            }
        }
    }

    return myObj;
}


const template = {
    extensionMethod: function () {},
    extensionProperty: 'someString'
}

const mo = result();
mo.extend(template)

console.log(mo);
console.log(Object.getPrototypeOf(mo));
  
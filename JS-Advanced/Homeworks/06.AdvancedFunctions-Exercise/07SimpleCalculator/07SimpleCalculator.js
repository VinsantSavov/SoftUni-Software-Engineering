function create(){
    let firstSelector = {};
    let secondSelector = {};
    let resultSelector = {};

    const object = {
        init: (selector1, selector2, result) =>{
            firstSelector = document.querySelector(selector1);
            secondSelector = document.querySelector(selector2);
            resultSelector = document.querySelector(result);
        },

        add: () => {
            resultSelector.value = Number(firstSelector.value) + Number(secondSelector.value);
        },

        subtract: () => {
            resultSelector.value = Number(firstSelector.value) - Number(secondSelector.value);
        }
    };

    return object;
}

function test(){
    const object = create();
    object.init('#num1', '#num2', '#result');
    //object.add();
    object.subtract();
}

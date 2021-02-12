class Textbox {
    constructor(selector, regex){
        this._elements = Array.from(document.querySelectorAll(`${selector}`));

        this.elements[0].addEventListener('input', (e) => {
            this.value = e.target.value;
            console.log(this.isValid());
        });
        this._invalidSymbols = regex;
    }

    get value(){
        return this._value;
    }

    set value(val){
        this._value = val;
    }

    get elements(){
        return this._elements;
    }

    isValid(){
        if(this._invalidSymbols.test(this.value)){
            return false;
        }else{
            return true;
        }
    }
}

let textbox = new Textbox(".textbox",/[^a-zA-Z0-9]/);
let inputs = $('.textbox');

inputs.on('input',function(){console.log(textbox.value);});

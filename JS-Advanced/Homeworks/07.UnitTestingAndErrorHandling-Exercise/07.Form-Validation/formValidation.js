function validate() {
    const form = document.getElementById('registerForm');
    
    const inputs = Array.from(form.querySelectorAll('#userInfo input'));
    const companyInfo = document.getElementById('companyInfo');
    const divValid = document.getElementById('valid');
    document.getElementById('submit').addEventListener('click', onClick);
    inputs[inputs.length - 1].addEventListener('change', onChange);

    const regexes = {
        username: /^[\w\d]{3,20}$/,
        email: /^[a-z]+@[a-z]+\.[a-z]+$/,
        password: /^[\w]{5,15}$/,
        'confirm-password': /^[\w]{5,15}$/,
    }

    function onClick(ev){
        compInput = companyInfo.querySelector('#companyNumber');
        ev.preventDefault();
        
        for(let inp of inputs.slice(0, inputs.length - 1)){
            if(regexes[inp.id].test(inp.value)){
                inp.removeAttribute('style');
                inp.style.setProperty('border', 'none');
            }else{
                inp.removeAttribute('style');
                inp.style.setProperty('border-color', 'red');
            }
        }

        const passValue = inputs[inputs.length - 3].value;
        const confirmPassValue = inputs[inputs.length - 2].value;

        if(confirmPassValue == passValue && inputs[inputs.length - 2].style['border'] == 'none'){
            inputs[inputs.length - 2].removeAttribute('style');
            inputs[inputs.length - 2].style.setProperty('border', 'none');
            inputs[inputs.length - 3].removeAttribute('style');
            inputs[inputs.length - 3].style.setProperty('border', 'none');
        }else{
            inputs[inputs.length - 2].removeAttribute('style');
            inputs[inputs.length - 3].removeAttribute('style');
            inputs[inputs.length - 2].style.setProperty('border-color', 'red');
            inputs[inputs.length - 3].style.setProperty('border-color', 'red');
        }

        if(inputs[inputs.length - 1].checked == true){
            const number = Number(compInput.value);
            if(number >= 1000 && number <= 9999){
                compInput.removeAttribute('style');
                compInput.style.setProperty('border', 'none');
            }else{
                compInput.removeAttribute('style');
                compInput.style.setProperty('border-color', 'red');
            }
        }

        if(checkIfValid()){
            divValid.style.display = 'block';
        }else{
            divValid.style.display = 'none';
        }
    }

    function checkIfValid(){
        let isValid = true;

        for(let inp of inputs){
            if(inp.style['border-color'] === 'red'){
                isValid = false;
                break;
            }
        }
        if(inputs[inputs.length - 1].checked && compInput.style['border-color'] === 'red'){
            isValid = false;
        }

        return isValid;
    }

    function onChange(ev){
        if(ev.target.checked == true){
            companyInfo.style.display = 'block';
        }else{
            companyInfo.style.display = 'none';
        }
    }
}

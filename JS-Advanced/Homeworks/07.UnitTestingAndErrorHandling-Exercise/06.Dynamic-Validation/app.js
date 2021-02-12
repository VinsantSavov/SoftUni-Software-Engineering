function validate() {
    const regex = /[a-z]+@[a-z]+.[a-z]+/;
    const input = document.getElementById('email');
    input.addEventListener('change', onChange);

    function onChange(ev){
        let style = '';
        if(!regex.test(ev.target.value)){
            style = 'error';
        }

        ev.target.setAttribute('class', style);
    }
}
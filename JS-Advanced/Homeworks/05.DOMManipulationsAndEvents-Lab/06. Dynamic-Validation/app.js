function validate() {
    const email = document.getElementById('email');

    email.addEventListener('change', onChange);

    function onChange(ev){
        if(!/^[a-z]+\@[a-z]+\.[a-z]+$/.test(email.value)){
            ev.target.classList.add('error');
        }else{
            ev.target.classList.remove('error');
        }
    }
}
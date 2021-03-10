import {showHome} from './home.js';

let main;
let section;
let form;

export function setupLogin(mainTarget, sectionTarget){
    main = mainTarget;
    section = sectionTarget;
    form = section.querySelector('form');

    form.addEventListener('submit', loginUser);
}

export async function showLogin(){
    main.innerHTML = '';
    main.appendChild(section);
}

async function loginUser(ev){
    ev.preventDefault();
    const formData = new FormData(ev.target);
    const email = formData.get('email');
    const password = formData.get('password');

    if(email == '' || password == ''){
        return alert('Input fields can not be null');
    }

    const response = await fetch('http://localhost:3030/users/login', {
        method: 'post',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify({email, password})
    });

    if(!response.ok){
        const error = await response.json();
        return alert(error.message);
    }

    const data = await response.json();
    sessionStorage.setItem('accessToken', data.accessToken);
    sessionStorage.setItem('email', data.email);
    sessionStorage.setItem('userId', data._id);

    form.reset();
    showHome();
}
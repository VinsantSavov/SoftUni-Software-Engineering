import {showHome} from './home.js';

let main;
let section;
let form;

export function setupRegister(mainTarget, sectionTarget){
    main = mainTarget;
    section = sectionTarget;
    form = section.querySelector('form');

    form.addEventListener('submit', registerUser);
}

export async function showRegister(){
    main.innerHTML = '';
    main.appendChild(section);
}

async function registerUser(ev){
    ev.preventDefault();
    const formData = new FormData(ev.target);
    const email = formData.get('email');
    const password = formData.get('password');
    const rePass = formData.get('repeatPassword');

    if(email == '' || password == '' || rePass == ''){
        return alert('Input fields can not be empty');
    }

    if(password.length < 6){
        return alert('Password must be at least 6 characters');
    }

    if(password != rePass){
        return alert('Passwords do not match');
    }

    const response = await fetch('http://localhost:3030/users/register', {
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
import {setupHome, showHome} from './home.js';
import {setupCreate, showCreate} from './create.js';
import {setupDetails, showDetails} from './details.js';
import {setupEdit, showEdit} from './edit.js';
import {setupLogin, showLogin} from './login.js';
import {setupRegister, showRegister} from './register.js';

const main = document.querySelector('main');

setupSection('home-page', setupHome);
setupSection('add-movie', setupCreate);
setupSection('movie-details', setupDetails);
setupSection('edit-movie', setupEdit);
setupSection('form-login', setupLogin);
setupSection('form-sign-up', setupRegister);

const links = {
    'home-link': showHome,
    'logout-link': logout,
    'login-link': showLogin,
    'register-link': showRegister,
};

document.querySelector('nav').addEventListener('click', (ev) => {
    const action = links[ev.target.id];
    if(action){
        action();
    }
});
document.querySelector('.add-movie').addEventListener('click', (ev) => {
    const accessToken = sessionStorage.getItem('accessToken');

    if(!accessToken){
        return alert('You must be logged in to add a movie!');
    }
    
    showCreate();
})

navSection();
showHome();

function setupSection(sectionId, setup){
    const section = document.getElementById(sectionId);
    setup(main, section);
}

export function navSection(){
    const token = sessionStorage.getItem('accessToken');

    if(token){
        document.querySelectorAll('.user').forEach(l => l.style.display = 'inline-block');
        document.querySelectorAll('.guest').forEach(l => l.style.display = 'none');
        document.querySelector('.welcome-email').textContent = `Welcome, ${sessionStorage.getItem('email')}`;
    }else{
        document.querySelectorAll('.user').forEach(l => l.style.display = 'none');
        document.querySelectorAll('.guest').forEach(l => l.style.display = 'inline-block');
    }
}

async function logout(){
    const accessToken = sessionStorage.getItem('accessToken');

    const response = await fetch('http://localhost:3030/users/logout', {
        method: 'get',
        headers: {'X-Authorization': accessToken},
    });

    if(!response.ok){
        const error = await response.json();
        return alert(error.message);
    }

    sessionStorage.removeItem('accessToken');
    alert('You have successfully logged out');
    showHome();
}
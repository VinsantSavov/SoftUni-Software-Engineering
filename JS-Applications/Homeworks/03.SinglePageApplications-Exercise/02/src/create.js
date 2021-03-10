import {showHome} from './home.js';

let main;
let section;
let form;

export function setupCreate(mainTarget, sectionTarget){
    main = mainTarget;
    section = sectionTarget;
    form = section.querySelector('form');

    form.addEventListener('submit', createMovie);
}

export async function showCreate(){
    main.innerHTML = '';
    main.appendChild(section);
}

async function createMovie(ev){
    ev.preventDefault();
    const formData = new FormData(ev.target);
    const title = formData.get('title');
    const description = formData.get('description');
    const image = formData.get('imageUrl');
    const ownerId = sessionStorage.getItem('userId');
    const accessToken = sessionStorage.getItem('accessToken');

    if(title == '' || description == '' || image == ''){
        return alert('Input fields can not be empty!');
    }

    const response = await fetch('http://localhost:3030/data/movies', {
        method: 'post',
        headers: {'Content-Type': 'application/json', 'X-Authorization': accessToken},
        body: JSON.stringify({title, description, image, ownerId})
    });

    if(!response.ok){
        const error = await response.json();
        return alert(error.message);
    }

    showHome();
}
import {showDetails} from './details.js';

let main;
let section;

export function setupEdit(mainTarget, sectionTarget){
    main = mainTarget;
    section = sectionTarget;
}

export async function showEdit(movieId){
    main.innerHTML = '';
    changeFormValues(movieId);
    main.appendChild(section);

    section.querySelector('form').addEventListener('submit', (ev) => editMovie(ev, movieId));
}

async function getMovie(id){
    const response = await fetch('http://localhost:3030/data/movies/' + id);

    if(!response.ok){
        const error = await response.json();
        return alert(error.message);
    }
    const data = await response.json();
    return data;
}

async function changeFormValues(id){
    const titleInput = section.querySelector('input[name=title]');
    const descrInput = section.querySelector('textarea[name=description]');
    const imageInput = section.querySelector('input[name=imageUrl]');

    const movie = await getMovie(id);
    titleInput.value = movie.title;
    descrInput.value = movie.description;
    imageInput.value = movie.image;
}

async function editMovie(ev, id){
    const accessToken = sessionStorage.getItem('accessToken');
    ev.preventDefault();
    const formData = new FormData(ev.target);
    const title = formData.get('title');
    const description = formData.get('description');
    const image = formData.get('imageUrl');

    if(title == '' || description == '' || image == ''){
        return alert('Input fields can not be null');
    }

    const response = await fetch('http://localhost:3030/data/movies/' + id, {
        method: 'put',
        headers: {'Content-Type': 'application/json', 'X-Authorization': accessToken},
        body: JSON.stringify({title, description, image})
    });

    if(!response.ok){
        const error = await response.json();
        return alert(error.message);
    }

    showDetails(id);
}
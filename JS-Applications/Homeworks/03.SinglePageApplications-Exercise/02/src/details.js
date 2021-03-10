import {e} from './dom.js';
import {showHome} from './home.js';
import {showEdit} from './edit.js';

let main;
let section;

export function setupDetails(mainTarget, sectionTarget){
    main = mainTarget;
    section = sectionTarget;
 
    section.addEventListener('click', (ev) => {
        const movieId = ev.target.parentNode.parentNode.id;

        if(ev.target.classList.contains('delete-btn')){
            deleteMovie(movieId);
        }else if(ev.target.classList.contains('edit-btn')){
            showEdit(movieId);
        }else if(ev.target.classList.contains('like-btn')){
            likeMovie(movieId);
        }
    });
}

export async function showDetails(id){
    main.innerHTML = '';
    
    const movie = await getMovie(id);
    const movieCard = createMovieCard(movie);
    await checkUserAuthorization(movieCard);
    section.innerHTML = '';
    section.appendChild(movieCard);
    main.appendChild(section);

    const movieLikesCount = await getMovieLikes(id);
    const spanLikes = section.querySelector('span[class=enrolled-span]')
    spanLikes.textContent = `${movieLikesCount} likes`;
}

async function checkUserAuthorization(movieCard){
    const userId = sessionStorage.getItem('userId');
    const movieId = movieCard.querySelector('.row.bg-light.text-dark').id;

    const response = await fetch('http://localhost:3030/data/movies/' + movieId);

    if(!response.ok){
        const error = await response.json();
        return alert(error.message);
    }
    const data = await response.json();

    const movieOwnerId = data._ownerId;
    const hasLiked = await checkIfUserLikeMovie(movieId, userId);

    if(!userId || userId != movieOwnerId){
        movieCard.querySelector('.delete-btn').remove();
        movieCard.querySelector('.edit-btn').remove();
    }else if(!userId || userId == movieOwnerId){
        movieCard.querySelector('.like-btn').remove();
    }
    
    if(hasLiked){
        movieCard.querySelector('.like-btn').remove();
    }
}

async function likeMovie(movieId){
    const userId = sessionStorage.getItem('userId');
    const token = sessionStorage.getItem('accessToken');
    const hasLiked = await checkIfUserLikeMovie(movieId, userId);
    
    if(!hasLiked){
        const response = await fetch('http://localhost:3030/data/likes', {
            method: 'post',
            headers: {'Content-Type': 'application/json', 'X-Authorization': token},
            body: JSON.stringify({movieId, userId})
        });

        if(!response.ok){
            const error = await response.json();
            return alert(error.message);
        }
    }
    showDetails(movieId);
}

async function getMovieLikes(movieId){
    const response = await fetch(`http://localhost:3030/data/likes?where=movieId%3D%22${movieId}%22&distinct=_ownerId&count`);

    if(!response.ok){
        const error = await response.json();
        return alert(error.message);
    }

    const data = await response.json();
    return data;
}

async function checkIfUserLikeMovie(movieId, userId){
    const response = await fetch(`http://localhost:3030/data/likes?where=movieId%3D%22${movieId}%22%20and%20_ownerId%3D%22${userId}%22`);

    if(!response.ok){
        const error = await response.json();
        return alert(error.message);
    }

    const data = await response.json();
    return data.length == 0 ? false : true;
}

async function deleteMovie(movieId){
    const accessToken = sessionStorage.getItem('accessToken');

    const response = await fetch('http://localhost:3030/data/movies/' + movieId, {
        method: 'delete',
        headers: {'X-Authorization': accessToken}
    });

    if(!response.ok){
        const error = await response.json();
        return alert(error.message);
    }

    showHome();
}

function createMovieCard(movie){
    const card = e('div', {className: 'container'}, e('div', {className: 'row bg-light text-dark', id: movie._id},
        e('h1', {}, movie.title),
        e('div', {className: 'col-md-8'}, 
            e('img', {className: 'img-thumbnail', src: movie.img, alt: 'Movie'}, '')),
        e('div', {className: 'col-md-4 text-center'},
            e('h3', {className: 'my-3'}, 'Movie Description'),
            e('p', {}, movie.description),
            e('a', {className: 'btn btn-danger delete-btn', href: '#'}, 'Delete'),
            e('a', {className: 'btn btn-warning edit-btn', href: '#'}, 'Edit'),
            e('a', {className: 'btn btn-primary like-btn', href: '#'}, 'Like'),
            e('span', {className: 'enrolled-span'}, 'Liked 1'))));
    return card;
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
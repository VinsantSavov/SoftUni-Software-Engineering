import {e} from './dom.js';
import {showDetails} from './details.js';
import {navSection} from './app.js';

let main;
let section;
let container;

export function setupHome(mainTarget, sectionTarget){
    main = mainTarget;
    section = sectionTarget;
    container = section.querySelector('.card-deck.d-flex.justify-content-center');

    container.addEventListener('click', (ev) => {
        if(ev.target.classList.contains('movieCardButton')){
            const movieId = ev.target.parentNode.parentNode.parentNode.id;
            showDetails(movieId);
        }
    })
}

export async function showHome(){
    navSection();
    main.innerHTML = '';
    main.appendChild(section);

    container.innerHTML = '';
    const movies = await getMovies();
    movies.map(createMovieCard).forEach(m => container.appendChild(m));
}

async function getMovies(){
    const response = await fetch('http://localhost:3030/data/movies');

    if(!response.ok){
        const error = await response.json();
        return alert(error.message);
    }
    const data = await response.json();
    return data;
}

function createMovieCard(movie){
    const movieCard = e('div', {className: 'card mb-4', id: movie._id},
        e('img', {className: 'card-img-top', src: movie.img, alt: 'Card image cap', width: '400'}, ''),
        e('div', {className: 'card-body'}, 
            e('h4', {className: 'card-title'}, movie.title)),
        e('div', {className: 'card-footer'}, 
            e('a', {href: '#/details/6lOxMFSMkML09wux6sAF'}, 
                e('button', {type: 'button', className: 'btn btn-info movieCardButton'}, 'Details'))));
    return movieCard;
}
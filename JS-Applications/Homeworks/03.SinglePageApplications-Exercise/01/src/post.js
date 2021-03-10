import {setupComment, createComment, displayComments} from './comment.js';
import {e} from './dom.js';

let main;
let section;
let content;
let comments;
let form;

export function setupPost(mainTarget, sectionTarget){
    main = mainTarget;
    section = sectionTarget;

    content = section.querySelector('div[class=theme-title]');
    comments = section.querySelector('#comments');
    form = section.querySelector('form');
    form.addEventListener('submit', (ev) => createComment(ev));
}

export async function showPost(postId){
    main.innerHTML = '';
    main.appendChild(section);

    content.innerHTML = '';
    const post = await getPost(postId);
    const createdPost = createPostDiv(post);
    content.appendChild(createdPost);

    setupComment(comments);
    displayComments();
}

async function getPost(id){
    const response = await fetch('http://localhost:3030/jsonstore/collections/myboard/posts/' + id);
    
    if(!response.ok){
        const error = await response.json();
        return alert(error);
    }

    const data = await response.json();
    return data;
}

function createPostDiv(post){
    const div = e('div', {className: 'theme-name-wrapper', id: post._id}, 
        e('div', {className: 'theme-name'}, 
            e('h2', {}, post.topicName),
            e('p', {}, 'Date: ', 
                e('time', {}, post.time))),
        e('div', {className: 'subscribers'}, 
            e('p', {}, 'Subscribers: ', 
                e('span', {}, '0'))));
    return div;
}
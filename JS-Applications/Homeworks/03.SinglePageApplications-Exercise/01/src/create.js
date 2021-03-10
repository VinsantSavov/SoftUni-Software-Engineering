import {e} from './dom.js';
import {showHome} from './home.js';

let main;
let section;
let form;

export function setupCreate(mainTarget, sectionTarget){
    main = mainTarget;
    section = sectionTarget;
    form = section.querySelector('form');

    form.addEventListener('click', (ev) => {
        if(ev.target.classList.contains('cancel')){
            cancelCreation(ev);
        }else if(ev.target.classList.contains('post')){
            executeCreate(ev);
        }
    });
}

export function showCreate(){
    main.innerHTML = '';
    main.appendChild(section);
}

function cancelCreation(ev){
    ev.preventDefault();
    //ev.stopPropagation();

    form.reset();
}

async function executeCreate(ev){
    ev.preventDefault();

    const formData = new FormData(form);
    const topicName = formData.get('topicName');
    const username = formData.get('username');
    const postText = formData.get('postText');
    const time = new Date().toLocaleString();

    if(topicName == '' || username == '' || postText == ''){
        return alert('Input fields can not be empty');
    }

    const response = await fetch('http://localhost:3030/jsonstore/collections/myboard/posts', {
        method: 'post',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify({topicName, username, postText, time} )
    });
    
    if(!response.ok){
        const error = await response.json();
        return alert(error);
    }

    form.reset();
    showHome();
}
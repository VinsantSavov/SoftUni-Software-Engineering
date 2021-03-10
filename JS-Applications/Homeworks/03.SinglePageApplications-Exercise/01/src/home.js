import {e} from './dom.js';
import {showCreate} from './create.js';
import {setupPost, showPost} from './post.js';

let main;
let section;
let divTopics;

export function setupHome(mainTarget, sectionTarget){
    main = mainTarget;
    section = sectionTarget;
    divTopics = section.querySelector('.topic-title');

    section.addEventListener('click', (ev) => {
        if(ev.target.classList.contains('create-post-button')){
            showCreate();
        }else if(ev.target.tagName == 'H2'){
            const postId = ev.target.parentNode.parentNode.parentNode.parentNode.id;
            showPost(postId);
        }
    })
}

export async function showHome(){
    main.innerHTML = '';
    main.appendChild(section);

    divTopics.innerHTML = '';
    const posts = await getPosts();
    Object.values(posts).forEach(t => {
        const topic = createTopic(t);
        divTopics.appendChild(topic);
    });
}

async function getPosts(){
    const response = await fetch('http://localhost:3030/jsonstore/collections/myboard/posts');

    if(!response.ok){
        const error = await response.json();
        return alert(error.message);
    }

    const data = await response.json();
    return data;
}

function createTopic(obj){
    const div = e('div', {'className': 'topic-container', 'id': obj._id}, 
            e('div', {'className': 'topic-name-wrapper'},
                e('div', {'className': 'topic-name'},
                    e('a', {'href': '#', 'className': 'normal'}, e('h2', {}, obj.topicName)),
                    e('div', {'className': 'columns'},
                        e('div', {}, 
                            e('p', {}, 'Date: ', 
                                e('time', {}, obj.time)),
                            e('div', {'className': 'nick-name'}, 
                                e('p', {}, 'Username: ', 
                                    e('span', {}, obj.username)))),
                        e('div', {'className': 'subscribers'},
                            e('p', {}, 'Subscribers: ',
                                e('span', {}, 0)
                            )
                        )
                    )
                )
            ));
    
    return div;
}
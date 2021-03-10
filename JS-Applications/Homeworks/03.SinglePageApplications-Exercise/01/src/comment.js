import {e} from './dom.js';

let content;
let postId

export function setupComment(contentTarget){
    content = contentTarget;
    postId = content.parentNode.children[0].children[0].id;
}

export async function createComment(ev){
    ev.preventDefault();
    const formData = new FormData(ev.target);
    const postText = formData.get('postText');
    const username = formData.get('username');
    const time = new Date().toLocaleString();

    if(postText == '' || username == ''){
        return alert('Input fields can not be empty');
    }

    const response = await fetch('http://localhost:3030/jsonstore/collections/myboard/comments', {
        method: 'post',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify({postText, username, time, postId})
    });
    
    if(!response.ok){
        const error = await response.json();
        return alert(error);
    }

    ev.target.reset();
    displayComments();
}

export async function displayComments(){
    const response = await fetch('http://localhost:3030/jsonstore/collections/myboard/comments');
    content.innerHTML = '';

    if(!response.ok){
        const error = await response.json();
        return alert(error);
    }

    const data = await response.json();
    Object.values(data).forEach(c => {
        if(c.postId == postId){
            const div = createCommentCard(c);
            content.appendChild(div);
        }
    })
}

function createCommentCard(obj){
    const div = e('div', {'className': 'comment'}, 
        e('header', {'className': 'header'},
            e('p', {}, 
                e('span', {}, obj.username),
                ' posted on ',
                e('time', {}, obj.time)),
        e('div', {'className': 'comment-main'},
            e('div', {'className': 'userdetails'},
                e('img', {'src': './static/profile.png', 'alt': 'avatar'}, '')),
            e('div', {'className': 'post-content'}, 
                e('p', {}, obj.postText)),
            ),
        e('div', {'class': 'footer'}, 
            e('p', {}, 
                e('span', {}, 0), ' likes'))));
    
    return div;
}
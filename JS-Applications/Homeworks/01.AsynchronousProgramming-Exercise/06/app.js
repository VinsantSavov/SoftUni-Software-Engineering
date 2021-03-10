function attachEvents() {
    const posts = document.getElementById('posts');
    const h1Post = document.getElementById('post-title');
    const ulPost = document.getElementById('post-body');
    const ulComments = document.getElementById('post-comments');

    document.getElementById('btnLoadPosts').addEventListener('click', loadPosts);
    document.getElementById('btnViewPost').addEventListener('click', viewPost);

    async function loadPosts(){
        const url = 'http://localhost:3030/jsonstore/blog/posts';

        try{
            const response = await fetch(url);

            if(!response.ok){
                throw new Error();
            }

            posts.textContent = '';
            const data = await response.json();
            for(const [key, value] of Object.entries(data)){
                const option = e('option', {'value': key}, value.title.toUpperCase());
                posts.appendChild(option);
            }
        }catch{
            alert(`Error: ${ex.statusText}`);
        }
    }

    async function viewPost(){
        const urlComments = 'http://localhost:3030/jsonstore/blog/comments';
        const urlPost = `http://localhost:3030/jsonstore/blog/posts/${posts.value}`;
        
        try{
            const [commentsResponse, postResponse] = await Promise.all([
                fetch(urlComments),
                fetch(urlPost),
            ]);

            if(!commentsResponse.ok || !postResponse.ok){
                throw new Error();
            }
            const dataComments = await commentsResponse.json();
            const post = await postResponse.json();

            ulComments.textContent = '';
            Object.values(dataComments).filter(c => c.postId == posts.value).forEach(c => {
                const li = e('li', {'id': c.id}, c.text);
                ulComments.appendChild(li);
            });
            
            h1Post.textContent = post.title.toUpperCase();
            ulPost.replaceWith(e('p', {'id': 'post-body'}, post.body));
        }catch(ex){
            alert(`Error: ${ex.statusText}`);
        }
    }
}

function e(type, attributes, ...content) {
    const result = document.createElement(type);

    for (let [attr, value] of Object.entries(attributes || {})) {
        if (attr.substring(0, 2) == 'on') {
            result.addEventListener(attr.substring(2).toLocaleLowerCase(), value);
        } else {
            result[attr] = value;
        }
    }

    content = content.reduce((a, c) => a.concat(Array.isArray(c) ? c : [c]), []);

    content.forEach(e => {
        if (typeof e == 'string' || typeof e == 'number') {
            const node = document.createTextNode(e);
            result.appendChild(node);
        } else {
            result.appendChild(e);
        }
    });

    return result;
}

attachEvents();
async function solution() {
    const main = document.getElementById('main');
    main.textContent = '';
    const url = 'http://localhost:3030/jsonstore/advanced/articles/list';

    try{
        const response = await fetch(url);

        if(!response.ok){
            throw new Error();
        }

        const data = await response.json();

        data.forEach(async d => {
            const art = await createArticle(d._id);
            main.appendChild(art);
        });
    }catch(ex){
        alert(`Error: ${ex.statusText}`);
    }
}

async function createArticle(id){
    const url = `http://localhost:3030/jsonstore/advanced/articles/details/${id}`;

    const response = await fetch(url);

    if(!response.ok){
        throw new Error();
    }

    const data = await response.json();
    const article = e('div', {'className': 'accordion'},
        e('div', {'className': 'head'}, 
            e('span', {}, data.title),
            e('button', {'className': 'button', 'id': data._id, 'onClick': toggle}, 'More')),
        e('div', {'className': 'extra'}, e('p', {}, data.content)));
    
    return article;
}

function toggle(ev){
    const contentDiv = ev.target.parentNode.parentNode.lastChild;

    if(ev.target.textContent == 'More'){
        ev.target.textContent = 'Less';
        contentDiv.removeAttribute('class');
    }else{
        ev.target.textContent = 'More';
        contentDiv.setAttribute('class', 'extra');
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

window.addEventListener('load', solution);
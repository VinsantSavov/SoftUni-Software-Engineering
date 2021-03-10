async function loadRecipes(){
    const main = document.querySelector('main');
    main.textContent = '';
    const url = 'http://localhost:3030/jsonstore/cookbook/recipes';

    const response = await fetch(url);
    const data = await response.json();

    Object.values(data).map(i => {
        const article = e('article', '', 'preview');
        const divTitle = e('div', '', 'title');
        const h2 = e('h2', i.name);
        const div = e('div', '', 'small');
        const img = e('img');
        img.setAttribute('src', i.img);

        divTitle.appendChild(h2);
        div.appendChild(img);
        article.appendChild(divTitle);
        article.appendChild(div);
        article.addEventListener('click', toggle);
        article.setAttribute('id', i._id);

        return article;
    }).forEach(i => main.appendChild(i));
}

async function toggle(ev){
    const id = ev.target.id;
    const url = `http://localhost:3030/jsonstore/cookbook/details/${id}`;

    const response = await fetch(url);
    const data = await response.json();
    const element = createArticle(data);
    ev.target.replaceWith(element);
}

function createArticle(i){
    const article = e('article', '');
    const h2 =  e('h2', i.name);
    const divBand = e('div', '', 'band');
    const divThumb = e('div', '', 'thumb');
    const img = e('img', '');
    img.setAttribute('src', i.img);
    const divIngregients = e('div', '', 'ingredients');
    const h3 = e('h3', 'Ingredients:');
    const ul = e('ul', '');
    i.ingredients.map(r => {
        const li = e('li', r);
        return li;
    }).forEach(r => ul.appendChild(r));
    const divDescription = e('div', '', 'description');
    const h3Prep = e('h3', 'Preparation');
    divDescription.appendChild(h3Prep);
    i.steps.map(s => {
        const p = e('p', s);
        return p;
    }).forEach(s => divDescription.appendChild(s));

    article.appendChild(h2);
    divThumb.appendChild(img);
    divIngregients.appendChild(h3);
    divIngregients.appendChild(ul);
    divBand.appendChild(divThumb);
    divBand.appendChild(divIngregients);

    article.appendChild(divBand);
    article.appendChild(divDescription);

    return article;
}

function e(type, text, className){
    const result = document.createElement(type);
    result.textContent = text;

    if(className){
        result.className = className;
    }

    return result;
}

window.addEventListener('load', loadRecipes);
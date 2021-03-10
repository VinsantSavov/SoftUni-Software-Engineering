const tableBody = document.querySelector('tbody');
document.getElementById('loadBooks').addEventListener('click', loadBooks);
document.querySelector('#createForm').addEventListener('submit', createBook);

async function loadBooks(ev){
    tableBody.textContent = '';
    const response = await fetch('http://localhost:3030/jsonstore/collections/books');

    if(!response.ok){
        return alert('Problem with loading books occurred!');
    }

    const data = await response.json();

    for(const [key, value] of Object.entries(data)){
        const tRow = e('tr', {'id': key}, 
        e('td', {}, value.title), 
        e('td', {}, value.author), 
        e('td', {}, 
            e('button', {'onClick': editBook}, 'Edit'),
            e('button', {'onClick': deleteBook}, 'Delete')));

        tableBody.appendChild(tRow);
    }
}

async function createBook(ev){
    ev.preventDefault();
    const formData = new FormData(ev.target);
    const title = formData.get('title');
    const author = formData.get('author');

    if(title == '' || author == ''){
        return alert('Input fields can not be empty');
    }

    const response = await fetch('http://localhost:3030/jsonstore/collections/books', {
        method: 'post',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify({author, title})
    });

    if(!response.ok){
        return alert('Could not create a book');
    }

    ev.target.reset();

    loadBooks();
}

async function editBook(ev){
    document.getElementById('editForm').style.display = 'block';
    document.getElementById('createForm').style.display = 'none';

    const form = document.querySelector('#editForm');

    const id = ev.target.parentNode.parentNode.id;
    const book = await getBook(id);
    const title = document.querySelector('#editForm input[name=title]');
    const author = document.querySelector('#editForm input[name=author]');
    form['book-id'] = id;

    title.value = book.title;
    author.value = book.author;

    await form.addEventListener('submit', updateBook);
}

async function updateBook(ev){
    ev.preventDefault();
    const title = document.querySelector('#editForm input[name=title]');
    const author = document.querySelector('#editForm input[name=author]');
    const form = document.querySelector('#editForm');
    const id = form['book-id'];

    if(title == '' || author == ''){
        return alert('Could not edit fields');
    }

    const response = await fetch('http://localhost:3030/jsonstore/collections/books/' + id, {
        method: 'put',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify({'author': author.value, 'title': title.value})
    });

    if(!response.ok){
        return alert('Could not create a book');
    }
    
    document.getElementById('editForm').style.display = 'none';
    document.getElementById('createForm').style.display = 'block';
    await loadBooks();
}

async function getBook(id){
    const response = await fetch('http://localhost:3030/jsonstore/collections/books/' + id);

    if(!response.ok){
        const error = await response.json();
        alert(error);
        throw new Error();
    }

    const data = await response.json();
    return data;
}

async function deleteBook(ev){
    const key = ev.target.parentNode.parentNode.id;

    const response = await fetch('http://localhost:3030/jsonstore/collections/books/' + key, {
        method: 'delete'
    });

    if(!response.ok){
        return alert('Could not delete the book');
    }

    loadBooks();
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
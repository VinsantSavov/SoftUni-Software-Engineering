function attachEvents() {
    const phonebook = document.getElementById('phonebook');
    const personInput = document.getElementById('person');
    const phoneInput = document.getElementById('phone');
    document.getElementById('btnLoad').addEventListener('click', loadContacts);
    document.getElementById('btnCreate').addEventListener('click', createContact);

    async function loadContacts(ev){
        phonebook.textContent = '';
        const response = await fetch('http://localhost:3030/jsonstore/phonebook');

        if(!response.ok){
            return alert('Problem occurred with loading data');
        }

        const data = await response.json();

        for(const [key, value] of Object.entries(data)){
            const li = e('li', {'id': key}, `${value.person}: ${value.phone}`, e('button', {'onClick': onDelete}, 'Delete'));
            phonebook.appendChild(li);
        }
    }

    async function createContact(ev){
        const person = personInput.value;
        const phone = phoneInput.value;
        personInput.value = '';
        phoneInput.value = '';

        if(person == '' || phone == ''){
            return alert('Person and phone can not be empty');
        }

        const response = await fetch('http://localhost:3030/jsonstore/phonebook', {
            method: 'post',
            headers: {'Content-Type': 'application/json'},
            body: JSON.stringify({person, phone})
        });

        if(!response.ok){
            return alert('Can not create a contact');
        }

        loadContacts();
    }

    async function onDelete(ev){
        const key = ev.target.parentNode.id;
        
        const response = await fetch('http://localhost:3030/jsonstore/phonebook/' + key, {
            method: 'delete'
        });

        if(!response.ok){
            return alert('Invalid delete');
        }

        loadContacts();
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
function attachEvents() {
    const catches = document.getElementById('catches');
    document.querySelector('.add').disabled = false;
    document.querySelector('.add').addEventListener('click', addCatch);
    document.querySelector('.load').addEventListener('click', loadData);

    window.addEventListener('load', () => {
        document.querySelectorAll('#main button').forEach(b => {
            if(sessionStorage.getItem('accessToken')){
                b.disabled = false;
            }else{
                b.disabled = true;
            }
        });
        if(sessionStorage.hasOwnProperty('accessToken')){
            document.getElementById('guest').style.display = 'none';
        }
    });

    async function loadData(){
        catches.textContent = '';
        const response = await fetch('http://localhost:3030/data/catches');
    
        if(!response.ok){
            return alert('Could not load data');
        }
    
        const data = await response.json();
        data.forEach(d => {
            const divCatch = createCatch(d);
            catches.appendChild(divCatch);
        });

        document.querySelectorAll('#main button').forEach(b => {
            if(sessionStorage.getItem('accessToken')){
                b.disabled = false;
            }else{
                b.disabled = true;
            }
        });

        if(sessionStorage.hasOwnProperty('accessToken')){
            document.getElementById('guest').style.display = 'none';
        }
    }

    async function addCatch(ev){
        const accessToken = sessionStorage.getItem('accessToken');

        if(!accessToken){
            return alert('You must be logged in if you want to add a catch');
        }

        const angler = document.querySelector('#addForm input[class=angler]').value;
        const weight = Number(document.querySelector('#addForm input[class=weight]').value);
        const species = document.querySelector('#addForm input[class=species]').value;
        const location = document.querySelector('#addForm input[class=location]').value;
        const bait = document.querySelector('#addForm input[class=bait]').value;
        const captureTime = Number(document.querySelector('#addForm input[class=captureTime]').value);

        if(angler == '' || weight < 0 || species == '' || location == '' || bait == '' || captureTime < 0){
            return alert('Input fields can not be empty');
        }

        const response = await fetch('http://localhost:3030/data/catches', {
            method: 'post',
            headers: {'Content-Type': 'application/json', 'X-Authorization': accessToken},
            body: JSON.stringify({angler, weight, species, location, bait, captureTime})
        });

        if(!response.ok){
            return alert('Could not create a new catch');
        }

        loadData();
    }

    async function updateCatch(ev){
        const divCatch = ev.target.parentNode;
        const catchId = divCatch.id;
        const ownerId = ev.target.parentNode.querySelector('#owner-id').textContent;

        if(ownerId != sessionStorage.getItem('userId')){
            return alert('You are not allowed to update this catch');
        }

        const angler = divCatch.querySelector('input[class=angler]').value;
        const weight = Number(divCatch.querySelector('input[class=weight]').value);
        const species = divCatch.querySelector('input[class=species]').value;
        const location = divCatch.querySelector('input[class=location]').value;
        const bait = divCatch.querySelector('input[class=bait]').value;
        const captureTime = Number(divCatch.querySelector('input[class=captureTime]').value);

        const response = await fetch('http://localhost:3030/data/catches/' + catchId, {
            method: 'put',
            headers: {'Content-Type': 'application/json', 'X-Authorization': sessionStorage.getItem('accessToken')},
            body: JSON.stringify({angler, weight, species, location, bait, captureTime})
        });

        if(!response.ok){
            return alert('Could not delete the catch');
        }

        loadData();
    }

    async function deleteCatch(ev){
        const catchId = ev.target.parentNode.id;
        const ownerId = ev.target.parentNode.querySelector('#owner-id').textContent;

        if(ownerId != sessionStorage.getItem('userId')){
            return alert('You are not allowed to delete this catch');
        }

        const response = await fetch('http://localhost:3030/data/catches/' + catchId, {
            method: 'delete',
            headers: {'X-Authorization': sessionStorage.getItem('accessToken')}
        });

        if(!response.ok){
            return alert('Could not delete the catch');
        }

        loadData();
    }

    function createCatch(obj){
        const div = e('div', {'className': 'catch', 'id': obj._id},
            e('label', {}, 'Angler'),
            e('input', {'type': 'text', 'className': 'angler', 'value': obj.angler}, ''),
            e('hr', {}, ''),
            e('label', {}, 'Weight'),
            e('input', {'type': 'number', 'className': 'weight', 'value': obj.weight}, ''),
            e('hr', {}, ''),
            e('label', {}, 'Species'),
            e('input', {'type': 'text', 'className': 'species', 'value': obj.species}, ''),
            e('hr', {}, ''),
            e('label', {}, 'Location'),
            e('input', {'type': 'text', 'className': 'location', 'value': obj.location}, ''),
            e('hr', {}, ''),
            e('label', {}, 'Bait'),
            e('input', {'type': 'text', 'className': 'bait', 'value': obj.bait}, ''),
            e('hr', {}, ''),
            e('label', {}, 'Capture Time'),
            e('input', {'type': 'number', 'className': 'captureTime', 'value': obj.captureTime}, ''),
            e('hr', {}, ''),
            e('button', {'disabled': 'true', 'className': 'update', 'onClick': updateCatch}, 'Update'),
            e('button', {'disabled': 'true', 'className': 'delete', 'onClick': deleteCatch}, 'Delete'));
        
        const owner = document.createElement('div');
        owner.textContent = obj._ownerId;
        owner.style.display = 'none';
        owner.setAttribute('id', 'owner-id');
        div.appendChild(owner);

        return div;
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
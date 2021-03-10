async function lockedProfile() {
    const main = document.getElementById('main');
    main.addEventListener('click', onShowMore);
    const url = 'http://localhost:3030/jsonstore/advanced/profiles';

    try{
        const response = await fetch(url);

        if(!response.ok){
            throw new Error();
        }
        const data = await response.json();
        main.textContent = '';

        Object.values(data).forEach(u => {
            main.appendChild(createProfile(u.username, u.email, u.age));
        })
    }catch{
        alert(`Error: ${ex.statusText}`);
    }
}

function onShowMore(ev){
    if(ev.target.tagName != 'BUTTON'){
        return;
    }

    const profile = ev.target.parentNode;
    const locked = profile.children[2];
    const hiddenFields = profile.children[profile.children.length - 2];

    if(locked.checked == true){
        return;
    }

    if(ev.target.textContent == 'Show more'){
        hiddenFields.removeAttribute('id');
        ev.target.textContent = 'Hide it';
    }else{
        hiddenFields.setAttribute('id', 'user1HiddenFields');
        ev.target.textContent = 'Show more';
    }
}

function createProfile(username, email, age){
    /*const divProfile = e('div', {'className': 'profile'},
    e('img', {'src': './iconProfile2.png', 'className': 'userIcon'}),
    e('label', {}, 'Lock'),
    e('input', {'type': 'radio', 'name': 'user1Locked', 'value': 'lock', 'checked': true}),
    e('label', {}, 'Unlock'),
    e('input', {'type': 'radio', 'name': 'user1Locked', 'value': 'unlock'}),
    e('br', {}),
    e('hr', {}),
    e('label', {}, 'Username'),
    e('input', {'type': 'text', 'name': 'user1Username', 'value': `${username}`, 'disabled': true, 'readOnly': true}),
    e('div', {'id': 'user1HiddenFields'}, 
        e('hr', {}),
        e('label', {}, 'Email:'),
        e('input', {'type': 'email', 'name': 'user1Email', 'value': `${email}`, 'disabled': true, 'readOnly': true}),
        e('label', {}, 'Age:'),
        e('input', {'type': 'email', 'name': 'user1Age', 'value': `${age}`, 'disabled': true, 'readOnly': true})),
    e('button', {}, 'Show more'));*/
    const divProfile = e('div', {'className': 'profile'},
    e('img', {'src': './iconProfile2.png', 'className': 'userIcon'}),
    e('label', {}, 'Lock'),
    e('input', {'type': 'radio', 'name': username + 'Locked', 'value': 'lock', 'checked': true}),
    e('label', {}, 'Unlock'),
    e('input', {'type': 'radio', 'name': username + 'Locked', 'value': 'unlock'}),
    e('br', {}),
    e('hr', {}),
    e('label', {}, 'Username'));
    const usernameInput = e('input', {'type': 'text', 'name': 'user1Username', 'disabled': true, 'readOnly': true});
    usernameInput.setAttribute('value', username);
    divProfile.appendChild(usernameInput);

    const hiddenFields = e('div', {'id': 'user1HiddenFields'}, 
    e('hr', {}),
    e('label', {}, 'Email:'));
    const emailInput = e('input', {'type': 'email', 'name': 'user1Email', 'disabled': true, 'readOnly': true});
    emailInput.setAttribute('value', email);
    hiddenFields.appendChild(e('label', {}, 'Age:'));
    const ageInput = e('input', {'type': 'email', 'name': 'user1Age', 'disabled': true, 'readOnly': true});
    ageInput.setAttribute('value', age);

    hiddenFields.appendChild(emailInput);
    hiddenFields.appendChild(ageInput);

    divProfile.appendChild(hiddenFields);
    divProfile.appendChild(e('button', {}, 'Show more'));

    return divProfile;
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
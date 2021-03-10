const tableBody = document.querySelector('tbody');
document.getElementById('form').addEventListener('submit', createRow);

async function createRow(ev){
    ev.preventDefault();
    const formData = new FormData(ev.target);

    const firstName = formData.get('firstName');
    const lastName = formData.get('lastName');
    const facultyNumber = formData.get('facultyNumber');
    const grade = formData.get('grade');

    if(firstName == '' || lastName == '' || facultyNumber == '' || grade == ''){
        return alert('Input fields can not be empty!');
    }

    const response = await fetch('http://localhost:3030/jsonstore/collections/students', {
        method: 'post',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify({firstName, lastName, facultyNumber, grade})
    });

    if(!response.ok){
        return alert('Row can not be created!');
    }

    loadStudents();
}

async function loadStudents(){
    tableBody.textContent = '';
    const response = await fetch('http://localhost:3030/jsonstore/collections/students');

    if(!response.ok){
        return alert('Could not load data');
    }

    const data = await response.json();
    Object.values(data).forEach(r => {
        const tr = e('tr', {}, 
            e('td', {}, r.firstName), 
            e('td', {}, r.lastName), 
            e('td', {}, r.facultyNumber), 
            e('td', {}, r.grade));
        
        tableBody.appendChild(tr);
    })
}

window.addEventListener('load', loadStudents);


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
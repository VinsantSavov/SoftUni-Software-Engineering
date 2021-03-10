document.querySelector('form[id=register]').addEventListener('submit', register);
document.querySelector('form[id=login]').addEventListener('submit', login);

async function register(ev){
    ev.preventDefault();
    const formData = new FormData(ev.target);
    const email = formData.get('email');
    const password = formData.get('password');
    const repass = formData.get('rePass');

    if(email == '' || password == ''){
        return alert('Input fields can not be empty');
    }

    if(password != repass){
        return alert('Passwords do not match');
    }

    const response = await fetch('http://localhost:3030/users/register', {
        method: 'post',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify({email, password})
    });

    if(!response.ok){
        return alert('Could not register user');
    }

    const data = await response.json();
    sessionStorage.setItem('accessToken', data.accessToken);
    sessionStorage.setItem('userId', data._id);
    window.location.pathname = '/05/index.html';
}

async function login(ev){
    ev.preventDefault();
    const formData = new FormData(ev.target);
    const email = formData.get('email');
    const password = formData.get('password');

    if(email == '' || password == ''){
        return alert('Input fields can not be empty');
    }

    const response = await fetch('http://localhost:3030/users/login', {
        method: 'post',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify({email, password})
    });

    if(!response.ok){
        return alert('Could not login user');
    }

    const data = await response.json();
    console.log(data);
    sessionStorage.setItem('accessToken', data.accessToken);
    sessionStorage.setItem('userId', data._id);
    window.location.pathname = '/05/index.html';
}
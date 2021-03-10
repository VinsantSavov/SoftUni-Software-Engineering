document.querySelector('form').addEventListener('submit', onRegisterSubmit);

async function onRegisterSubmit(event){
    event.preventDefault();

    const formData = new FormData(event.target);
    const email = formData.get('email');
    const password = formData.get('password');
    const rePassword = formData.get('rePass');
    
    if(email == '' || password == ''){
        return alert('Inputs can not be empty!');
    }
    if(password != rePassword){
        return alert('Passwords do not match!');
    }

    const response = await fetch('http://localhost:3030/users/register', {
        method: 'post',
        headers: { 'Content-Type': 'application/json'},
        body: JSON.stringify({email, password})
    });

    if(!response.ok){
        return alert('Error occured with the registration');
    }

    const data = await response.json();
    sessionStorage.setItem('accessToken', data.accessToken);
    window.location.pathname = '/index.html';
}

function attachEvents() {
    const textarea = document.getElementById('messages');
    const inputName = document.querySelector('input[name=author]');
    const inputContent = document.querySelector('input[name=content');

    document.getElementById('submit').addEventListener('click', submitText);
    document.getElementById('refresh').addEventListener('click', onRefresh);

    async function submitText(ev){
        const url = 'http://localhost:3030/jsonstore/messenger';
        const author = inputName.value;
        const content = inputContent.value;
    
        if(author == '' || content == ''){
            return alert('Invalid author or content!');
        }
    
        const response = await fetch(url, {
            method: 'post',
            headers: {'Content-Type': 'application/json'},
            body: JSON.stringify({author, content})
        });
    
        if(!response.ok){
            return alert('Invalid message');
        }
    }
    
    async function onRefresh(ev){
        const url = 'http://localhost:3030/jsonstore/messenger';
        textarea.value = '';
        inputName.value = '';
        inputContent.value = '';

        const response = await fetch(url);
        
        if(!response.ok){
            return alert('Invalid request');
        }

        const data = await response.json();
        
        Object.values(data).map(m => textarea.value += `${m.author}: ${m.content}\n`);
    }
}

attachEvents();
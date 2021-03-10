const username = document.getElementById('username');
const repo = document.getElementById('repo');
const ul = document.getElementById('commits');

async function loadCommits() {
    const url = `https://api.github.com/repos/${username.value}/${repo.value}/commits`;
    ul.textContent = '';

    try{
        const response = await fetch(url);

        if(!response.ok){
            throw new Error(`Error: ${response.status} (${response.statusText})`);
        }

        const data = await response.json();
        data.map(i => {
            const li = document.createElement('li');
            li.textContent = `${i.commit.author.name}: ${i.commit.message}`;
            return li;
        }).forEach(i => ul.appendChild(i));

    }catch(ex){
        const li = document.createElement('li');
        li.textContent = ex.message;
        ul.appendChild(li);
    }
}
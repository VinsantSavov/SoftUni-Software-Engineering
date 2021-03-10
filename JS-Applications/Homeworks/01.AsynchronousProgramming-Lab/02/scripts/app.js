const input = document.getElementById('username');
const ul = document.getElementById('repos');

async function loadRepos() {
	const url = 'https://api.github.com/users/' + input.value + '/repos';
	ul.textContent = '';

	const response = await fetch(url);
	const data = await response.json();

	//console.log(data);

	const reps = data.map(d => {
		const li = document.createElement('li');
		li.textContent = d.full_name;
		return li;
	});
	reps.forEach(i => ul.appendChild(i));
}
function solve() {
    const inputs = document.querySelectorAll('#container input[type=text]');
    document.querySelector('#container button').addEventListener('click', addMovie);
    document.querySelector('#archive button').addEventListener('click', clearList);
    const moviesList = document.querySelector('#movies ul');
    const archiveList = document.querySelector('#archive ul');

    function addMovie(){
        const movieName = inputs[0].value;
        const hall = inputs[1].value;
        const ticketPrice = Number(inputs[2].value);
        inputs[0].value = '';
        inputs[1].value = '';
        inputs[2].value = '';

        if(movieName == '' || movieName == undefined || hall == '' || hall == undefined || Number.isNaN(ticketPrice) || ticketPrice == 0){
            return;
        }

        const liEl = createEl('li');
        createEl('span', movieName, liEl);
        createEl('strong', `Hall: ${hall}`, liEl);
        const divEl = createEl('div');
        createEl('strong', ticketPrice.toFixed(2), divEl);
        const inputEl = createEl('input');
        inputEl.placeholder = 'Tickets Sold';
        divEl.appendChild(inputEl);
        const btnArch = createEl('button', 'Archive');
        btnArch.addEventListener('click', addToArchive);
        divEl.appendChild(btnArch);
        liEl.appendChild(divEl);
        moviesList.appendChild(liEl);
    }

    function addToArchive(ev){
        const elements = ev.target.parentNode.parentNode.children;
        ev.target.parentNode.parentNode.remove();
        const movie = elements[0].textContent;
        const hall = elements[1].textContent;
        const price = Number(elements[2].children[0].textContent);
        const count = Number(elements[2].children[1].value);
        const total = count * price;

        if(Number.isNaN(count) || count == 0){
            return;
        }

        const liElement = createEl('li');
        createEl('span', movie, liElement);
        createEl('strong', `Total amount: ${total.toFixed(2)}`, liElement);
        const btn = createEl('button', 'Delete');
        btn.addEventListener('click', deleteItem);
        liElement.appendChild(btn);

        archiveList.appendChild(liElement);
    }

    function deleteItem(ev){
        ev.target.parentNode.remove();
    }

    function clearList(ev){
        const unorderedList = ev.target.parentNode.children[1];
        unorderedList.innerHTML = '';
    }

    function createEl(type, content, parent){
        const el = document.createElement(type);
        el.textContent = content;

        if(parent !== undefined){
            parent.appendChild(el);
        }

        return el;
    }
}
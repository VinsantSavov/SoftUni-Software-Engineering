function addItem() {
    const ulElement = document.getElementById('items');
    const text = document.getElementById('newText').value;
    const liElement = document.createElement('li');
    const link = document.createElement('a');
    link.textContent = '[Delete]';
    link.href = '#';
    link.addEventListener('click', deleteElement);

    liElement.textContent = text;
    liElement.appendChild(link);
    ulElement.appendChild(liElement);

    function deleteElement(ev){
        ev.target.parentNode.remove();
    }
}
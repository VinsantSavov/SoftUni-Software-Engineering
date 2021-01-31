function addItem() {
    const ulElement =   document.getElementById('items');
    const text = document.getElementById('newItemText').value;
    const liElement = document.createElement('li');
    liElement.textContent = text;

    ulElement.appendChild(liElement);
}
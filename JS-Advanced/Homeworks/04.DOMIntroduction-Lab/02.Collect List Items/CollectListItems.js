function extractText() {
    const items = document.getElementsByTagName('li');
    const textArea = document.querySelector('#result');

    for(let item of items){
        textArea.textContent += item.textContent + '\n';
    }
}
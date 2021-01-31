function focus() {
    const divs = Array.from(document.querySelector('body div').children);

    for(let div of divs){
        const inputEl = div.children[1];
        inputEl.addEventListener('focus', onFocus);
        inputEl.addEventListener('blur', onBlur);
    }

    function onFocus(ev){
        ev.target.parentNode.classList.add('focused');
    }

    function onBlur(ev){
        ev.target.parentNode.removeAttribute('class');
    }
}
function solution() {
    const [listOfGifts, sentGifts, discardedGifts] = document.querySelectorAll('section ul');
    const input = document.querySelector('section div input[type=text]');
    document.querySelector('section div button').addEventListener('click', addGift);

    function addGift(ev){
        if(input.value == ''){
            return;
        }

        const li = e('li', input.value, 'gift');
        const sendButton = e('button', 'Send', '', send);
        sendButton.setAttribute('id', 'sendButton');
        const discardButton = e('button', 'Discard', '', discard);
        discardButton.setAttribute('id', 'discardButton');
        li.appendChild(sendButton);
        li.appendChild(discardButton);
        input.value = '';

        listOfGifts.appendChild(li);
        const sorted = Array.from(listOfGifts.children).sort((a, b) => a.textContent.localeCompare(b.textContent));
        sorted.forEach(i => listOfGifts.appendChild(i));
    }

    function send(ev){
        const li = e('li', ev.target.parentNode.textContent.replace('SendDiscard', ''), 'gift');
        ev.target.parentNode.remove();

        sentGifts.appendChild(li);
    }

    function discard(ev){
        const li = e('li', ev.target.parentNode.textContent.replace('SendDiscard', ''), 'gift');
        ev.target.parentNode.remove();

        discardedGifts.appendChild(li);
    }

    function e(type, text, className, event){
        const result = document.createElement(type);
        result.textContent = text;

        if(className){
            result.className = className;
        }

        if(event){
            result.addEventListener('click', event);
        }
        return result;
    }
}
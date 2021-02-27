function solution() {
    document.querySelector('div[class=container]').addEventListener('click', onButtonClick);
    const giftInput = document.querySelector('section div input');
    const giftsLists = document.querySelectorAll('section > ul');

    function onButtonClick(ev){

        if(ev.target.tagName != 'BUTTON'){
            return;
        }

        if(ev.target.textContent == 'Add gift'){
            addGift();
        }else {
            const giftLi = ev.target.parentNode;

            let text = giftLi.textContent.replace('SendDiscard', '');
            const li = document.createElement('li');
            li.classList.add('gift');
            li.textContent = text;

            if(ev.target.textContent == 'Send'){
                giftsLists[1].appendChild(li);
            }else{
                giftsLists[2].appendChild(li);
            }

            giftLi.remove();
        }

    }

    function addGift(){
        const giftName = giftInput.value;
        giftInput.value = '';

        const li = document.createElement('li');
        li.classList.add('gift');
        li.textContent = giftName;

        const sendButton = document.createElement('button');
        sendButton.setAttribute('id', 'sendButton');
        sendButton.textContent = 'Send';
        //sendButton.addEventListener('click', onButtonClick);

        const discardButton = document.createElement('button');
        discardButton.setAttribute('id', 'discardButton');
        discardButton.textContent = 'Discard';
        //discardButton.addEventListener('click', onButtonClick);

        li.appendChild(sendButton);
        li.appendChild(discardButton);

        giftsLists[0].appendChild(li);
        const sorted = Array.from(giftsLists[0].children).sort((a, b) => a.textContent.localeCompare(b.textContent));
        giftsLists[0].textContent = '';
        sorted.forEach(s => giftsLists[0].appendChild(s));
    }
}
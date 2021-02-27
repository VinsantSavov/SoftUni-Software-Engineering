function encodeAndDecodeMessages() {
    const sendTextArea = document.querySelector('div textarea');
    const receiveTextArea = document.querySelector('div textarea[placeholder="No messages..."]');

    sendTextArea.parentNode.children[2].addEventListener('click', encodeAndSend);
    receiveTextArea.parentNode.children[2].addEventListener('click', decodeAndRead);

    function encodeAndSend(ev){
        let text = sendTextArea.value;

        if(text != ''){
            let encoded = '';

            for(let symbol of text){
                let ascii = symbol.charCodeAt(0) + 1;
                encoded += String.fromCharCode(ascii);
            }
    
            sendTextArea.value = '';
            receiveTextArea.value = encoded;
            receiveTextArea.parentNode.children[2].disabled = false;
        }
    }

    function decodeAndRead(ev){
        let text = receiveTextArea.value;
        let decoded = '';

        for(let symbol of text){
            let ascii = symbol.charCodeAt(0) - 1;
            decoded += String.fromCharCode(ascii);
        }

        receiveTextArea.value = decoded;
        receiveTextArea.parentNode.children[2].disabled = true;
    }
}
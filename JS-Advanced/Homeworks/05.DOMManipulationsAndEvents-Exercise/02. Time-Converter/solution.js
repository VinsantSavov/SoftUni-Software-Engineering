function attachEventsListeners() {
    const converter = {
        'daysBtn hours': (num) => num * 24,
        'daysBtn minutes': (num) => num * 24 * 60,
        'daysBtn seconds': (num) => num * 24 * 60 * 60,

        'hoursBtn days': (num) => num / 24,
        'hoursBtn minutes': (num) => num * 60,
        'hoursBtn seconds': (num) => num * 60 * 60,

        'minutesBtn hours': (num) => num / 60,
        'minutesBtn days': (num) => num / 24 / 60,
        'minutesBtn seconds': (num) => num * 60,

        'secondsBtn hours': (num) => num / 60 / 60,
        'secondsBtn minutes': (num) => num / 60,
        'secondsBtn days': (num) => num / 24 / 60 / 60,
    }

    const main = document.getElementsByTagName('main')[0];
    const inputs = document.querySelectorAll('main > div > input[type="text"]');
    main.addEventListener('click', onClick);

    function onClick(ev){
        if(ev.target.nodeName == 'INPUT' && ev.target.defaultValue == 'Convert'){
            const text = ev.target.parentNode.querySelector('input[type="text"]');
            const number = Number(text.value);

            for(let input of inputs){
                if(input.id != text.id){
                    input.value = converter[`${ev.target.id} ${input.id}`](number);
                }
            }
        }
    }
}
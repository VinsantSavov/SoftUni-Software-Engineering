function lockedProfile() {
    document.getElementById('main').addEventListener('click', onClick);
    const profiles = document.querySelectorAll('main > .profile');

    function onClick(ev){
        if(ev.target.tagName == 'BUTTON'){
            const profile = ev.target.parentNode;
            const isLocked = profile.querySelector('input[value="lock"]').checked;

            if(isLocked == false){
                const hiddenInfo = profile.querySelector('div');
                hiddenInfo.style.display = ev.target.innerHTML == 'Show more' ? 'inline' : 'none';

                ev.target.innerHTML = ev.target.innerHTML == 'Show more' ? 'Hide it' : 'Show more';
            }
        }
    }
}
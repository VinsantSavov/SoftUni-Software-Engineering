function attachGradientEvents() {
    const result = document.getElementById('result');
    const gradient = document.getElementById('gradient');

    gradient.addEventListener('mousemove', onMoving);

    function onMoving(ev){
        let percent = Math.floor(ev.offsetX / 299 * 100);
        result.textContent = `${percent}%`;
    }
}
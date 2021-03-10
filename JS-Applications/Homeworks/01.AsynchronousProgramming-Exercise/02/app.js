function solve() {
    const span = document.querySelector('#info span');
    const departBtn = document.getElementById('depart');
    const arriveBtn = document.getElementById('arrive');

    let info = {
        next: 'depot'
    };

    async function depart() {
        const url = `http://localhost:3030/jsonstore/bus/schedule/${info.next}`;

        try{
            const response = await fetch(url);
            if(!response.ok){
                throw new Error();
            }

            const data = await response.json();
            info = data;
            span.textContent = `Next stop ${info.name}`;
            departBtn.setAttribute('disabled', 'true');
            arriveBtn.removeAttribute('disabled');
        }catch(ex){
            span.textContent = `Error`;
            departBtn.setAttribute('disabled', 'true');
            arriveBtn.removeAttribute('disabled');
        }
    }

    function arrive() {
        span.textContent = `Arriving at ${info.name}`;
        departBtn.removeAttribute('disabled');
        arriveBtn.setAttribute('disabled', 'true');
    }

    return {
        depart,
        arrive
    };
}

let result = solve();
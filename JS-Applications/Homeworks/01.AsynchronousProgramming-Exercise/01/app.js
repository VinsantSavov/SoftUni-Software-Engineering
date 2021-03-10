async function getInfo() {
    const input = document.getElementById('stopId');
    const divStop = document.getElementById('stopName');
    const ulBuses = document.getElementById('buses');

    const url = `http://localhost:3030/jsonstore/bus/businfo/${input.value}`;
    input.value = '';
    divStop.textContent = '';
    ulBuses.textContent = '';

    try{
        const response = await fetch(url);
        if(!response.ok){
            throw new Error('Error');
        }

        const data = await response.json();
    
        divStop.textContent = data.name;    
        
        for(const [key, value]  of Object.entries(data.buses)){
            const li = document.createElement('li');
            li.textContent = `Bus ${key} arrives in ${value} minutes`;
            ulBuses.appendChild(li);
        }
    }catch(ex){
        divStop.textContent = 'Error';
    }
}
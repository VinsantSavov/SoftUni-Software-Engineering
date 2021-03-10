function attachEvents() {
    const locationInput = document.getElementById('location');
    const forecast = document.getElementById('forecast');
    const symbols = {
        'Sunny': '&#x2600',
        'Partly sunny': '&#x26C5',
        'Overcast': '&#x2601',
        'Rain': '&#x2614',
        'Degrees': '&#176',
    };
    document.getElementById('submit').addEventListener('click', loadForecast);

    async function loadForecast(){
        const locationsUrl = 'http://localhost:3030/jsonstore/forecaster/locations';
    
        try{
            const response = await fetch(locationsUrl);
    
            if(!response.ok){
                throw new Error();
            }
    
            const data = await response.json();
            const location = data.find(l => l.name.toLowerCase() == locationInput.value.toLowerCase());
    
            if(location == undefined){
                throw new Error('Invalid location name');
            }
    
            forecast.style.display = 'block';
            loadCurrentConditions(location.code);
            loadThreeDayForecast(location.code);
    
        }catch{
            forecast.style.display = 'block';
            const span = e('span', 'Error');
            forecast.appendChild(span);
        }
    
    }

    async function loadCurrentConditions(code){
        const current = forecast.children[0];
        const url = `http://localhost:3030/jsonstore/forecaster/today/${code}`;
    
        const response = await fetch(url);

        if(!response.ok){
            throw new Error();
        }

        const data = await response.json();
    
        const divForecast = e('div', '', 'forecasts');
        const spanSymbol = e('span', symbols[data.forecast.condition], 'condition symbol');
        const spanCondition = e('span', '', 'condition');
        const spanLocation = e('span', data.name, 'forecast-data');
        const spanTemp = e('span', `${data.forecast.low}${symbols['Degrees']}/${data.forecast.high}${symbols['Degrees']}`, 'forecast-data');
        const span = e('span', data.forecast.condition, 'forecast-data');
    
        spanCondition.appendChild(spanLocation);
        spanCondition.appendChild(spanTemp);
        spanCondition.appendChild(span);

        divForecast.appendChild(spanSymbol);
        divForecast.appendChild(spanCondition);
    
        current.appendChild(divForecast);
    }
    
    async function loadThreeDayForecast(code){
        const url = `http://localhost:3030/jsonstore/forecaster/upcoming/${code}`;
    
        const response = await fetch(url);
        if(!response.ok){
            throw new Error();
        }

        const data = await response.json();
        const divInfo = e('div', '', 'forecast-info');

        data.forecast.forEach(f => {
            const spanUpcoming = e('span', '', 'upcoming');
            const spanSymbol = e('span', symbols[f.condition], 'symbol');
            const spanTemp = e('span', `${f.low}${symbols['Degrees']}/${f.high}${symbols['Degrees']}`, 'forecast-data');
            const span = e('span', f.condition, 'forecast-data');

            spanUpcoming.appendChild(spanSymbol);
            spanUpcoming.appendChild(spanTemp);
            spanUpcoming.appendChild(span);
            divInfo.appendChild(spanUpcoming);
        });

        forecast.children[1].appendChild(divInfo);
    }
    
    function e(type, text, className){
        const result = document.createElement(type);
        result.innerHTML = text;
    
        if(className){
            result.className = className;
        }
    
        return result;
    }
}

attachEvents();
function addDestination(ev){
    const [city, country] = document.querySelectorAll('#input input[class=inputData]');
    const season = document.querySelector('#seasons');
    const destinationsList = document.querySelector('#destinationsList');

    if(city.value == '' || country.value == ''){
        return;
    }

    const tr = e('tr', '');
    const cityCountryTd = e('td', city.value + ', ' + country.value);
    const seasonTd = e('td', season.value.slice(0, 1).toUpperCase() + season.value.slice(1));

    tr.appendChild(cityCountryTd);
    tr.appendChild(seasonTd);
    destinationsList.appendChild(tr);

    const count = document.querySelector(`#${season.value}`);
    count.value++;

    city.value = '';
    country.value = '';
    season.value = 'summer';

    function e(type, text){
        const result = document.createElement(type);
        result.textContent = text;

        return result;
    }
}
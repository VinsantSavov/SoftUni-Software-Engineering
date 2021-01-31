function attachEventsListeners() {
    document.getElementById('convert').addEventListener('click', onClick);
    const fromSelect = document.getElementById('inputUnits');
    const toSelect = document.getElementById('outputUnits');
    const input = document.getElementById('inputDistance');
    const output = document.getElementById('outputDistance');
    const converter = {
        'km m': (num) => num * 1000,
        'm m': (num) => num,
        'cm m': (num) => num * 0.01,
        'mm m': (num) => num * 0.001,
        'mi m': (num) => num * 1609.34,
        'yrd m': (num) => num * 0.9144,
        'ft m': (num) => num * 0.3048,
        'in m': (num) => num * 0.0254,

        'm km': (num) => num / 1000,
        'm m': (num) => num,
        'm cm': (num) => num / 0.01,
        'm mm': (num) => num / 0.001,
        'm mi': (num) => num / 1609.34,
        'm yrd': (num) => num / 0.9144,
        'm ft': (num) => num / 0.3048,
        'm in': (num) => num / 0.0254,
    }

    function onClick(ev){
        const num = Number(input.value);

        output.value = converter[`m ${toSelect.value}`](converter[`${fromSelect.value} m`](input.value));
    }
}
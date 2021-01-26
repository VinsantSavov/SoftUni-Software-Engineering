function generateReport(colNames) {
    const headers = document.querySelectorAll('tr th');
    const rows = document.querySelectorAll('tbody tr');
    const report = {};
    const result = [];

    for(let i = 0; i < headers.length; i++){
        let name = headers[i].textContent.trim();

        if(headers[i].children[0].checked == true){
            report[name] = {};
            report[name].id = i;
        }
    }

    for(let row = 0; row < rows.length; row++){
        const cols = rows[row].children;
        const line = {};

        for(let item in report){
            line[item.toLocaleLowerCase()] = cols[report[item].id].textContent;
        }

        result.push(line);
    }

    let resultAsJson = JSON.stringify(result);

    document.getElementById('output').textContent = resultAsJson;
}
function convert(input){
    let converted = JSON.parse(input);
    let result = '';
    let headers = '';
    let cols = '';
    result += '<table>\n';

    const keys = Object.keys(converted[0]);
        
    headers += '   <tr>';
    for(let key of keys){
        if(typeof key == 'number'){
            headers += `<th>${key}</th>`;
        }else{
            headers += `<th>${escape(key)}</th>`;
        }
        
    }
    headers += '</tr>\n';

    for(let i = 0; i < converted.length; i++){

        cols += '   <tr>';
        for(let key of keys){
            if(typeof key == 'number'){
                cols += `<td>${converted[i][key]}</td>`;
            }else{
                cols += `<td>${escape(converted[i][key])}</td>`;
            }
        }
        cols += '</tr>\n';
    }

    result += headers;
    result += cols;
    result += '</table>';

    return result.trim();
}

console.log(convert("[{\"Name\":\"Stamat\",\"Score\":5.5},{\"Name\":\"Rumen\",\"Score\":6}]"));
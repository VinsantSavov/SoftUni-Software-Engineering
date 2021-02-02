function solve(data, criteria){
    let info = JSON.parse(data);
    let result = [];
    let count = 0;
    const args = criteria.split('-');

    for(let input of info){
        if(filterData.call(input, args[0], args[1])){
            result.push(`${count}. ${input.first_name} ${input.last_name} - ${input.email}`);
            count++;
        }
    }

    return result.join('\n');

    function filterData(prop, value){
        const key = Object.keys(this).find(k => k == prop);

        if(this[key] == value){
            return true;
        }

        return false;
    }
}

console.log(solve(`[{
    "id": "1",
    "first_name": "Ardine",
    "last_name": "Bassam",
    "email": "abassam0@cnn.com",
    "gender": "Female"
  }, {
    "id": "2",
    "first_name": "Kizzee",
    "last_name": "Jost",
    "email": "kjost1@forbes.com",
    "gender": "Female"
  },  
{
    "id": "3",
    "first_name": "Evanne",
    "last_name": "Maldin",
    "email": "emaldin2@hostgator.com",
    "gender": "Male"
  }]`, 
'gender-Female'
));
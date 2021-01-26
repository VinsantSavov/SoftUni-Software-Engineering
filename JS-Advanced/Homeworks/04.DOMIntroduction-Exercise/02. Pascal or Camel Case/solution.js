function solve() {
  const words = document.getElementById('text').value.split(' ');
  const convention = document.getElementById('naming-convention').value;
  let output = '';

  switch(convention){
    case 'Camel Case':
      output = getCamelCase(words);
      break;
    case 'Pascal Case':
      output = getPascalCase(words);
      break;
    default:
      output = 'Error!';
      break;
  }

  document.getElementById('result').textContent = output;

  function getCamelCase(words){
    let result = words.reduce((acc, curr, i) => {
      curr = curr.toLowerCase();

      if(i == 0){
        return acc += curr;
      }

      return acc += curr[0].toUpperCase() + curr.slice(1);
    }, '');

    return result;
  }

  function getPascalCase(words){
    let result = words.reduce((acc, curr) => {
      curr = curr.toLowerCase();
      return acc += curr[0].toUpperCase() + curr.slice(1);
    }, '');

    return result;
  }
}
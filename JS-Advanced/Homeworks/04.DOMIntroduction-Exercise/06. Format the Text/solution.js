function solve() {
  const sentences = document.getElementById('input').value.split('.').filter(s => s.length > 1);
  const output = document.getElementById('output');
  const arr = [];
  let paragraph = '';

  for(let i = 1; i <= sentences.length; i++){
    paragraph += sentences[i-1];

    if(i % 3 == 0){
      arr.push(paragraph + '.');
      paragraph = '';
    }
  }

  if(paragraph != ''){
    arr.push(paragraph + '.');
  }

  for(let i = 0; i < arr.length; i++){
    output.innerHTML += `<p>${arr[i]}</p>`;
  }


}
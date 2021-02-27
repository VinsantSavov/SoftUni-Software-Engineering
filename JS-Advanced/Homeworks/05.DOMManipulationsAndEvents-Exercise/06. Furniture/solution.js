function solve() {
  const textarea = document.querySelector('#exercise > textarea');
  const resultArea = document.querySelector('#exercise > textarea[rows="4"]');
  const tableBody = document.querySelector('.table tbody');
  document.querySelector('#exercise > button').addEventListener('click', onGenerate);
  document.querySelectorAll('#exercise button')[1].addEventListener('click', onBuy);

  function onGenerate(){
    const items = JSON.parse(textarea.value);
    textarea.value = '';

    for(let item of items){
      const tr = document.createElement('tr');

      const img = document.createElement('img');
      const imgTd = document.createElement('td');
      img.src = item.img;
      imgTd.appendChild(img);

      const pName = document.createElement('p');
      const nameTd = document.createElement('td');
      pName.textContent = item.name;
      nameTd.appendChild(pName);

      const pPrice = document.createElement('p');
      const priceTd = document.createElement('td');
      pPrice.textContent = item.price;
      priceTd.appendChild(pPrice);

      const pFactor = document.createElement('p');
      const factorTd = document.createElement('td');
      pFactor.textContent = item.decFactor;
      factorTd.appendChild(pFactor);

      const input = document.createElement('input');
      const inputTd = document.createElement('td');
      input.setAttribute('type', 'checkbox');
      inputTd.appendChild(input);
      
      tr.appendChild(imgTd);
      tr.appendChild(nameTd);
      tr.appendChild(priceTd);
      tr.appendChild(factorTd);
      tr.appendChild(inputTd);

      tableBody.appendChild(tr);
    }  
  }

  function onBuy(){
    const boughtItems = [];

    for(let row of Array.from(tableBody.children)){
      if(row.children[4].children[0].checked === true){
        const cols = row.querySelectorAll('td > p');

        boughtItems.push({
          name: cols[0].textContent,
          price: Number(cols[1].textContent),
          dec: Number(cols[2].textContent),
        });
      }
    }

    const boughtFurniture = boughtItems.reduce((acc, c, i) => {
      if(i == boughtItems.length - 1){
        return acc += c.name;
      }
      return acc += `${c.name}, `;

    }, '');
    const totalPrice = boughtItems.reduce((acc, c) => acc += c.price, 0);
    const averageFactor = boughtItems.reduce((acc, c) => acc += c.dec, 0) / boughtItems.length;

    resultArea.value = `Bought furniture: ${boughtFurniture}\nTotal price: ${totalPrice.toFixed(2)}\nAverage decoration factor: ${averageFactor}`;
  }
}
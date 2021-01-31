function create(words) {
   const content = document.getElementById('content');
   
   for(let string of words){
      const divElement = document.createElement('div');
      const pElement = document.createElement('p');
      pElement.style.display = 'none';
      pElement.textContent = string;

      divElement.appendChild(pElement);
      divElement.addEventListener('click', (ev) => {
         ev.target.children[0].style.display = 'inline';
      });

      content.appendChild(divElement);
   }
}
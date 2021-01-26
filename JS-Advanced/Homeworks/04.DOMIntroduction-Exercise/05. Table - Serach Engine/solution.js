function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const searchString = document.getElementById('searchField').value.toLocaleLowerCase();
      const rows = document.querySelectorAll('tbody tr');

      if(searchString == ''){
         return;
      }

      for(let row = 0; row < rows.length; row++){
         if(rows[row].textContent.toLocaleLowerCase().includes(searchString)){
            rows[row].classList.add('select');
         }else{
            rows[row].removeAttribute('class');
         }
      }

      document.getElementById('searchField').value = '';
   }
}
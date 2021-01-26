function search() {
   const towns = document.getElementsByTagName('li');
   const searchString = document.getElementById('searchText').value;
   const result = document.getElementById('result');
   let count = 0;

   for(let i = 0; i < towns.length; i++){
      if(towns[i].textContent.toLocaleLowerCase().includes(searchString.toLocaleLowerCase())){
         towns[i].style.fontWeight = 'bolder';
         towns[i].style.fontStyle = 'italic';
         count++;
      }
   }

   result.textContent = `${count} matches found`;
}

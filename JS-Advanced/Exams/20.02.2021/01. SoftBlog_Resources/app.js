function solve(){
   const postsSection = document.querySelector('main section');
   const archiveList = document.querySelector('section[class=archive-section] ol');

   const creator = document.querySelector('#creator');
   const title = document.querySelector('#title');
   const category = document.querySelector('#category');
   const content = document.querySelector('#content');
   document.querySelector('section form button').addEventListener('click', addPost);

   function addPost(ev){
      ev.preventDefault();

      const article = e('article', '');
      const h1 = e('h1', title.value);
      const pCategory = e('p', 'Category:');
      const strongCategory = e('strong', category.value);
      const pCreator = e('p', 'Creator:');
      const strongCreator = e('strong', creator.value);
      const pContent = e('p', content.value);
      const div = e('div', '', 'buttons');
      const delBtn = e('button', 'Delete', 'btn delete', onDelete);
      const arcBtn = e('button', 'Archive', 'btn archive', onArchive);

      pCategory.appendChild(strongCategory);
      pCreator.appendChild(strongCreator);
      div.appendChild(delBtn);
      div.appendChild(arcBtn);

      article.appendChild(h1);
      article.appendChild(pCategory);
      article.appendChild(pCreator);
      article.appendChild(pContent);
      article.appendChild(div);

      postsSection.appendChild(article);
   }

   function onDelete(ev){
      ev.target.parentNode.parentNode.remove();
   }

   function onArchive(ev){
      const article = ev.target.parentNode.parentNode;
      const title = article.children[0].textContent;

      const li = e('li', title);
      archiveList.appendChild(li);
      const items = Array.from(archiveList.children).sort((a, b) => a.textContent.localeCompare(b.textContent));
      items.forEach(i => archiveList.appendChild(i));

      article.remove();
   }

   function e(type, text, className, event){
      const result = document.createElement(type);
      result.textContent = text;

      if(className){
         result.className = className;
      }
      if(event){
         result.addEventListener('click', event);
      }

      return result;
   }
}

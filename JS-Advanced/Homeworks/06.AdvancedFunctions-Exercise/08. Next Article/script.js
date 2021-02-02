function getArticleGenerator(articles) {
    const arts = articles;
    const content = document.getElementById('content');
    let count = 0;

    return display;

    function display(){

        if(count < arts.length){
            const p = document.createElement('p');
            p.textContent = arts[count];
            if(count == 0){
                content.appendChild(p);
            }else{
                content.insertBefore(p, content.firstChild);
            }
            //content.insertAdjacentElement('afterbegin', p);
            count++;
        }
        /*if(arts.length > 0){
            content.textContent = arts.shift();
        }*/
    }
}

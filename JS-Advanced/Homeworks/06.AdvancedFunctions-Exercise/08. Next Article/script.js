function getArticleGenerator(articles) {
    const arts = articles;
    const content = document.getElementById('content');

    return display;

    function display(){
        if(arts.length > 0){
            const art = arts.shift();
            const div = document.createElement('article');
            div.textContent = art;

            content.insertBefore(div, content.firstChild);
        }
    }
}

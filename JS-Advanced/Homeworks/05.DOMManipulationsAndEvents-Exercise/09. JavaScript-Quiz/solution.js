function solve() {
    document.getElementById('quizzie').addEventListener('click', onClick);
    const sections = document.querySelectorAll('#quizzie section');
    const result = document.querySelector('#results li h1');
    let secCount = 0;
    const answers = [];
    const correctAnswers = ['onclick', 'JSON.stringify()', 'A programming API for HTML and XML documents'];

    function onClick(ev){
      if(ev.target.nodeName == 'P' && ev.target.className == 'answer-text'){
        const value = ev.target.innerHTML;
        const section = ev.target.parentNode.parentNode.parentNode.parentNode;
        section.style.display = 'none';

        answers.push(value);
        secCount++;
        if(secCount < sections.length){
          sections[secCount].removeAttribute('class');
          sections[secCount].style.display = 'block';
        }else{
          document.getElementById('results').style.display = 'block';
          let mark = answers.filter(a => correctAnswers.includes(a));

          if(mark.length == 3){
            result.textContent = 'You are recognized as top JavaScript fan!';
          }else{
            result.textContent = `You have ${mark.length} right answers`;
          }
        }
      }
    }
}

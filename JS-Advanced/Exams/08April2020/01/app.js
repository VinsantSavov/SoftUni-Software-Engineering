function solve() {
    const [addTask, open, inProgress, complete] = document.querySelectorAll('section');

    const taskNameInput = addTask.querySelector('#task');
    const descriptionInput = addTask.querySelector('#description');
    const dateInput = addTask.querySelector('#date');
    document.querySelector('#add').addEventListener('click', onAdd);

    function onAdd(ev){
        ev.preventDefault();

        if(taskNameInput.value == '' || descriptionInput.value == '' || dateInput.value == ''){
            return;
        }

        const article = e('article');
        const h3 = e('h3', taskNameInput.value);
        const descriptionP = e('p', `Description: ${descriptionInput.value}`);
        const dateP = e('p', `Due Date: ${dateInput.value}`);
        const div = e('div', '', 'flex');
        const startButton = e('button', 'Start', 'green', startTask);
        const deleteButton = e('button', 'Delete', 'red', deleteTask);

        /*taskNameInput.value = '';
        descriptionInput.value = '';
        dateInput.value = '';*/

        div.appendChild(startButton);
        div.appendChild(deleteButton);

        article.appendChild(h3);
        article.appendChild(descriptionP);
        article.appendChild(dateP);
        article.appendChild(div);

        const openDiv = open.children[1];
        openDiv.appendChild(article);
    }

    function startTask(ev){
        const article = ev.target.parentNode.parentNode;
        article.querySelector('button[class=green]').remove();
        const finishButton = e('button', 'Finish', 'orange', finishTask);
        article.querySelector('div[class=flex]').appendChild(finishButton);

        const inProgressDiv = inProgress.children[1];
        inProgressDiv.appendChild(article);
    }

    function deleteTask(ev){
        ev.target.parentNode.parentNode.remove();
    }

    function finishTask(ev){
        const article = ev.target.parentNode.parentNode;
        article.querySelector('div .flex').remove();
        
        const completedDiv = complete.children[1];
        completedDiv.appendChild(article);
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
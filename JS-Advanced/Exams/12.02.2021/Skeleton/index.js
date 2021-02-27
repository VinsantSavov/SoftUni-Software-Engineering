function solve() {
    const lectureInput = document.querySelector('form div input[name=lecture-name]');
    const dataInput = document.querySelector('form div input[name=lecture-date]');
    const moduleInput = document.querySelector('form div select[name=lecture-module]');
    const modules = document.querySelector('section div[class=modules]');
    const addbutton = document.querySelector('form div>button');

    addbutton.addEventListener('click', onAdd);

    //check for valid date
    function onAdd(ev){
        ev.preventDefault();

        if(lectureInput.value == '' || dataInput.value == '' 
        || dataInput.value.includes('mm') || moduleInput.value == '' 
        || moduleInput.value.includes('Select module')){
            return;
        }

        if(modules.textContent.includes(moduleInput.value.toUpperCase())){
            const ulModule = Array.from(document.querySelectorAll('div[class=modules] > div[class=module]'))
                                     .find(m => m.textContent.includes(moduleInput.value.toUpperCase()))
                                     .querySelector('ul');
            
            const li = document.createElement('li');
            li.setAttribute('class', 'flex');
            const header = document.createElement('h4');
            const date = dataInput.value.split('T');
            header.textContent = `${lectureInput.value} - ${date[0].split('-').join('/')} - ${date[1]}`;
            const delButton = document.createElement('button');
            delButton.setAttribute('class', 'red');
            delButton.textContent = 'Del';
            delButton.addEventListener('click', onDelete);

            li.appendChild(header);
            li.appendChild(delButton);

            ulModule.appendChild(li);

            const headers = Array.from(document.querySelectorAll('div[class=modules] > div[class=module] > ul li')).sort((a, b) => {
                const firstDate = a.children[0].textContent.split(' - ')[1];
                const secondDate = b.children[0].textContent.split(' - ')[1];

                return firstDate.localeCompare(secondDate);
            });
            ulModule.textContent = '';
            headers.forEach(h => ulModule.appendChild(h));
        }else{
            const module = document.createElement('div');
            module.setAttribute('class', 'module');

            const hModule = document.createElement('h3');
            hModule.textContent = moduleInput.value.toUpperCase() + '-MODULE';

            const ul = document.createElement('ul');
            const li = document.createElement('li');
            li.setAttribute('class', 'flex');

            const header = document.createElement('h4');
            const date = dataInput.value.split('T');
            header.textContent = `${lectureInput.value} - ${date[0].split('-').join('/')} - ${date[1]}`;
            const delButton = document.createElement('button');
            delButton.setAttribute('class', 'red');
            delButton.textContent = 'Del';
            delButton.addEventListener('click', onDelete);

            li.appendChild(header);
            li.appendChild(delButton);
            ul.appendChild(li);
            module.appendChild(hModule);
            module.appendChild(ul);

            modules.appendChild(module);
        }
    }

    function onDelete(ev){
        const count = ev.target.parentNode.parentNode.children.length;

        if(count == 1){
            ev.target.parentNode.parentNode.parentNode.remove();
        }else{
            ev.target.parentNode.remove();
        }
    }
};
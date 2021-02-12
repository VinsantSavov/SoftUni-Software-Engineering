class Contact{
    constructor(firstName, lastName, phone, email){
        this.firstName = firstName;
        this.lastName = lastName;
        this.phone = phone;
        this.email = email;
        this._online = false;
    }

    get online(){
        return this._online;
    }

    set online(value){
        const title = Array.from(document.querySelectorAll('div .title')).find(t => t.textContent.includes(`${this.firstName} ${this.lastName}`));
        if(title != null){
            if(value == true){
                title.classList.add('online');
            }else{
                title.classList.remove('online');
            }
        }

        this._online = value;
    }

    render(id){
        const element = document.getElementById(id);

        const article = document.createElement('article');
        const titleDiv = document.createElement('div');
        titleDiv.classList.add('title');
        //titleDiv.setAttribute('id', this.email);
        if(this.online){
            titleDiv.classList.add('online');
        }
        titleDiv.textContent = `${this.firstName} ${this.lastName}`;
        const button = document.createElement('button');
        button.textContent = '&#8505;';
        button.addEventListener('click', (ev) => {
            const type = ev.target.parentNode.parentNode.lastChild.style.display == 'none' ? 'block' : 'none';
            ev.target.parentNode.parentNode.lastChild.style.display = type;
        })
        titleDiv.appendChild(button);

        const divInfo = document.createElement('div');
        divInfo.classList.add('info');
        divInfo.style.display = 'none';
        const spanPhone = document.createElement('span');
        spanPhone.textContent = '&phone; ' + this.phone;
        const spanEmail = document.createElement('span');
        spanEmail.textContent = '&#9993; ' + this.email;
        divInfo.appendChild(spanPhone);
        divInfo.appendChild(spanEmail);

        article.appendChild(titleDiv);
        article.appendChild(divInfo);

        element.appendChild(article);
    }
}

function sample(){
    let contacts = [
        new Contact("Ivan", "Ivanov", "0888 123 456", "i.ivanov@gmail.com"),
        new Contact("Maria", "Petrova", "0899 987 654", "mar4eto@abv.bg"),
        new Contact("Jordan", "Kirov", "0988 456 789", "jordk@gmail.com")
      ];
      contacts.forEach(c => c.render('main'));
      contacts.forEach(c => c.online = true);
      
      // After 1 second, change the online status to true
      setTimeout(() => contacts[1].online = true, 2000);
      
}
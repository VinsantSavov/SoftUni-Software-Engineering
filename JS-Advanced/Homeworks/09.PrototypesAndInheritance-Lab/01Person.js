function solve(firstName, lastName){
    class Person{
        constructor(firstName, lastName){
            this.firstName = firstName;
            this.lastName = lastName;
        }

        get firstName(){
            return this._firstName;
        }

        set firstName(value){
            return this._firstName = value;
        }

        get lastName(){
            return this._lastName;
        }

        set lastName(value){
            this._lastName = value
        }

        get fullName(){
            return `${this.firstName} ${this.lastName}`;
        }

        set fullName(value){
            const args = value.split(' ');

            if(args.length == 2){
                this.firstName = args[0];
                this.lastName = args[1];
            }
        }
    }

    return new Person(firstName, lastName);
}
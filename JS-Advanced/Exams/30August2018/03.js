class Vacationer{
    constructor(...params){
        if(params.length == 2){
            this.fullName = params[0];
            this.addCreditCardInfo(params[1]);
        }else{
            this.fullName = params[0];
            this.addCreditCardInfo([1111, '', 111]);
        }

        this.wishList = [];
        this.idNumber = this.generateIDNumber();
    }

    get fullName(){
        return this._fullName;
    }

    set fullName(value){
        if(value.length != 3){
            throw new Error('Name must include first name, middle name and last name');
        }

        if(value.some(n => !/^[A-Z][a-z]+$/.test(n))){
            throw new Error('Invalid full name');
        }

        this._fullName = {
            firstName: value[0],
            middleName: value[1],
            lastName: value[2],
        };
    }

    generateIDNumber(){
        const vowels = ["a", "e", "o", "i", "u"];
        const ascii = this.fullName.firstName.slice(0, 1).charCodeAt(0);
        const len = this.fullName.middleName.length;
        let res = 231 * ascii + 139 * len;

        const lastLetter = this.fullName.lastName.slice(this.fullName.lastName.length - 1);
        if(vowels.includes(lastLetter)){
            res = res.toString() + 8;
        }else{
            res = res.toString() + 7;
        }

        return res;
    }

    addCreditCardInfo(input){
        if(input.length != 3){
            throw new Error('Missing credit card information');
        }

        if(typeof input[0] != 'number' || typeof input[2] != 'number'){
            throw new Error('Invalid credit card details');
        }

        this.creditCard = {};
        this.creditCard.cardNumber = input[0];
        this.creditCard.expirationDate = input[1];
        this.creditCard.securityNumber = input[2];
    }

    addDestinationToWishList(destination){
        if(this.wishList.some(d => d == destination)){
            throw new Error('Destination already exists in wishlist');
        }

        this.wishList.push(destination);
        this.wishList = this.wishList.sort((a, b) => a.length - b.length);
    }

    getVacationerInfo(){
        let result = `Name: ${this.fullName.firstName} ${this.fullName.middleName} ${this.fullName.lastName}\nID Number: ${this.idNumber}\nWishlist:\n`;

        result += this.wishList.length == 0 ? 'empty' : this.wishList.join(', ');
        result += `\nCredit Card:\nCard Number: ${this.creditCard.cardNumber}\nExpiration Date: ${this.creditCard.expirationDate}\nSecurity Number: ${this.creditCard.securityNumber}`;

        return result;
    }
}

let vacationer1 = new Vacationer(["Vania", "Ivan0va", "Zhivkova"], ['123456']);
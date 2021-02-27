class Bank{
    constructor(bankName){
        this._bankName = bankName;
        this.allCustomers = [];
    }

    newCustomer(customer){
        if(this.allCustomers.some(c => c.firstName == customer.firstName 
                                    && c.lastName == customer.lastName 
                                    && c.personalId == customer.personalId)){
            throw new Error(`${customer.firstName} ${customer.lastName} is already our customer!`);
        }

        this.allCustomers.push({
            firstName: customer.firstName, 
            lastName: customer.lastName, 
            personalId: customer.personalId,
            totalMoney: 0,
            transactions: [], 
            id: 0
        });
        return customer;
    }

    depositMoney(personalId, amount){
        const customer = this.allCustomers.find(c => c.personalId == personalId);

        if(customer == null){
            throw new Error('We have no customer with this ID!');
        }

        customer.totalMoney += amount;
        customer.id++;
        customer.transactions.unshift(`${customer.id}. ${customer.firstName} ${customer.lastName} made deposit of ${amount}$!`);

        return `${customer.totalMoney}$`;
    }

    withdrawMoney(personalId, amount){
        const customer = this.allCustomers.find(c => c.personalId == personalId);

        if(customer == null){
            throw new Error('We have no customer with this ID!');
        }

        if(customer.totalMoney < amount){
            throw new Error(`${customer.firstName} ${customer.lastName} does not have enough money to withdraw that amount!`)
        }

        customer.totalMoney -= amount;
        customer.id++;
        customer.transactions.unshift(`${customer.id}. ${customer.firstName} ${customer.lastName} withdrew ${amount}$!`);

        return `${customer.totalMoney}$`;
    }

    customerInfo(personalId){
        const customer = this.allCustomers.find(c => c.personalId == personalId);
        let result = '';

        if(customer == null){
            throw new Error('We have no customer with this ID!');
        }

        result += `Bank name: ${this._bankName}\nCustomer name: ${customer.firstName} ${customer.lastName}\nCustomer ID: ${customer.personalId}\nTotal Money: ${customer.totalMoney}$\nTransactions:\n`;

        result += customer.transactions.join('\n');
        return result;
    }
}

let bank = new Bank('SoftUni Bank');

console.log(bank.newCustomer({firstName: 'Svetlin', lastName: 'Nakov', personalId: 6233267}));
console.log(bank.newCustomer({firstName: 'Mihaela', lastName: 'Mileva', personalId: 4151596}));

bank.depositMoney(6233267, 250);
console.log(bank.depositMoney(6233267, 250));
bank.depositMoney(4151596,555);

console.log(bank.withdrawMoney(6233267, 125));

console.log(bank.customerInfo(6233267));

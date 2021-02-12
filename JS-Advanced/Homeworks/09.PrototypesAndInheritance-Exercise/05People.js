function module(){
    class Employee{
        constructor(name, age){
            this.name = name;
            this.age = age;
            this.salary = 0;
            this.tasks = [];
        }
    
        work(){
        }
    
        collectSalary(){
            console.log(`${this.name} received ${this.salary} this month.`);
        }
    }
    
    class Junior extends Employee{
        constructor(name, age){
            super(name, age);
            this.tasks.push(`${this.name} is working on a simple task.`);
        }
    
        work(){
            console.log(this.tasks[0]);
        }
    }
    
    class Senior extends Employee{
        constructor(name, age){
            super(name, age);
            this.workId = 0;
            this.tasks.push(`${this.name} is working on a complicated task.`);
            this.tasks.push(`${this.name} is taking time off work.`);
            this.tasks.push(`${this.name} is supervising junior workers.`);
        }
    
        work(){
            if(this.workId >= this.tasks.length){
                this.workId = 0;
            }
    
            console.log(this.tasks[this.workId]);
            this.workId++;
        }
    }
    
    class Manager extends Employee{
        constructor(name, age){
            super(name, age);
            this.dividend = 0;
            this.workId = 0;
    
            this.tasks.push(`${this.name} scheduled a meeting.`);
            this.tasks.push(`${this.name} is preparing a quarterly report.`);
        }
    
        work(){
            if(this.workId >= this.tasks.length){
                this.workId = 0;
            }
    
            console.log(this.tasks[this.workId]);
            this.workId++;
        }
    
        collectSalary(){
            console.log(`${this.name} received ${this.salary + this.dividend} this month.`);
        }
    }

    return {Junior, Senior, Manager};
}
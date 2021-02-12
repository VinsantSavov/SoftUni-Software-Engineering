class Company{
    constructor(){
        this.departments = {};
    }

    addEmployee(...params){
        if(params.some(p => p == '' || p == null || p == undefined) || params.length < 4){
            throw new Error('Invalid input!');
        }

        if(params[1] <= 0){
            throw new Error('Invalid input!');
        }

        if(!Object.keys(this.departments).some(k => k == params[3])){
            let department = params[3];
            this.departments[department] = [];
        }
        this.departments[params[3]].push({username: params[0], salary: params[1], position: params[2]});

        return `New employee is hired. Name: ${params[0]}. Position: ${params[2]}`;
    }

    bestDepartment(){
        const getAverageSalary = (departmentName) => {
            return this.departments[departmentName].reduce((acc, c) => acc += c.salary, 0) / this.departments[departmentName].length;
        }

        let output = '';
        const best = Object.keys(this.departments).sort((a, b) => getAverageSalary(b) - getAverageSalary(a))[0];
        const employees = this.departments[best].sort((a, b) => {
            if(b.salary - a.salary == 0){
                return a.username.localeCompare(b.username);
            }
            
            return b.salary - a.salary;
        });

        output += `Best Department is: ${best}\n`;
        output += `Average salary: ${getAverageSalary(best).toFixed(2)}\n`;
        for(let emp of employees){
            output += `${emp.username} ${emp.salary} ${emp.position}\n`;
        }

        return output.trim();
    }
}

let c = new Company();
console.log(c.addEmployee("Stanimir", 2000, "engineer", "Construction"));
console.log(c.addEmployee("Pesho", 1500, "electrical engineer", "Construction"));
console.log(c.addEmployee("Slavi", 500, "dyer", "Construction"));
console.log(c.addEmployee("Stan", 2000, "architect", "Construction"));
console.log(c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing"));
console.log(c.addEmployee("Pesho", 1000, "graphical designer", "Marketing"));
console.log(c.addEmployee("Gosho", 1350, "HR", "Human resources"));
console.log(c.bestDepartment());

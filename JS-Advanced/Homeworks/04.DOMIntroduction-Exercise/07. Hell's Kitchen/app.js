function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick () {
      let val = document.querySelector('#inputs textarea').value;
      const input = JSON.parse(val);

      const bestRestaurant = document.querySelector('#bestRestaurant p');
      const workers = document.querySelector('#workers p');
      workers.textContent = '';
      const restaurants = {};

      for(let item of input){
         let info = item.split(' - ');
         let restaurant = info[0].trim();
         let workersInfo = info[1].split(/[, ]+/g);

         if(restaurants[restaurant] == undefined){
            restaurants[restaurant] = {};
            restaurants[restaurant].workers = [];
         }

         for(let i = 0; i < workersInfo.length; i+=2){
            const name = workersInfo[i].trim();
            const salary = Number(workersInfo[i+1]);

            restaurants[restaurant].workers.push({name: name, salary: salary});
         }

         restaurants[restaurant].averageSalary = restaurants[restaurant].workers.reduce((acc, curr) => acc + curr.salary, 0) / restaurants[restaurant].workers.length;
         restaurants[restaurant].bestSalary = restaurants[restaurant].workers.reduce((acc, curr) => {
            if(acc > curr.salary){
               return acc;
            }

            return curr.salary;
         }, 0)
         restaurants[restaurant].workers.sort((a, b) => b.salary - a.salary);
      }

      const topRestaurant = {name: '', workers: [], averageSalary: 0, bestSalary: 0};
      for(let curr in restaurants){
         if(restaurants[curr].averageSalary > topRestaurant.averageSalary){
            topRestaurant.name = curr;
            topRestaurant.workers = restaurants[curr].workers;
            topRestaurant.averageSalary = restaurants[curr].averageSalary;
            topRestaurant.bestSalary = restaurants[curr].bestSalary;
         }
      }

      bestRestaurant.textContent = `Name: ${topRestaurant.name} Average Salary: ${topRestaurant.averageSalary.toFixed(2)} Best Salary: ${topRestaurant.bestSalary.toFixed(2)}`;

      for(let w of topRestaurant.workers){
         workers.textContent += `Name: ${w.name} With Salary: ${w.salary} `;
      }
      
   }
}
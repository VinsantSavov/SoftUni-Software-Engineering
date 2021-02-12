function ticketDatabase(ticketsInput, criteria){
    class Ticket{
        constructor(destination, price, status){
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }    

    const tickets = [];

    for(let item of ticketsInput){
        const args = item.split('|');
        const ticket = new Ticket(args[0], Number(args[1]), args[2]);
        tickets.push(ticket);
    }

    if(criteria == 'price'){
        tickets.sort((a, b) => a.price - b.price);
    }else{
        tickets.sort((a, b) => a[criteria].localeCompare(b[criteria]));
    }

    return tickets;
}

console.log(ticketDatabase(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'destination'
));
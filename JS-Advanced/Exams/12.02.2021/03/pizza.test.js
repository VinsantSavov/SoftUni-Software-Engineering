const {expect} = require('chai');
const pizzUni = require('./pizza');

describe('pizza uni', () => {
    describe('make an order', () => {
        it('if order pizza is false should throw error', () => {
            expect(() => {pizzUni.makeAnOrder({orderedPizza: false})}).to.throw('You must order at least 1 Pizza to finish the order.');
        });
        it('order pizza is true and without drink', () => {
            expect(pizzUni.makeAnOrder({orderedPizza: 'Mozarella'})).to.equal('You just ordered Mozarella');
        });
        it('order pizza with a drink', () => {
            expect(pizzUni.makeAnOrder({orderedPizza: 'Mozarella', orderedDrink: 'Cola'})).to.equal('You just ordered Mozarella and Cola.');
        });
    });

    describe('get remaining work', () => {
        it('work correctly id all orders are ready', () => {
            expect(pizzUni.getRemainingWork([{status: 'ready'}, {status: 'ready'}])).to.equal('All orders are complete!');
        });
        it('return all pizzas which are not ready', () => {
            const pizzas = [
                {
                    pizzaName: 'a',
                    status: 'not',
                },
                {
                    pizzaName: 'b',
                    status: 'not',
                }
            ]
            expect(pizzUni.getRemainingWork(pizzas)).to.equal('The following pizzas are still preparing: a, b.');
        });
        it('return correct pizzas when there are ready', () => {
            const pizzas = [
                {
                    pizzaName: 'a',
                    status: 'not',
                },
                {
                    pizzaName: 'b',
                    status: 'ready',
                },
                {
                    pizzaName: 'c',
                    status: 'not',
                }
            ]
            expect(pizzUni.getRemainingWork(pizzas)).to.equal('The following pizzas are still preparing: a, c.');
        });
        it('when empty array is given', () => {
            expect(pizzUni.getRemainingWork([])).to.equal('All orders are complete!');
        })
    });

    describe('order type', () => {
        it('when type is delivery', () => {
            expect(pizzUni.orderType(10, 'Delivery')).to.equal(10);
        });
        it('should return undefined if it is not delivery or carry put', () => {
            expect(pizzUni.orderType(10, 'del')).to.be.undefined;
        });
        it('when type is carry put', () => {
            expect(pizzUni.orderType(10, 'Carry Out')).to.equal(9);
        });
        it('when type is carry put and param is floating point', () => {
            expect(pizzUni.orderType(10.5, 'Carry Out')).to.equal(9.45);
        })
    })
})
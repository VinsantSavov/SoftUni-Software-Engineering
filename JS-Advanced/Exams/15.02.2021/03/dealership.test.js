const {expect} = require('chai');
const dealership = require('./dealership');

describe('dealership', () => {
    describe('newCarCost', () => {
        it('have discount', () => {
            expect(dealership.newCarCost('Audi A4 B8', 30000)).to.equal(15000);
        });
        it('doesnt have the model discount', () => {
            expect(dealership.newCarCost('Audi A9 B8', 30000)).to.equal(30000);
        })
    });
    describe('carEquipment', () => {
        it('return correct extras', () => {
            const extras = ['heated', 'cold', 'sliding'];
            const indexes = [0, 1];
            expect(dealership.carEquipment(extras, indexes)).to.have.members(['heated', 'cold']);
        });
        it('should return all extras', () => {
            const extras = ['heated', 'cold', 'sliding'];
            const indexes = [0, 1, 2];
            expect(dealership.carEquipment(extras, indexes)).to.have.members(['heated', 'cold', 'sliding']);
        })
        it('should extras in different order', () => {
            const extras = ['heated', 'cold', 'sliding'];
            const indexes = [2, 0];
            expect(dealership.carEquipment(extras, indexes)).to.have.members(['sliding', 'heated']);
        })
    });
    describe('euroCategory', () => {
        it('should work correctly with number above 4', () => {
            expect(dealership.euroCategory(6)).to.equal(`We have added 5% discount to the final price: 14250.`);
        });
        it('should work correctly with 4', () => {
            expect(dealership.euroCategory(4)).to.equal(`We have added 5% discount to the final price: 14250.`);
        });
        it('should work correctly with number smaller than 4', () => {
            expect(dealership.euroCategory(3)).to.equal('Your euro category is low, so there is no discount from the final price!');
        });
        it('should work correctly with negative number', () => {
            expect(dealership.euroCategory(-3)).to.equal('Your euro category is low, so there is no discount from the final price!');
        });
        it('should work correctly with floating point number', () => {
            expect(dealership.euroCategory(2.5)).to.equal('Your euro category is low, so there is no discount from the final price!');
        });
    })
})
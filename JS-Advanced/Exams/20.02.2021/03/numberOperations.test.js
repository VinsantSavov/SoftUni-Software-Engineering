const {expect} = require('chai');
const numberOperations = require('./numberOperations');

describe('numberOperations', () => {
    it('powNumber works correctly', () => {
        expect(numberOperations.powNumber(1)).to.equal(1);
        expect(numberOperations.powNumber(2)).to.equal(4);
        expect(numberOperations.powNumber(5)).to.equal(25);
    });

    it('numberChecker equal to 100', () => {
        expect(numberOperations.numberChecker('100')).to.equal('The number is greater or equal to 100!');
    });
    it('numberChecker above 100', () => {
        expect(numberOperations.numberChecker('120')).to.equal('The number is greater or equal to 100!');
    });
    it('numberChecker below 100', () => {
        expect(numberOperations.numberChecker('90')).to.equal('The number is lower than 100!');
    });
    it('numberChecker when parameter is not a number', () => {
        expect(() => {numberOperations.numberChecker('90a')}).to.throw('The input is not a number!');
    });

    it('sumArrays should work correctly with equal arrays', () => {
        const firstArray = [1, 2, 3, 4];
        const secondArray = [1, 2, 3, 4];
        expect(numberOperations.sumArrays(firstArray, secondArray)).to.deep.equal([2, 4, 6, 8]);
    });
    it('sumArrays should work correctly when firstArray is longer', () => {
        const firstArray = [1, 2, 3, 4, 5, 6];
        const secondArray = [1, 2, 3, 4];
        expect(numberOperations.sumArrays(firstArray, secondArray)).to.deep.equal([2, 4, 6, 8, 5, 6]);
    });
    it('sumArrays should work correctly when secondArray is longer', () => {
        const firstArray = [1, 2, 3, 4];
        const secondArray = [1, 2, 3, 4, 5, 6];
        expect(numberOperations.sumArrays(firstArray, secondArray)).to.deep.equal([2, 4, 6, 8, 5, 6]);
    })
})
const {expect} = require('chai');
const isOddOrEven = require('./evenOrOdd');

describe('check if even or odd', () => {
    it('returns odd if length is odd', () => {
        expect(isOddOrEven('1')).to.equal('odd');
    });
    it('returns even if length is even', () => {
        expect(isOddOrEven('12')).to.equal('even');
    });
    it('returns undefined if param is number', () => {
        expect(isOddOrEven(1)).to.be.undefined;
    });
})
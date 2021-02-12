const {expect} = require('chai');
const isSymmetric = require('./checkForSymmetry');

describe('check if array is symmetric', () => {
    it('one element', () => {
        expect(isSymmetric([1])).to.be.true;
    });
    it('returns true with two els', () => {
        expect(isSymmetric([1, 1])).to.be.true;
    });
    it('returns true with odd number of els', () => {
        expect(isSymmetric([1, 1, 1])).to.be.true;
    });
    it('returns false when not symmetric', () => {
        expect(isSymmetric([1, 2])).to.be.false;
    });
    it('returns true with strings', () => {
        expect(isSymmetric(['a', 'a'])).to.be.true;
    });
    it('returns false with non symetric string array', () => {
        expect(isSymmetric(['a', 'b'])).to.be.false
    });
    it('returns false when different type els', () => {
        expect(isSymmetric(['1', 1])).to.be.false
    });
    it('returns true with odd count of string els', () => {
        expect(isSymmetric(['a', 'a', 'a'])).to.be.true;
    });
    it('returns false when not symmetric with several els', () => {
        expect(isSymmetric([1, 2, 4, 5])).to.be.false;
    });
    it('returns true when symmetric with several els', () => {
        expect(isSymmetric([1, 2, 2, 1])).to.be.true;
    });
    it('one string element', () => {
        expect(isSymmetric(['a'])).to.be.true;
    });
})
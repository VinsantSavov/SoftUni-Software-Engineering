const {expect} = require('chai');
const lookupChar = require('./charLookup');

describe('find char', () => {
    it('returns undefined if first param is not string', () => {
        expect(lookupChar(2, 2)).to.be.undefined;
    });
    it('returns undefined if second param is not number', () => {
        expect(lookupChar('sss', 'ss')).to.be.undefined;
    });
    it('returns undefined if first param is undefined', () => {
        expect(lookupChar(undefined, 'ss')).to.be.undefined;
    });
    it('returns undefined if second param is undefined', () => {
        expect(lookupChar('sdf', undefined)).to.be.undefined;
    });
    it('returns undefined if params are changed', () => {
        expect(lookupChar(3, 'ss')).to.be.undefined;
    });
    it('returns undefined if only one parameter is given', () => {
        expect(lookupChar('asd')).to.be.undefined;
    });
    it('returns correct char', () => {
        expect(lookupChar('asd', 2)).to.equal('d');
    });
    it('returns error when index is negative', () => {
        expect(lookupChar('asd', -2)).to.equal('Incorrect index');
    });
    it('returns error when index is more than string length', () => {
        expect(lookupChar('asd', 4)).to.equal('Incorrect index');
    });
    it('returns error when index is euqal to string length', () => {
        expect(lookupChar('asd', 3)).to.equal('Incorrect index');
    });
    it('returns correct char when index is 0', () => {
        expect(lookupChar('asd', 0)).to.equal('a');
    });
    it('returns empty string', () => {
        expect(lookupChar(' ', 0)).to.equal(' ');
    });
    it('returns undefined when param is floating-poit', () => {
        expect(lookupChar('asd', 3.2)).to.be.undefined;
    });
})
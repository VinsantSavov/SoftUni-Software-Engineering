const {expect} = require('chai');
const mathEnforcer = require('./mathEnforcer');

describe('math calc', () => {
    it('addFive should return correct result', () => {
        expect(mathEnforcer.addFive(1)).to.equal(6);
    });
    it('addFive should return correct result with negative param', () => {
        expect(mathEnforcer.addFive(-1)).to.equal(4);
    });
    it('addFive should return correct result with floating param', () => {
        expect(mathEnforcer.addFive(1.5)).to.equal(6.5);
    });
    it('addFive should return undefined if param is not a number', () => {
        expect(mathEnforcer.addFive('a')).to.be.undefined;
    });
    it('subtractTen should return correct result', () => {
        expect(mathEnforcer.subtractTen(10)).to.equal(0);
    });
    it('subtractTen should return correct result with negative param', () => {
        expect(mathEnforcer.subtractTen(-10)).to.equal(-20);
    });
    it('subtractTen should return correct result with floating param', () => {
        expect(mathEnforcer.subtractTen(10.5)).to.equal(0.5);
    });
    it('subtractTen should return negative result', () => {
        expect(mathEnforcer.subtractTen(1)).to.equal(-9);
    });
    it('subtractTen should return undefined if param is not a number', () => {
        expect(mathEnforcer.subtractTen('a')).to.be.undefined;
    });
    it('sum should return correct result', () => {
        expect(mathEnforcer.sum(1, 2)).to.equal(3);
    });
    it('sum should return correct result with first param negative', () => {
        expect(mathEnforcer.sum(-1, 2)).to.equal(1);
    });
    it('sum should return correct result with second param negative', () => {
        expect(mathEnforcer.sum(1, -2)).to.equal(-1);
    });
    it('sum should return correct result with first param floating', () => {
        expect(mathEnforcer.sum(1.5, 1)).to.equal(2.5);
    });
    it('sum should return correct result with floating params', () => {
        expect(mathEnforcer.sum(1.5, 1.5)).to.equal(3);
    });
    it('sum should return correct result with negative params', () => {
        expect(mathEnforcer.sum(-1, -2)).to.equal(-3);
    });
    it('sum should return undefined if first param is not a number', () => {
        expect(mathEnforcer.sum('a', 2)).to.be.undefined;
    });
    it('sum should return undefined if second param is not a number', () => {
        expect(mathEnforcer.sum(2, 'a')).to.be.undefined;
    });
})
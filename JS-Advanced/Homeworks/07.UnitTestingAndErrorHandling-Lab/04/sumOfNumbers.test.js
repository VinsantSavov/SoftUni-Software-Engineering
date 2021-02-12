const {expect} = require('chai');
const sum = require('./sumOfNumbers');

describe('sum', function (){
    it('works correctly with one param', function (){
        expect(sum([1])).to.equal(1);
    });

    it('works correctly with two param', function (){
        expect(sum([1, 2])).to.equal(3);
    });

    it('works correctly with several param', function (){
        expect(sum([1, 2, 5, 6])).to.equal(14);
    });
});
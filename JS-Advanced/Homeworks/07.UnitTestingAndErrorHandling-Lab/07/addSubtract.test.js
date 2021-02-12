const {expect} = require('chai');
const createCalculator = require('./addSubtract');

describe('calculator', () => {
    it('returns object', () =>{
        expect(typeof createCalculator()).equals('object');
    });
    it('returned object has add function', () =>{
        expect(Object.keys(createCalculator())[0]).equals('add');
    });
    it('returned object has subtract function', () =>{
        expect(Object.keys(createCalculator())[1]).equals('subtract');
    });
    it('returned object has get function', () =>{
        expect(Object.keys(createCalculator())[2]).equals('get');
    });
    it('add should work', () =>{
        const calc = createCalculator();
        calc.add(5);
        expect(calc.get()).equal(5);
    });
    it('add should work when used twice', () =>{
        const calc = createCalculator();
        calc.add(5);
        calc.add(5);
        expect(calc.get()).equal(10);
    });
    it('add should work with string number', () =>{
        const calc = createCalculator();
        calc.add('5');
        expect(calc.get()).equal(5);
    });
    it('add should not work with string', () =>{
        const calc = createCalculator();
        calc.add('a');
        expect(calc.get()).to.be.NaN;
    });
    it('subtract should work', () =>{
        const calc = createCalculator();
        calc.subtract(5);
        expect(calc.get()).equal(-5);
    });
    it('subtract should work when used twice', () =>{
        const calc = createCalculator();
        calc.subtract(5);
        calc.subtract(5);
        expect(calc.get()).equal(-10);
    });
    it('subtract should work with string number', () =>{
        const calc = createCalculator();
        calc.subtract('5');
        expect(calc.get()).equal(-5);
    });
    it('subtract should not work with string', () =>{
        const calc = createCalculator();
        calc.add('a');
        expect(calc.get()).to.be.NaN;
    });
    it('subtract and add should work when used together', () =>{
        const calc = createCalculator();
        calc.add(5);
        calc.subtract(5);
        expect(calc.get()).equal(0);
    });
    it('sum cannot be modified', () =>{
        const calc = createCalculator();
        calc.add(5);
        let sum = calc.get();
        sum += 5;
        expect(calc.get()).equal(5);
    });
})
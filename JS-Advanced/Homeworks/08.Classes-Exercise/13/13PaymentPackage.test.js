const {expect} = require('chai');
const PaymentPackage = require('./13PaymentPackage');

describe('PaymentPackage tests', () => {
    describe('correct initialization', () => {
        it('name', () => {
            const pack = new PaymentPackage('name', 1);
            expect(pack.name).to.equal('name');
            pack.name = 'name2';
            expect(pack.name).to.equal('name2');
        });
        it('value', () => {
            const pack = new PaymentPackage('name', 1);
            expect(pack.value).to.equal(1);
            pack.value = 2;
            expect(pack.value).to.equal(2);
        });
        it('value with floating point', () => {
            const pack = new PaymentPackage('name', 1.5);
            expect(pack.value).to.equal(1.5);
            pack.value = 2.5;
            expect(pack.value).to.equal(2.5);
        });
        it('value with zero', () => {
            const pack = new PaymentPackage('name', 0);
            expect(pack.value).to.equal(0);
        });
        it('VAT', () => {
            const pack = new PaymentPackage('name', 1);
            expect(pack.VAT).to.equal(20);
            pack.VAT = 2;
            expect(pack.VAT).to.equal(2);
        });
        it('VAT with floating point', () => {
            const pack = new PaymentPackage('name', 1);
            expect(pack.VAT).to.equal(20);
            pack.VAT = 2.5;
            expect(pack.VAT).to.equal(2.5);
        });
        it('active', () => {
            const pack = new PaymentPackage('name', 1);
            expect(pack.active).to.equal(true);
            pack.active = false;
            expect(pack.active).to.equal(false);
        });
    });
    describe('params throwing exceptions', () => {
        it('name should throw exception if it is not string', () => {
            expect(function() {new PaymentPackage(1, 1)}).to.throw(Error);
        });
        it('name should throw exception if it is emptystring', () => {
            expect(function() {new PaymentPackage('', 1)}).to.throw('Name must be a non-empty string');
        });
        it('value should throw exception if it is not a number', () => {
            expect(function() {new PaymentPackage('aaa', 'string')}).to.throw('Value must be a non-negative number');
        });
        it('value should throw exception if it is negative number', () => {
            expect(function() {new PaymentPackage('aaa', -1)}).to.throw('Value must be a non-negative number');
        });
        it('VAT should throw exception if it is not a number', () => {
            const pack = new PaymentPackage('name', 1);
            expect(function (){pack.VAT = 'string'}).to.throw('VAT must be a non-negative number');
        });
        it('VAT should throw exception if it is negative number', () => {
            const pack = new PaymentPackage('name', 1);
            expect(function (){pack.VAT = -1}).to.throw('VAT must be a non-negative number');
        });
        it('active should throw exception if it is not a boolean', () => {
            const pack = new PaymentPackage('name', 1);
            expect(function (){pack.active = 'string'}).to.throw('Active status must be a boolean');
        });
        it('active should throw exception if it is number', () => {
            const pack = new PaymentPackage('name', 1);
            expect(function (){pack.active = 5}).to.throw('Active status must be a boolean');
        });
    });
    describe('toString method', () => {
        it('works correctly with default', () => {
            const pack = new PaymentPackage('name', 1);
            expect(pack.toString()).to.equal('Package: name\n- Value (excl. VAT): 1\n- Value (VAT 20%): 1.2');
        });
        it('works correctly with set VAT', () => {
            const pack = new PaymentPackage('name', 1);
            pack.VAT = 25;
            expect(pack.toString()).to.equal('Package: name\n- Value (excl. VAT): 1\n- Value (VAT 25%): 1.25');
        });
        it('works correctly with set active', () => {
            const pack = new PaymentPackage('name', 1);
            pack.VAT = 25;
            pack.active = false;
            expect(pack.toString()).to.equal('Package: name (inactive)\n- Value (excl. VAT): 1\n- Value (VAT 25%): 1.25');
        });
    });
});
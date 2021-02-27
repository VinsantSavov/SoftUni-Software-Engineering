const {expect} = require('chai');
const HolidayPackage = require('./HolidayPackage');

describe('HolidayPackage', () => {
    it('correct initialization', () => {
        const pack = new HolidayPackage('a', 'b');
        expect(pack.destination).to.equal('a');
        expect(pack.season).to.equal('b');
        expect(pack.insuranceIncluded).to.be.false;
    })
    describe('addVacationer', () => {
        it('should work correctly', () => {
            const pack = new HolidayPackage('a', 'b');
            pack.addVacationer('a b');
            expect(pack.vacationers.length).to.equal(1);
            expect(pack.vacationers[0]).to.equal('a b');
        });
        it('should throw error when it is not string', () => {
            const pack = new HolidayPackage('a', 'b');
            expect(() => {pack.addVacationer(5)}).to.throw('Vacationer name must be a non-empty string');
        });
        it('should throw error when it is empty string', () => {
            const pack = new HolidayPackage('a', 'b');
            expect(() => {pack.addVacationer(' ')}).to.throw('Vacationer name must be a non-empty string');
        });
        it('should throw error when it is only first name', () => {
            const pack = new HolidayPackage('a', 'b');
            expect(() => {pack.addVacationer('a')}).to.throw('Name must consist of first name and last name');
        });
        it('should throw error when it is more than two names', () => {
            const pack = new HolidayPackage('a', 'b');
            expect(() => {pack.addVacationer('a b c')}).to.throw('Name must consist of first name and last name');
        });
    });
    describe('showVacationers', () => {
        it('should work correctly', () => {
            const pack = new HolidayPackage('a', 'b');
            pack.addVacationer('a b');
            pack.addVacationer('c d');
            expect(pack.showVacationers()).to.equal("Vacationers:\n" + pack.vacationers.join("\n"));
        });
        it('should throw error when there are no vacationers', () => {
            const pack = new HolidayPackage('a', 'b');
            expect(pack.showVacationers()).to.equal('No vacationers are added yet');
        });
    })
    describe('insurance', () => {
        it('return insurance', () => {
            const pack = new HolidayPackage('a', 'b');
            expect(pack.insuranceIncluded).to.be.false;
        });
        it('set insurance', () => {
            const pack = new HolidayPackage('a', 'b');
            pack.insuranceIncluded = true;
            expect(pack.insuranceIncluded).to.be.true;
            pack.insuranceIncluded = false;
            expect(pack.insuranceIncluded).to.be.false;
        });
        it('throw error', () => {
            const pack = new HolidayPackage('a', 'b');
            expect(() => {pack.insuranceIncluded = 'true'}).to.throw('Insurance status must be a boolean');
        })
    });
    describe('generateHolidayPackage', () => {
        it('shoud work correctly', () => {
            const pack = new HolidayPackage('a', 'b');
            pack.addVacationer('a b');
            pack.addVacationer('c d');

            expect(pack.generateHolidayPackage()).to.equal("Holiday Package Generated\n" +
            "Destination: " + pack.destination + "\n" +
            pack.showVacationers() + "\n" +
            "Price: " + 800);
        });
        it('work correctly with summer', () => {
            const pack = new HolidayPackage('a', 'Summer');
            pack.addVacationer('a b');
            pack.addVacationer('c d');

            expect(pack.generateHolidayPackage()).to.equal("Holiday Package Generated\n" +
            "Destination: " + pack.destination + "\n" +
            pack.showVacationers() + "\n" +
            "Price: " + 1000);
        });
        it('work correctly with winter', () => {
            const pack = new HolidayPackage('a', 'Winter');
            pack.addVacationer('a b');
            pack.addVacationer('c d');

            expect(pack.generateHolidayPackage()).to.equal("Holiday Package Generated\n" +
            "Destination: " + pack.destination + "\n" +
            pack.showVacationers() + "\n" +
            "Price: " + 1000);
        });
        it('work correctly with insurance', () => {
            const pack = new HolidayPackage('a', 'Winter');
            pack.addVacationer('a b');
            pack.addVacationer('c d');
            pack.insuranceIncluded = true;

            expect(pack.generateHolidayPackage()).to.equal("Holiday Package Generated\n" +
            "Destination: " + pack.destination + "\n" +
            pack.showVacationers() + "\n" +
            "Price: " + 1100);
        })
        it('throw exception when no vacationers', () => {
            const pack = new HolidayPackage('a', 'Winter');

            expect(() => {pack.generateHolidayPackage()}).to.throw('There must be at least 1 vacationer added');
        })
    })
})
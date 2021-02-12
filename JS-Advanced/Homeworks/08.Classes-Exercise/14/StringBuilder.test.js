const {expect} = require('chai');
const StringBuilder = require('./StringBuilder');

describe('StringBuilder class', () =>{
    describe('constructor', () => {
        it('when param is undefined', () => {
            const builder = new StringBuilder(undefined);
            expect(builder._stringArray).to.be.an('array').that.is.empty;
            const builder2 = new StringBuilder();
            expect(builder2._stringArray).to.be.an('array').that.is.empty;
        });
        it('constructor with empty string', () =>{
            const builder2 = new StringBuilder('');
            expect(builder2._stringArray).to.be.an('array').that.is.empty;
        });
        it('when it isnt undefined', () => {
            const builder = new StringBuilder('asd');
            expect(builder._stringArray).to.be.an('array').that.is.not.empty;
            expect(builder._stringArray).to.have.members(['a', 's', 'd']);
        });
        it('should throw error when param is not string', () => {
            expect(() => {new StringBuilder(5)}).to.throw('Argument must be а string');
        });
        it('_vrfyParam should throw exeption when param is number', () => {
            expect(() => StringBuilder._vrfyParam(5)).to.throw('Argument must be а string');
        })
        it('_vrfyParam should throw exeption when param is undefined', () => {
            expect(() => StringBuilder._vrfyParam(undefined)).to.throw('Argument must be а string');
        });
        it('_vrfyParam should throw exeption when param is null', () => {
            expect(() => StringBuilder._vrfyParam()).to.throw('Argument must be а string');
        });
        it('_vrfyParam should not throw error when param is string', () => {
            expect(() => StringBuilder._vrfyParam('asd')).not.throw('Argument must be а string');
        })
    });
    describe('append', () => {
        it('append should work correctly', () => {
            const builder = new StringBuilder('asd');
            builder.append('123');
            expect(builder._stringArray).to.have.members(['a', 's', 'd', '1', '2', '3']);
            expect(builder.toString()).to.equal('asd123');
        });
        it('append should throw error when param is no string', () => {
            const builder = new StringBuilder('asd');
            expect(() => {builder.append(123)}).to.throw('Argument must be а string');
        });
        it('append with empty string', () => {
            const builder = new StringBuilder('asd');
            builder.append('');
            expect(builder._stringArray).to.have.members(['a', 's', 'd']);
        })
    });
    describe('prepend', () => {
        it('append should work correctly', () => {
            const builder = new StringBuilder('a');
            builder.prepend('123');
            expect(builder._stringArray).to.have.members(['1', '2', '3', 'a']);
            expect(builder.toString()).to.equal('123a');
        });
        it('append should throw exception when param is not string', () => {
            const builder = new StringBuilder('a');
            expect(() => {builder.prepend(123)}).to.throw('Argument must be а string');
        });
    });
    describe('insertAt', () => {
        it('insertAt should work correctly', () => {
            const builder = new StringBuilder('a');
            builder.insertAt('123', 1);
            expect(builder._stringArray).to.have.members(['a', '1', '2', '3']);
        });
        it('insertAt should throw exception when param is not string', () => {
            const builder = new StringBuilder('a');
            expect(() => {builder.insertAt(123, 2)}).to.throw('Argument must be а string');
        });
        it('with negative startIndex', () => {
            const builder = new StringBuilder('ab');
            builder.insertAt('123', -1);
            expect(builder._stringArray).to.have.members(['a', '1', '2', '3', 'b']);
        });
        it('with zero startIndex', () => {
            const builder = new StringBuilder('ab');
            builder.insertAt('123', 0);
            expect(builder._stringArray).to.have.members(['a', '1', '2', '3', 'b']);
        });
        it('with startIndex bigger than length', () => {
            const builder = new StringBuilder('ab');
            builder.insertAt('123', 5);
            expect(builder._stringArray).to.have.members(['a', 'b', '1', '2', '3']);
        });
        it('with floating point index', () => {
            const builder = new StringBuilder('ab');
            builder.insertAt('123', 1.5);
            expect(builder._stringArray).to.have.members(['a', 'b', '1', '2', '3']);
        });
    });
    describe('remove', () => {
        it('remove should work correctly', () => {
            const builder = new StringBuilder('aaabbb');
            builder.remove(3, 3);
            expect(builder._stringArray).to.have.members(['a', 'a', 'a']);
        });
        it('remove with bigger params', () => {
            const builder = new StringBuilder('a');
            builder.remove(3, 3);
            expect(builder._stringArray).to.have.members(['a']);
        });
        it('remove with smaller index', () => {
            const builder = new StringBuilder('abc');
            builder.remove(-3, 1);
            expect(builder._stringArray).to.have.members(['b', 'c']);
        });
        it('remove with smaller length', () => {
            const builder = new StringBuilder('abc');
            builder.remove(0, -1);
            expect(builder._stringArray).to.have.members(['a', 'b', 'c']);
        });
        it('remove with floating point start index', () => {
            const builder = new StringBuilder('abcde');
            builder.remove(1.5, 4);
            expect(builder._stringArray).to.have.members(['a']);
        });
        it('remove with floating point length', () => {
            const builder = new StringBuilder('abcde');
            builder.remove(1, 1.5);
            expect(builder._stringArray).to.have.members(['a', 'c', 'd', 'e']);
        });
    });
    describe('toString', () => {
        it('should return string', () => {
            const builder = new StringBuilder('aaabbb');
            expect(builder.toString()).to.equal('aaabbb');
        });
        it('should return empty string', () => {
            const builder = new StringBuilder();
            expect(builder.toString()).to.equal('');
        });
    });
});
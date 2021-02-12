const {expect} = require('chai');
const rgbToHexColor = require('./rgb-to-hex');

describe('convert rgb', () => {
    it('return black', () => {
        expect(rgbToHexColor(0, 0, 0)).to.equal('#000000');
    });
    it('return white', () => {
        expect(rgbToHexColor(255, 255, 255)).to.equal('#FFFFFF');
    });
    it('return #C23636', () => {
        expect(rgbToHexColor(194, 54, 54)).to.equal('#C23636');
    });
    it('return undefined when the first param is string', () => {
        expect(rgbToHexColor('a', 54, 54)).to.be.undefined;
    });
    it('return undefined when the seconf param is string', () => {
        expect(rgbToHexColor(54, 'b', 54)).to.be.undefined;
    });
    it('return undefined when the third param is string', () => {
        expect(rgbToHexColor(54, 54, 'c')).to.be.undefined;
    });
    it('return undefined when the first param is negative', () => {
        expect(rgbToHexColor(-3, 54, 54)).to.be.undefined;
    });
    it('return undefined when the first param is above 255', () => {
        expect(rgbToHexColor(54, 54, 2664)).to.be.undefined;
    });
    it('return undefined when the second param is negative', () => {
        expect(rgbToHexColor(54, -54, 54)).to.be.undefined;
    });
    it('return undefined when the second param is above 255', () => {
        expect(rgbToHexColor(54, 300, 24)).to.be.undefined;
    });
    it('return undefined when the third param is negative', () => {
        expect(rgbToHexColor(54, 54, -54)).to.be.undefined;
    });
    it('return undefined when the third param is above 255', () => {
        expect(rgbToHexColor(54, 30, 2400)).to.be.undefined;
    });
});
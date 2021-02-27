const {expect} = require('chai');
const Repository = require('./solution');

describe('Repository', () => {
    it('initialization should work correctly', () => {
        expect(() => {const rep = new Repository({'name': 'a'})}).to.not.throw('Error');
    });
    it('initialization with map', () => {
        const rep = new Repository({'name': 'a'})
        expect(typeof rep.data).to.equal('object');
    });
    it('add should add entity', () => {
        const props = {name: 'string'};
        const rep = new Repository(props);
        expect(() => {rep.add({name: 'a'})}).to.not.throw();
        expect(rep.count).to.equal(1);
    });
    it('add should return id', () => {
        const props = {name: 'string'};
        const rep = new Repository(props);
        const id = rep.add({name: 'a'});
        const entity = rep.getId(id);
        expect(id).to.equal(0);
        expect(entity).to.deep.equal({name: 'a'});
    });
    it('add several properties', () => {
        const props = {name: 'string'};
        const rep = new Repository(props);
        const id1 = rep.add({name: 'a'});
        const id2 = rep.add({name: 'b'});
        const id3 = rep.add({name: 'c'});

        expect(rep.data.has(0)).to.be.true;
        expect(rep.data.has(1)).to.be.true;
        expect(rep.data.has(2)).to.be.true;
        expect(rep.count).to.equal(3);
        expect(id1).to.equal(0);
        expect(id2).to.equal(1);
        expect(id3).to.equal(2);
    })
    it('add should throw error if property doesnt exist', () => {
        const props = {name: 'string', age: 'number'};
        const rep = new Repository(props);
        expect(() => {rep.add({name: 'a'})}).to.throw('Property age is missing from the entity!');
    });
    it('add should throw error if property type is different', () => {
        const props = {name: 'string', age: 'number'};
        const rep = new Repository(props);
        expect(() => {rep.add({name: 'a', age: '1'})}).to.throw('Property age is not of correct type!');
    });
    it('count should return correct count', () => {
        const props = {name: 'string'};
        const rep = new Repository(props);
        rep.add({name: 'a'})
        expect(rep.count).to.equal(1);
    });
    it('count when empty', () => {
        const props = {name: 'string'};
        const rep = new Repository(props);
        expect(rep.count).to.equal(0);
    });
    it('count should return correct count with two enitites', () => {
        const props = {name: 'string'};
        const rep = new Repository(props);
        rep.add({name: 'a'});
        rep.add({name: 'b'})
        expect(rep.count).to.equal(2);
    });
    it('getId should return correct entity', () => {
        const props = {name: 'string'};
        const rep = new Repository(props);
        rep.add({name: 'a'});
        rep.add({name: 'b'});
        const entity = rep.getId(0);
        expect(entity).to.deep.equal({name: 'a'});
    });
    it('getId should throw exception when invalid id', () => {
        const props = {name: 'string'};
        const rep = new Repository(props);
        rep.add({name: 'a'});
        expect(() => {rep.getId(1)}).to.throw('Entity with id: 1 does not exist!');
        expect(() => {rep.getId(1.3)}).to.throw('Entity with id: 1.3 does not exist!');
    });
    it('delete should remove entity correctly', () => {
        const props = {name: 'string'};
        const rep = new Repository(props);
        rep.add({name: 'a'});
        rep.add({name: 'b'});
        rep.add({name: 'c'});
        rep.del(0);
        expect(rep.count).to.equal(2);
        rep.del(1);
        expect(rep.count).to.equal(1);
        rep.del(2);
        expect(rep.count).to.equal(0);
        expect(() => {rep.getId(0)}).to.throw();
    });
    it('delete should throw exception when invalid id', () => {
        const props = {name: 'string'};
        const rep = new Repository(props);
        rep.add({name: 'a'});
        expect(() => {rep.del(1)}).to.throw('Entity with id: 1 does not exist!');
        expect(() => {rep.del(1.3)}).to.throw('Entity with id: 1.3 does not exist!');
    });
    it('delete should throw exception when string id', () => {
        const props = {name: 'string'};
        const rep = new Repository(props);
        rep.add({name: 'a'});
        expect(() => {rep.del('test')}).to.throw('Entity with id: test does not exist!');
    });
    it('update should work correctly', () => {
        const props = {name: 'string'};
        const rep = new Repository(props);
        rep.add({name: 'a'});
        rep.update(0, {name: 'b'});

        expect(rep.count).to.equal(1);

        const newEntity = rep.getId(0);
        expect(newEntity).to.deep.equal({name: 'b'});
    });
    it('update should throw exception when invalid id', () => {
        const props = {name: 'string'};
        const rep = new Repository(props);
        rep.add({name: 'a'});
        expect(() => {rep.update(1, {name: 'b'})}).to.throw('Entity with id: 1 does not exist!');
        expect(() => {rep.update(1.4, {name: 'b'})}).to.throw('Entity with id: 1.4 does not exist!');
    })
    it('update should throw error when invalid new entity', () => {
        const props = {name: 'string', age: 'number'};
        const rep = new Repository(props);
        rep.add({name: 'a', age: 1});
        expect(() => {rep.update(0, {name: 'b', age: 'num'})}).to.throw('Property age is not of correct type!');
    });
    it('update should throw error when missing new entity', () => {
        const props = {name: 'string', age: 'number'};
        const rep = new Repository(props);
        rep.add({name: 'a', age: 1});
        expect(() => {rep.update(0, {name: 'b'})}).to.throw('Property age is missing from the entity!');
    })
});
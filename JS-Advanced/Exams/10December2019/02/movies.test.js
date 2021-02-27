const {expect} = require('chai');
const ChristmasMovies = require('./movies');

describe('ChristmasMovies', () => {
    describe('buyMovie', () => {
        it('work correctly', () => {
            const cm = new ChristmasMovies();
            let result = cm.buyMovie('A', ['a', 'b']);
            expect(result).to.equal('You just got A to your collection in which a, b are taking part!');
            expect(cm.movieCollection.length).to.equal(1);
        });
        it('with same actors', () => {
            const cm = new ChristmasMovies();
            let result = cm.buyMovie('A', ['a', 'a', 'b', 'b']);
            expect(result).to.equal('You just got A to your collection in which a, b are taking part!');
            expect(cm.movieCollection[0].actors).to.deep.equal(['a', 'b']);
        });
        it('already existing movie', () => {
            const cm = new ChristmasMovies();
            cm.buyMovie('A', ['a', 'b']);
            expect(() => {cm.buyMovie('A', ['a'])}).to.throw('You already own A in your collection!');
        })
    });
    describe('watchMovie', () => {
        it('work correctly', () => {
            const cm = new ChristmasMovies();
            cm.buyMovie('A', ['a', 'b']);
            cm.watchMovie('A');
            expect(cm.watched.hasOwnProperty('A')).to.be.true;
            expect(cm.watched['A']).to.equal(1);
        });
        it('watch several times', () => {
            const cm = new ChristmasMovies();
            cm.buyMovie('A', ['a', 'b']);
            cm.buyMovie('B', ['a', 'b']);
            cm.watchMovie('A');
            cm.watchMovie('A');
            cm.watchMovie('A');
            expect(cm.watched.hasOwnProperty('A')).to.be.true;
            expect(cm.watched['A']).to.equal(3);
        });
        it('if movie does not exist', () => {
            const cm = new ChristmasMovies();
            cm.buyMovie('A', ['a', 'b']);
            cm.buyMovie('B', ['a', 'b']);
            expect(() => {cm.watchMovie('C')}).to.throw('No such movie in your collection!');
        })
    });
    describe('discardMovie', () => {
        it('should delete it from both collection and watched', () => {
            const cm = new ChristmasMovies();
            cm.buyMovie('A', ['a', 'b']);
            cm.watchMovie('A');
            let result = cm.discardMovie('A');
            expect(result).to.equal('You just threw away A!');
            expect(cm.movieCollection.length).to.equal(0);
            expect(cm.watched.hasOwnProperty('A')).to.be.false;
        });
        it('if it is not is collection', () => {
            const cm = new ChristmasMovies();
            cm.buyMovie('A', ['a', 'b']);
            cm.watchMovie('A');
            expect(() => {cm.discardMovie('C')}).to.throw('C is not at your collection!')
        });
        it('if it is not watched', () => {
            const cm = new ChristmasMovies();
            cm.buyMovie('A', ['a', 'b']);
            cm.buyMovie('B', ['a', 'b']);
            expect(() => {cm.discardMovie('A')}).to.throw('A is not watched!');
            expect(cm.movieCollection.length).to.equal(1);
        });
    });
    describe('favouriteMovie', () => {
        it('work correctly', () => {
            const cm = new ChristmasMovies();
            cm.buyMovie('A', ['a', 'b']);
            cm.buyMovie('B', ['a', 'b']);
            cm.watchMovie('A');
            cm.watchMovie('A');
            let result = cm.favouriteMovie();
            expect(result).to.equal('Your favourite movie is A and you have watched it 2 times!');
        })
        it('with several movies', () => {
            const cm = new ChristmasMovies();
            cm.buyMovie('A', ['a', 'b']);
            cm.buyMovie('B', ['a', 'b']);
            cm.watchMovie('A');
            cm.watchMovie('A');
            cm.watchMovie('A');
            cm.watchMovie('B');
            let result = cm.favouriteMovie();
            expect(result).to.equal('Your favourite movie is A and you have watched it 3 times!');
        });
        it('when no movies in watch list', () => {
            const cm = new ChristmasMovies();
            cm.buyMovie('A', ['a', 'b']);
            cm.buyMovie('B', ['a', 'b']);
            expect(() => {cm.favouriteMovie()}).to.throw('You have not watched a movie yet this year!');
        })
    });
    describe('mostStarredActor', () => {
        it('when moviesCollection is empty', () => {
            const cm = new ChristmasMovies();
            expect(() => {cm.mostStarredActor()}).to.throw('You have not watched a movie yet this year!');
        });
        it('work correclty', () => {
            const cm = new ChristmasMovies();
            cm.buyMovie('A', ['a', 'b']);
            cm.buyMovie('B', ['a', 'c']);
            cm.buyMovie('C', ['a', 'd']);
            let result = cm.mostStarredActor();
            expect(result).to.equal('The most starred actor is a and starred in 3 movies!');
        })
    })
});
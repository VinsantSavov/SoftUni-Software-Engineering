function createCard(face, suit){
    const faces = [2, 3, 4, 5, 6, 7, 8, 9, 10, 'J', 'Q', 'K', 'A'];
    const suits = ['S', 'H', 'D', 'C'];
    const utfSuits = {
        'S': '\u2660',
        'H': '\u2665',
        'D': '\u2666',
        'C': '\u2663'
    };

    if(!faces.some(f => f == face.toUpperCase()) || !suits.some(s => s == suit.toUpperCase())){
        throw new Error('Invalid face or suit');
    }

    return {toString};

    function toString(){
        return `${face}${utfSuits[suit]}`;
    }
}
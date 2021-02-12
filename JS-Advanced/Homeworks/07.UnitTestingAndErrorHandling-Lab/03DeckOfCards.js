function printDeckOfCards(cards){
    const output = [];
    try{
        for(let card of cards){
            const args = card.split('');
            const face = args.length == 3? args[0] + args[1] : args[0];
            const suit = args[args.length - 1];

            output.push(createCard(face, suit).toString());
        }
    }catch(ex){
        console.log(ex.message);
        return;
    }

    console.log(output.join(' '));

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
            throw new Error(`Invalid card: ${face}${suit}`);
        }
    
        return {toString};
    
        function toString(){
            return `${face}${utfSuits[suit]}`;
        }
    }
}

printDeckOfCards(['5S', '3D', 'QD', '1C']);
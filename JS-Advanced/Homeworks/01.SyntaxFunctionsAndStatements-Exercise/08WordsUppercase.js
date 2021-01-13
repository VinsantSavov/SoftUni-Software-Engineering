function uppercaseWords(sentence){
    let regex = /[\W]+/;
    let words = sentence.split(regex);

    for(let i = 0; i < words.length; i++){
        words[i] = words[i].toUpperCase();

        if(words[i] == ' ' || words[i] == ''){
            words.splice(i);
        }
    }

    console.log(words.join(', '));
}
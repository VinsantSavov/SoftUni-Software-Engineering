function extract(content) {
    const result = [];
    const reg = /\((.+?)\)/g;
    const text = document.getElementById(content).textContent;

    let match = reg.exec(text);
    
    while(match){
        result.push(match[1]);

        match = reg.exec(text);
    }

    return result.join('; ');
}
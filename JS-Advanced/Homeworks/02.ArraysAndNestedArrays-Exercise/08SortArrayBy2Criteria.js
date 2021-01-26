function sortArray(names){
    names.sort((a, b) => a.length - b.length == 0 ? a.localeCompare(b) : a.length - b.length);

    return names.join('\n');
}

console.log(sortArray(['alpha', 'beta', 'gamma']));
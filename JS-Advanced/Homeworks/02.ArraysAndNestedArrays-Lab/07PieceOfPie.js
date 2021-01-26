const getPies = (array, firstPie, lastPie) => {
    const startIndex = array.indexOf(firstPie);
    const endIndex = array.indexOf(lastPie);

    const result = array.slice(startIndex, endIndex + 1);
    return result;
}
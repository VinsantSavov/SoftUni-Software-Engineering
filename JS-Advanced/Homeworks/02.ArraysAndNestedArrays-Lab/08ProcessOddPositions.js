const getNewArray = (array) => {
    const result = array.filter((_, index) => index % 2 != 0).map(value => 2 * value).reverse();
    return result;
}
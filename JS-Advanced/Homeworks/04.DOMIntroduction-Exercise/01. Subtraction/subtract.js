function subtract() {
    const firstNumber = Number(document.getElementById('firstNumber').value);
    const secondNumber = Number(document.getElementById('secondNumber').value);

    document.querySelector('#result').textContent = firstNumber - secondNumber;
}
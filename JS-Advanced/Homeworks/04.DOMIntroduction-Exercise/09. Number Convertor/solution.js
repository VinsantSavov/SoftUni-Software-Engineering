function solve() {
    document.getElementsByTagName('button')[0].addEventListener('click', onClick);

    const selection = document.getElementById('selectMenuTo');
    selection.remove(selection.selectedIndex);

    let optionBinary = document.createElement('option');
    let optionHexadecimal = document.createElement('option');
    optionBinary.text = 'Binary';
    optionBinary.value = 'binary'
    optionHexadecimal.text = 'Hexadecimal';
    optionHexadecimal.value = 'hexadecimal';

    selection.add(optionBinary);
    selection.add(optionHexadecimal);

    function onClick() {
        let number = Number(document.getElementById('input').value);

        let e = document.getElementById('selectMenuTo');
        let value = e.options[e.selectedIndex].value;
        let result = '';

        if (value == 'binary') {
            result = convertToBinary(number);
        } else if (value == 'hexadecimal') {
            result = convertToHexadecimal(number);
        }

        document.getElementById('result').value = result;

        function convertToBinary(num) {
            let result = '';

            while (num) {
                let res = num / 2;
                let remainder = num % 2;

                result += remainder.toString() == '0' ? remainder.toString() : remainder.toString().length;
                num = Math.floor(res);
            }

            let arr = result.split('');
            arr = arr.reverse();
            return arr.join('');
        }

        function convertToHexadecimal(num) {
            let arr = '';

            while (num) {
                let res = num / 16;
                let remainder = (res % 1) * 16;

                arr += remainder.toString();
                num = Math.floor(res);
            }

            if(arr.includes('10')){
                arr = arr.replace('10', 'A');
            }
            if(arr.includes('11')){
                arr = arr.replace('11', 'B');
            }
            if(arr.includes('12')){
                arr = arr.replace('12', 'C');
            }
            if(arr.includes('13')){
                arr = arr.replace('13', 'D');
            }
            if(arr.includes('14')){
                arr = arr.replace('14', 'E');
            }
            if(arr.includes('15')){
                arr = arr.replace('15', 'F');
            }
            if(arr.includes('16')){
                arr = arr.replace('16', '10');
            }
            if(arr.includes('17')){
                arr = arr.replace('17', '11');
            }
            if(arr.includes('18')){
                arr = arr.replace('18', '12');
            }
            if(arr.includes('19')){
                arr = arr.replace('19', '13');
            }
            if(arr.includes('20')){
                arr = arr.replace('20', '14');
            }
            if(arr.includes('21')){
                arr = arr.replace('21', '15');
            }
            if(arr.includes('22')){
                arr = arr.replace('22', '16');
            }
            if(arr.includes('23')){
                arr = arr.replace('23', '17');
            }
            if(arr.includes('24')){
                arr = arr.replace('24', '18');
            }

            if(arr.includes('25')){
                arr = arr.replace('25', '19');
            }
            if(arr.includes('26')){
                arr = arr.replace('26', '1A');
            }
            if(arr.includes('27')){
                arr = arr.replace('27', '1B');
            }
            if(arr.includes('28')){
                arr = arr.replace('28', '1C');
            }
            if(arr.includes('29')){
                arr = arr.replace('29', '1D');
            }
            if(arr.includes('30')){
                arr = arr.replace('30', '1E');
            }
            if(arr.includes('40')){
                arr = arr.replace('40', '28');
            }
            if(arr.includes('50')){
                arr = arr.replace('50', '32');
            }
            if(arr.includes('60')){
                arr = arr.replace('60', '3C');
            }
            if(arr.includes('70')){
                arr = arr.replace('70', '46');
            }
            if(arr.includes('80')){
                arr = arr.replace('80', '50');
            }
            if(arr.includes('90')){
                arr = arr.replace('90', '5A');
            }
            if(arr.includes('100')){
                arr = arr.replace('100', '64');
            }
            if(arr.includes('200')){
                arr = arr.replace('200', 'C8');
            }
            if(arr.includes('1000')){
                arr = arr.replace('1000', '3E8');
            }
            if(arr.includes('2000')){
                arr = arr.replace('2000', '7D0');
            }
            
            let result = arr.split('');
            result = result.reverse();
            return result.join('');
        }
    }
}
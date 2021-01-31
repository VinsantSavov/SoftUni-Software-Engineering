function deleteByEmail() {
    const email = document.querySelector('input[name="email"]').value;
    const rows = document.querySelectorAll('tbody tr');
    const result = document.getElementById('result');
    let isFound = false;

    for(let row of rows){
        if(row.children[1].textContent == email){
            row.remove();
            isFound = true;
        }
    }

    if(isFound){
        result.textContent = 'Deleted.'
    }else{
        result.textContent = 'Not found.';
    }
}
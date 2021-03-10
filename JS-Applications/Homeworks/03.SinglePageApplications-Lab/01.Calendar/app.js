function execute(){
    const sections = document.querySelectorAll('section');
    sections.forEach(s => s.style.display = 'none');

    const yearsSection = document.getElementById('years');
    yearsSection.style.display = 'block';
    yearsSection.addEventListener('click', displayYear);

    const monthsTable = {
        'Jan': 1,
        'Feb': 2,
        'Mar': 3,
        'Apr': 4,
        'May': 5,
        'Jun': 6,
        'Jul': 7,
        'Aug': 8,
        'Sept': 9,
        'Oct': 10,
        'Nov': 11,
        'Dec': 12
    };

    function displayYear(ev){
        if(ev.target.classList.contains('day') || ev.target.classList.contains('date')){
            const year = ev.target.textContent.trim();
            const yearSection = [...sections].find(s => s.id == `year-${year}`);
            yearsSection.style.display = 'none';
            yearSection.style.display = 'block';

            yearSection.addEventListener('click', (ev) => displayMonth(ev, year));
        }
    }

    function displayMonth(ev, year){
        if(ev.target.tagName == 'CAPTION'){
            [...sections].find(s => s.id == `year-${ev.target.textContent.trim()}`).style.display = 'none';
            document.getElementById('years').style.display = 'block';

        }else if(ev.target.classList.contains('day') || ev.target.classList.contains('date')){
            const month = ev.target.textContent.trim();
            const monthSection = [...sections].find(s => s.id == `month-${year}-${monthsTable[month]}`);

            monthSection.style.display = 'block';
            [...sections].find(s => s.id == `year-${year}`).style.display = 'none';

            monthSection.addEventListener('click', (ev) => returnToMonths(ev, month));
        }
    }

    function returnToMonths(ev, month){
        if(ev.target.tagName == 'CAPTION'){
            const year = ev.target.textContent.split(' ')[1];
            [...sections].find(s => s.id == `month-${year}-${monthsTable[month]}`).style.display = 'none';
            [...sections].find(s => s.id == `year-${year}`).style.display = 'block';
        }
    }
}

execute();
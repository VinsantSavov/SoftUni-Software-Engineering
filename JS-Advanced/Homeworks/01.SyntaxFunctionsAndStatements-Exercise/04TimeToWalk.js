function calculateTime(stepsCount, footprintLength, speed){
    let distance = stepsCount * (footprintLength / 1000);
    let time = distance / speed;

    let breaks = parseInt(distance / 0.5);
    let hours = parseInt(time);
    let minutes = (time % 1) * 60 + breaks;
    let seconds = (minutes % 1) * 60;

    let result = hours > 9 ? hours.toString() : '0' + hours.toString();
    result += ':';
    result += minutes > 9 ? parseInt(minutes).toString() : '0' + parseInt(minutes).toString();
    result += ':';
    result += seconds > 9 ? Math.round(seconds).toString() : '0' + Math.round(seconds).toString();

    console.log(result);
}
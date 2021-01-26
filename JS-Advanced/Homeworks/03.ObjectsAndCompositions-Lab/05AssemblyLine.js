function assemblyLine(){
    const decorator = {};

    decorator.hasClima = hasClima;
    decorator.hasAudio = hasAudio;
    decorator.hasParktronic = hasParktronic;

    function hasClima(car){
        car.temp = 21;
        car.tempSettings = 21;
        car.adjustTemp = adjustTemp;

        function adjustTemp(){
            if(this.temp < this.tempSettings){
                this.temp++
            }else if(this.temp > this.tempSettings){
                this.temp--;
            }
        }
    }

    function hasAudio(car){
        const currentTrack = {name: null, artist: null};

        car.currentTrack = currentTrack;
        car.nowPlaying = nowPlaying;

        function nowPlaying(){
            if(this.currentTrack != null){
                console.log(`Now playing '${this.currentTrack.name} by ${this.currentTrack.artist}'`);
            }
        }
    }

    function hasParktronic(car){
        car.checkDistance = checkDistance;

        function checkDistance(distance){
            if(distance < 0.1){
                console.log('Beep! Beep! Beep!');
            }
            else if(0.1 <= distance && distance < 0.25){
                console.log('Beep! Beep!');
            }
            else if(0.25 <= distance && distance < 0.5){
                console.log('Beep!');
            }
            else{
                console.log('');
            }
        }
    }

    return decorator;
}
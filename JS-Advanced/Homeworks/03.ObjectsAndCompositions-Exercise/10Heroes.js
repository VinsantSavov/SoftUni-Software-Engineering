function solve(){
    const creator = {};
    creator.mage = function createMage(name){
        const mage = {};
        mage.name = name;
        mage.health = 100;
        mage.mana = 100;
        mage.cast = function cast(spell){
            this.mana--;
            console.log(`${this.name} cast ${spell}`);
        };

        return mage;
    }
    creator.fighter = function createFighter(name){
        const fighter = {};
        fighter.name = name;
        fighter.health = 100;
        fighter.stamina = 100;
        fighter.fight = function fight(){
            this.stamina--;
            console.log(`${name} slashes at the foe!`);
        }


        return fighter;
    }

    return creator;
}

let create = solve();
const scorcher = create.mage('Scorcher');
scorcher.cast('fireball')
scorcher.cast('thunder')
scorcher.cast('light')
const scorcher2 = create.fighter('Scorcher 2');
scorcher2.fight()
console.log(scorcher2.stamina);
console.log(scorcher.mana);
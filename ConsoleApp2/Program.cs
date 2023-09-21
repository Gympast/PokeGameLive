using PokemonCommon;
using PokemonCommon.Characters;
using PokemonCommon.Enums;
using PokemonCommon.Pokemons;
using PokemonCommon.Pokemons.Attacks;


Trainer ash = new Trainer("Ash");

Pokemon sobble = new Pokemon("Sobble", PokeTypes.Water);

Pokemon charmander = new Pokemon("Charmander", PokeTypes.Fire);

WaterGun waterGun = new WaterGun();
Ember ember = new Ember();
Scratch scratch = new Scratch();
charmander.LearnAttack(ember, 0);
CrossChop crossChop = new CrossChop();
charmander.LearnAttack(scratch, 1);

sobble.LearnAttack(waterGun, 0);

sobble.LearnAttack(crossChop, 1);

//Console.WriteLine(sobble.HealthPoints);

//BattleEngine.MakeAttack(sobble, charmander.Attacks[0]);

//Console.WriteLine(sobble.HealthPoints);


BattleEngine.Fight(charmander, sobble);

// Detta är en statisk metod. Statiska metoder anropas via typen och inte via objekt.
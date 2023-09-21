using PokeGame;
using PokemonCommon.Characters;
using PokemonCommon.Enums;
using PokemonCommon.Pokemons;
using PokemonCommon.Pokemons.Attacks;


Trainer ash = new Trainer("Ash");

Pokemon sobble = new Pokemon("Sobble", PokeTypes.Water);

Pokemon charmander = new Pokemon("Charmander", PokeTypes.Fire);

WaterGun waterGun = new WaterGun();
Ember ember = new Ember();
charmander.LearnAttack(ember, 0);
CrossChop crossChop = new CrossChop();

sobble.LearnAttack(waterGun, 0);

sobble.LearnAttack(crossChop, 1);

Console.WriteLine(sobble.HealthPoints);

BattleEngine.MakeAttack(sobble, ember);

Console.WriteLine(sobble.HealthPoints);

// Detta är en statisk metod. Statiska metoder anropas via typen och inte via objekt.
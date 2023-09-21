using PokemonCommon.Enums;
using PokemonCommon.Pokemons;
using PokemonCommon.Pokemons.Attacks;

namespace PokemonCommon;

public static class BattleUi
{
    private static Dictionary<Effectiveness, string> messages = new Dictionary<Effectiveness, string>()
    {
        { Effectiveness.None, "It has no effect!" },
        { Effectiveness.NotVery, "It's not very effectiv..."},
        { Effectiveness.Normal, ""},
        { Effectiveness.Super, "It's super effectiv!"}
    };

    public static void DisplayDamageEffectiveness(Effectiveness effectiveness, Attack attack, Pokemon attacker)
    {
        Console.WriteLine($"{attacker.Name} used {attack.Name} \n{messages[effectiveness]}");
    }
}
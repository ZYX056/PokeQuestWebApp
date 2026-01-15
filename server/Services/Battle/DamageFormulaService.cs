namespace PokeQuest.Server.Services.Battle;

/// <summary>
/// Applies the Pokémon damage formula.
/// </summary>
public class DamageFormulaService
{
    public int CalculateDamage(
        int attackerLevel,
        int movePower,
        int attackStat,
        int defenseStat,
        double typeMultiplier,
        bool isCritical)
    {
        // Base damage formula (simplified Pokémon formula)
        double baseDamage =
            (((2 * attackerLevel / 5.0 + 2)
            * movePower
            * attackStat / defenseStat)
            / 50) + 2;

        // Critical hits multiply damage
        if (isCritical)
            baseDamage *= 1.5;

        // Apply type effectiveness
        baseDamage *= typeMultiplier;

        // Final damage is always at least 1 unless immune
        return typeMultiplier == 0
            ? 0
            : Math.Max(1, (int)Math.Floor(baseDamage));
    }
}

using PokeQuest.server.Models;

namespace PokeQuest.server.Services.Battle;

public class TypeEffectivenessService
{
    private readonly Dictionary<(int Attacker, int Defender), double> _lookup;

    public TypeEffectivenessService(
        IEnumerable<TypeEffectiveness> effectiveness)
    {
        // Build O(1) lookup table ONCE
        _lookup = effectiveness.ToDictionary(
            e => (e.AttackingTypeId, e.DefendingTypeId),
            e => e.Multiplier
        );
    }

    /// <summary>
    /// Calculates the final type multiplier for a move.
    /// </summary>
    public double CalculateMultiplier(
        int moveTypeId,
        IEnumerable<int> defenderTypeIds)
    {
        double multiplier = 1.0;

        foreach (var defenderTypeId in defenderTypeIds)
        {
            multiplier *= _lookup[(moveTypeId, defenderTypeId)];
        }

        return multiplier;
    }
}

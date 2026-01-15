using PokeQuest.server.Models;
using PokeQuest.server.Services.Battle;

namespace PokeQuest.Server.Services.Battle;

/// <summary>
/// Resolves battle actions such as using a move.
/// </summary>
public class BattleCalculationService
{
    private readonly TypeEffectivenessService _typeService;
    private readonly DamageFormulaService _damageService;
    private readonly Random _rng = new();

    public BattleCalculationService(
        TypeEffectivenessService typeService,
        DamageFormulaService damageService)
    {
        _typeService = typeService;
        _damageService = damageService;
    }

    /// <summary>
    /// Resolves a move being used against a Pokémon.
    /// </summary>
    public BattleResult ResolveMove(
        Pokemon attacker,
        Pokemon defender,
        Move move)
    {
        // Extract defender type IDs
        var defenderTypeIds = defender.Types
            .Select(pt => pt.TypeId);

        // Calculate type effectiveness
        double typeMultiplier = _typeService.CalculateMultiplier(
            move.TypeId,
            defenderTypeIds
        );

        // Roll for critical hit (example: 6.25%)
        bool isCritical = _rng.NextDouble() < 0.0625;

        // Calculate final damage
        int damage = _damageService.CalculateDamage(
            attackerLevel: attacker.Level,
            movePower: move.Power,
            attackStat: attacker.BaseAtt,
            defenseStat: defender.BaseDef,
            typeMultiplier: typeMultiplier,
            isCritical: isCritical
        );

        // Return structured result
        return new BattleResult
        {
            DamageDealt = damage,
            TypeMultiplier = typeMultiplier,
            IsCriticalHit = isCritical
        };
    }
}

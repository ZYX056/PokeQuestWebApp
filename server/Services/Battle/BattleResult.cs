namespace PokeQuest.Server.Services.Battle;

/// <summary>
/// Result of a resolved battle action.
/// </summary>
public class BattleResult
{
    public int DamageDealt { get; set; }

    public double TypeMultiplier { get; set; }

    public bool IsCriticalHit { get; set; }

    public bool WasSuperEffective => TypeMultiplier > 1;
    public bool WasNotVeryEffective => TypeMultiplier < 1;
    public bool HadNoEffect => TypeMultiplier == 0;
}

namespace PokeQuest.server.Models
{
    /// <summary>
    /// For handling weaknesses and resistances between types
    /// </summary>
    public class TypeEffectiveness
    {
        public int Id { get; set; } // Primary Key

        // Attacking Pokemon Type
        public int AttackingTypeId { get; set; }
        public Type AttackingType { get; set; } = null!;

        // Defending 
        public int DefendingTypeId { get; set; }
        public Type DefendingType { get; set; } = null!;

        // Damage multiplier
        public double Multiplier { get; set; }
    }
}

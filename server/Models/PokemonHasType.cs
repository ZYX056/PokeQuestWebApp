namespace PokeQuest.server.Models
{
    /// <summary>
    /// Lets you link Pokemon to their Types 
    /// (Need for many-to-many relationships)
    /// </summary>
    public class PokemonHasType
    {
        public int PokemonId { get; set; } // Foreign Key to Pokemon
        public Pokemon Pokemon { get; set; } = null!; // Navigation to Pokemon
        public int TypeId { get; set; } // Foreign Key to Type
        public Type Type { get; set; } = null!; // Navigation to Type
    }
}

namespace PokeQuest.server.Models
{
    /// <summary>
    /// Represents element typing for each pokemon
    /// </summary>
    public class Type
    {
        // Type specific detail fields
        public int TypeId { get; set; } // Primary Key
        public string TypeName { get; set; } // "Fire", "Water", "Grass", etc.

        
    }
}

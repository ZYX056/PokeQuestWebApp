using PokeQuest.server.Models.Enums;

namespace PokeQuest.server.Models
{
    /// <summary>
    /// Represents a single pokemon move in game
    /// </summary>
    public class Move
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // Move name
        public MoveCategory Category { get; set; } // Move category (Physical, Special, Status)
        public string? Description { get; set; } // Move description

        // Move stat fields
        public int Power { get; set; } // Move power
        public int? Accuracy { get; set; } // Move accuracy percentage
        public int MaxPP { get; set; } // Move maximum PP
  
        // Linked fields
        public int TypeId { get; set; } // Move type by Id
        public Type Type { get; set; } // Navigation to Type




    }
}

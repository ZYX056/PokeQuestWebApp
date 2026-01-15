namespace PokeQuest.server.Models
{
    /// <summary>
    /// Represents a Trainer (player) in the PokeQuest system.
    /// </summary>
    public class Trainer
    {
        public int Id { get; set; } // Primary Key
        public string UserName { get; set; } // Unique username/login for the trainer
        public string DisplayName { get; set; } = null!; // Display name for trainer character
        public string AuthUserId { get; set; } = null!; // Authentication reference
        public ICollection<Party> Parties { get; set; } = new List<Party>(); // Navigation: Parties owned by the trainer
        public ICollection<TrainerPermission> Permissions { get; set; } = new List<TrainerPermission>(); // Navigation: Permissions assigned to this trainer in the campaigns
    }
}

namespace PokeQuest.server.Models
{
    /// <summary>
    /// Represents a Trainer (player) in the PokeQuest system.
    /// </summary>
    public class Trainer
    {
        public int Id { get; set; }
        // Unique username/login for the trainer
        public string UserName { get; set; }
        // Display name for trainer character
        public string DisplayName { get; set; } = null!;
        // Authentication reference
        public string AuthUserId { get; set; } = null!;
        // Navigation: Parties owned by the trainer
        public ICollection<Party> Parties { get; set; } = new List<Party>();
        // Navigation: Permissions assigned to this trainer in the campaigns
        public ICollection<TrainerPermission> Permissions { get; set; } = new List<TrainerPermission>();
    }
}

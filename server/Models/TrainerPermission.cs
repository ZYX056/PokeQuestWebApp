namespace PokeQuest.server.Models
{

    /// <summary>
    /// Defines permissions for a trainer within a specific campaign.
    /// </summary>
    public class TrainerPermission
    {
        public int Id { get; set; } // Primary key

        public int TrainerId { get; set; } // Foreign key to Trainer
        public Trainer Trainer { get; set; } = null!; // Navigation property to Trainer

        public int CampaignId { get; set; } // Foreign key to Campaign
        public Campaign Campaign { get; set; } = null!; // Navigation property to Campaign

        public string Permission { get; set; } = null!; // Permission type (e.g., "Admin", "Editor", "Viewer")
    }
}

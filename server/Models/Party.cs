namespace PokeQuest.server.Models
{
    /// <summary>
    /// Represents a trainer's Pokemon party within a campaign.
    /// </summary>

    public class Party
    {
        public int Id { get; set; } // Primary Key

        public string Name { get; set; } = "Main Party"; // Party name with default value 

        public int TrainerId { get; set; } // Foreign key to Trainer
        public Trainer Trainer { get; set; } = null!; // Navigation property to Trainer

        public int CampaignId { get; set; } // Foreign key to Campaign
        public Campaign Campaign { get; set; } = null!; // Navigation property to Campaign

        // Pokemon belonging to this party
        public ICollection<Pokemon> Pokemon { get; set; } = new List<Pokemon>();
    }
}

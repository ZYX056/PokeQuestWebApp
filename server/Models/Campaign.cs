namespace PokeQuest.server.Models
{
    /// <summary>
    /// Represents a multiplayer campaign in PokeQuest.
    /// Contains Trainers, Parties, and Campaign-wide states.
    /// </summary>
    public class Campaign
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } = null!; // Campaign name

        public ICollection<Trainer> Trainsers { get; set; } = new List<Trainer>(); // Trainers participating in this campaign
        public ICollection<Party> Parties { get; set; } = new List<Party>(); // Parties in the campaign
    }
}

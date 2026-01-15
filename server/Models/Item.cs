namespace PokeQuest.server.Models
{
    /// <summary>
    /// Represents items in a trainer's bag. 
    /// Used for keeping track of items in the UX/UI
    /// </summary>
    public class Item
    {
        public int Id { get; set;  } // Primary Key
        public string Name { get; set; } // Item's name
        public int Quantity { get; set; } // Amount available
        public int TrainerId { get; set; } // Owner of the item by Id
        public Trainer Trainer { get; set; } // Navigation to Trainer
    }
}

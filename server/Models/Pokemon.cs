namespace PokeQuest.server.Models
{
    /// <summary>
    /// Represents a pokemon
    /// </summary>

    public class Pokemon
    {
        // Pokemon specific detail fields
        public int Id { get; set; } // Primary Key
        public string Species { get; set; } // Pokedex Registered species (i.e. Pikachu, Raichu, etc)
        public string Nickname { get; set; } = null!; // Player given name
        
        public int Level { get; set; } // Pokemon's lvl
        //Typing for UX/UI and apply type weaknesses
        public int PrimaryTypeId { get; set; } 
        public Type PrimaryType { get; set; }
        public int secondaryTypeId { get; set; }
        public Type SecondaryType { get; set; } = null!;
        //Stats
        public int BaseHp { get; set; }
        public int BaseAtt { get; set; }
        public int BaseDef { get; set; }
        public int BaseSpAtt { get; set; }
        public int BaseSpDef { get; set; }
        public int BaseSpeed { get; set; }
        public int HpModifier { get; set; } = 0;
        public int AttModifier { get; set; } = 0;
        public int DefModifier { get; set; } = 0;
        public int SpAttModifier { get; set; } = 0;
        public int SpDefModifier { get; set; } = 0;
        public int SpeedModifier { get; set; } = 0;


        // Linked fields
        public int PartyId { get; set; } // Party pokemon belongs to
        public Party Party { get; set; } = null!; // Navigation to party
        public ICollection<PokemonHasType> Types { get; set; } = new List<PokemonHasType>()


        // DM-controlled authority fields
        public bool IsShiny { get; set; } = false; // For toggling unique shiny status
        // IsShiny set to false as default until toggled
        public bool IsLegendary { get; set; } = false; // For toggling Legendaries
        // IsLegendary set to false as default until toggled


    }
}

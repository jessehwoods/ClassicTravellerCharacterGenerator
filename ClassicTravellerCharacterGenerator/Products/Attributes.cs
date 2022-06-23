using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicTravellerCharacterGenerator.Products
{
    /// <summary>
    /// Contains the six attributes that define a character in Traveller.
    /// </summary>
    /// <remarks>
    /// Attribute values typically range from 1-15. An attribute of 0 or less generally means that the character is dead. Attributes over 15 should be
    /// hypothetically possible, but the system for representing them, the pseudo-hexadecimal notation described on p. 8 of the first Traveller book, has
    /// a maximum value of 15.
    /// </remarks>
    internal class Attributes
    {
        public int Strength { get; private set; }
        public int Dexterity { get; private set; }
        public int Endurance { get; private set; }
        public int Intelligence { get; private set; }
        public int Education { get; private set; }
        public int SocialStanding { get; private set; }


        public Attributes(int strength, int dexterity, int endurance, int intelligence, int education, int socialStanding)
        {
            if(strength < 0 || dexterity < 0 || endurance < 0 || intelligence < 0 || education < 0 || socialStanding < 0)
            {
                throw new ArgumentOutOfRangeException("No attribute can be less than 0.");
            }
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Endurance = endurance;
            this.Intelligence = intelligence;
            this.Education = education;
            this.SocialStanding = socialStanding;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicTravellerCharacterGenerator.Products
{
    internal class Attributes
    {
        public int Strength { get; }
        public int Dexterity { get; }
        public int Endurance { get; }
        public int Intelligence { get; }
        public int Education { get; }
        public int SocialStanding { get; }


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


using ClassicTravellerCharacterGenerator.Products;
using System;
using TravellerCharacterGenerator.Dice;
using TravellerCharacterGenerator.Products;

namespace TravellerCharacterGenerator.Factories
{
    internal class CharacterRoller
    {
        private DiceRoller diceRoller;

        public CharacterRoller(DiceRoller diceRoller)
        {
            this.diceRoller = diceRoller;
        }

        internal Attributes RollCharacter()
        {
            throw new NotImplementedException();
        }
    }
}

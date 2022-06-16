
using System;
using TravellerCharacterGenerator.Products;

namespace TravellerCharacterGenerator.Factories
{
    internal class CharacterRoller
    {
        private object value;

        public CharacterRoller(object value)
        {
            this.value = value;
        }

        internal Character RollCharacter(string testCharacterName)
        {
            throw new NotImplementedException();
        }
    }
}

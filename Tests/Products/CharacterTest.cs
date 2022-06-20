using ClassicTravellerCharacterGenerator.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TravellerCharacterGenerator.Products;

namespace TravellerCharacterGeneratorTests.Products
{

    [TestClass]
    public class CharacterTest
    {

        private Character testCharacter;
        private readonly string testCharacterName = "testCharacterName";
        private Attributes testAttributes;
        private readonly string[] testEmptyStringArray = { };

        // Dummy Skills object for use in testing the character constructor
        private class EmptySkills: Skills
        {
            internal EmptySkills()
            {
                // Empty constructor
            }

            internal string[] GetSkills()
            {
                string[] toReturn = { };
                return toReturn;
            }
        }
        // Dummy inventory object use in testing the character constructor
        private class EmptyInventory: Inventory
        {
            internal EmptyInventory()
            {
                // Empty constructor
            }

            internal string[] GetSkills()
            {
                string[] toReturn = { };
                return toReturn;
            }

            internal int GetCash()
            {
                return 0;
            }
        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Null_Input_For_Attributes()
        {

        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Null_Inventory_Input()
        {

        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Null_Skills_Input()
        {

        }

        [TestMethod]
        public void Valid_Construction_Should_Return_All_Input_Objects()
        {

        }
    }
}

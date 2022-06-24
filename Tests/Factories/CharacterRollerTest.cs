using ClassicTravellerCharacterGenerator.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TravellerCharacterGenerator.Dice;
using TravellerCharacterGenerator.Factories;
using TravellerCharacterGenerator.Products;

namespace TravellerCharacterGeneratorTest.Factories
{
    [TestClass]
    public class CharacterRollerTest
    {
        private CharacterRoller testCharacterRoller;
        private DiceRoller testDiceRoller;
        private Characteristics testAttributes;

        [TestMethod]
        public void ArgumentException_From_Constructor_With_Null_DiceRoller()
        {
            try
            {
                testCharacterRoller = new CharacterRoller(null);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsNull(testCharacterRoller);
            }
        }

        [TestMethod]
        public void No_ArgumentException_From_Constructor_With_DiceRoller()
        {
            testDiceRoller = new DiceRoller();
            testCharacterRoller = new CharacterRoller(testDiceRoller);
        }

        [TestMethod]
        public void Generates_Valid_Attributes_Object_With_Rolled_Characteristics_And_Age_Eighteen()
        {
            for (int i = 1; i <= 6; i++)
            {
                testDiceRoller = null;
                testCharacterRoller = null;
                testAttributes = null;
                testDiceRoller = new DiceRoller(i);
                testCharacterRoller = new CharacterRoller(testDiceRoller);
                testAttributes = testCharacterRoller.RollCharacter();
                Assert.AreEqual(i * 2, testAttributes.Strength );
                Assert.AreEqual(i * 2, testAttributes.Dexterity);
                Assert.AreEqual(i * 2, testAttributes.Endurance);
                Assert.AreEqual(i * 2, testAttributes.Intelligence);
                Assert.AreEqual(i * 2, testAttributes.Education);
                Assert.AreEqual(i * 2, testAttributes.SocialStanding);
            }
        }

    }
}

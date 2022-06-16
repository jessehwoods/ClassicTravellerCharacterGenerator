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
        private Character testCharacter;

        private string testCharacterName = "name"; // Name to be used for test character.
        private int startingAge = 18; // Expected age of a freshly rolled character.

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
        public void Generates_Valid_Character_Object_With_Rolled_Characteristics_And_Age_Eighteen()
        {
            for (int i = 1; i <= 6; i++)
            {
                testDiceRoller = null;
                testCharacterRoller = null;
                testCharacter = null;
                testDiceRoller = new DiceRoller(i);
                testCharacterRoller = new CharacterRoller(testDiceRoller);
                testCharacter = testCharacterRoller.RollCharacter(testCharacterName);
                Assert.AreEqual(testCharacterName, testCharacter.GetName());
                Assert.AreEqual(i * 2, testCharacter.GetStrength() );
                Assert.AreEqual(i * 2, testCharacter.GetDexterity());
                Assert.AreEqual(i * 2, testCharacter.GetEndurance());
                Assert.AreEqual(i * 2, testCharacter.GetIntelligence());
                Assert.AreEqual(i * 2, testCharacter.GetEducation());
                Assert.AreEqual(i * 2, testCharacter.GetSocialStanding());
                Assert.AreEqual(startingAge, testCharacter.GetSocialStanding());
            }
        }

        [TestMethod]
        public void InvalidOperation_Thrown_By_Getting_Career_From_Rolled_Character()
        {
            testDiceRoller = new DiceRoller(1);
            testCharacterRoller = new CharacterRoller(testDiceRoller);
            testCharacter = testCharacterRoller.RollCharacter(testCharacterName);
            try
            {
                testCharacter.getCareer();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                Assert.AreEqual(testCharacterName, testCharacter.GetName());
            }
        }

        [TestMethod]
        public void InvalidOperation_Thrown_By_Getting_Rank_From_Rolled_Character()
        {
            testDiceRoller = new DiceRoller(1);
            testCharacterRoller = new CharacterRoller(testDiceRoller);
            testCharacter = testCharacterRoller.RollCharacter(testCharacterName);
            try
            {
                testCharacter.getRank();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                Assert.AreEqual(testCharacterName, testCharacter.GetName());
            }
        }

        [TestMethod]
        public void InvalidOperation_Thrown_By_Getting_Terms_From_Rolled_Character()
        {
            testDiceRoller = new DiceRoller(1);
            testCharacterRoller = new CharacterRoller(testDiceRoller);
            testCharacter = testCharacterRoller.RollCharacter(testCharacterName);
            try
            {
                testCharacter.getTerms();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                Assert.AreEqual(testCharacterName, testCharacter.GetName());
            }
        }

        [TestMethod]
        public void InvalidOperation_Thrown_By_Getting_Skills_From_Rolled_Character()
        {
            testDiceRoller = new DiceRoller(1);
            testCharacterRoller = new CharacterRoller(testDiceRoller);
            testCharacter = testCharacterRoller.RollCharacter(testCharacterName);
            try
            {
                testCharacter.getSkills();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                Assert.AreEqual(testCharacterName, testCharacter.GetName());
            }
        }

        [TestMethod]
        public void InvalidOperation_Thrown_By_Getting_Inventory_From_Rolled_Character()
        {
            testDiceRoller = new DiceRoller(1);
            testCharacterRoller = new CharacterRoller(testDiceRoller);
            testCharacter = testCharacterRoller.RollCharacter(testCharacterName);
            try
            {
                testCharacter.getInventory();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                Assert.AreEqual(testCharacterName, testCharacter.GetName());
            }
        }

        [TestMethod]
        public void InvalidOperation_Thrown_By_Getting_Cash_From_Rolled_Character()
        {
            testDiceRoller = new DiceRoller(1);
            testCharacterRoller = new CharacterRoller(testDiceRoller);
            testCharacter = testCharacterRoller.RollCharacter(testCharacterName);
            try
            {
                testCharacter.getCash();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                Assert.AreEqual(testCharacterName, testCharacter.GetName());
            }
        }
    }
}

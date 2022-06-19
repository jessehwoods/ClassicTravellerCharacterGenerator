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
            // first attribute is invalid
            testAttributes = null;
            try
            {
                testCharacter = new Character(testCharacterName, 
                    testAttributes);
                Assert.Fail();
            } catch (ArgumentException)
            {
                Assert.IsNull(testCharacter);
            }
        }

        [TestMethod]
        public void No_ArgumentException_Should_Be_Thrown_By_Nonnegative_Integer_Inputs_For_Attributes()
        {
            testCharacter = null;
            testCharacter = new Character(testCharacterName, testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes);
            Assert.IsNotNull(testCharacter);
            Assert.AreEqual(testCharacterName, testCharacter.GetName());
            //Check attributes
            Assert.AreEqual(testValidAttributes, testCharacter.GetStrength());
            Assert.AreEqual(testValidAttributes, testCharacter.GetEndurance());
            Assert.AreEqual(testValidAttributes, testCharacter.GetDexterity());
            Assert.AreEqual(testValidAttributes, testCharacter.GetIntelligence());
            Assert.AreEqual(testValidAttributes, testCharacter.GetEducation());
            Assert.AreEqual(testValidAttributes, testCharacter.GetSocialStanding());
            // Check that skills and inventory exist
            Assert.IsNotNull(testCharacter.GetInventory());
            Assert.IsNotNull(testCharacter.GetSkills());
        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Null_Inventory_Input()
        {
            testCharacter = null;
            try
            {
                testCharacter = new Character(testCharacterName, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes,
                    new EmptySkills(),
                    null,
                    testLowestValidCash
                    );
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsNull(testCharacter);
            }
        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Null_Skills_Input()
        {
            testCharacter = null;
            try
            {
                testCharacter = new Character(testCharacterName,
                    testValidAttributes,
                    testValidAttributes,
                    testValidAttributes,
                    testValidAttributes,
                    testValidAttributes,
                    testValidAttributes,
                    null,
                    new EmptyInventory(),
                    testLowestValidCash
                    );
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsNull(testCharacter);
            }
        }

        [TestMethod]
        public void Valid_Construction_Should_Return_All_Input_Objects()
        {
            testCharacter = new Character(testCharacterName,
                    testValidAttributes,
                    testValidAttributes,
                    testValidAttributes,
                    testValidAttributes,
                    testValidAttributes,
                    testValidAttributes,
                    new EmptySkills(),
                    new EmptyInventory()
                    );
            Assert.AreEqual(testValidAttributes, testCharacter.GetStrength());
            Assert.AreEqual(testValidAttributes, testCharacter.GetEndurance());
            Assert.AreEqual(testValidAttributes, testCharacter.GetDexterity());
            Assert.AreEqual(testValidAttributes, testCharacter.GetIntelligence());
            Assert.AreEqual(testValidAttributes, testCharacter.GetEducation());
            Assert.AreEqual(testValidAttributes, testCharacter.GetSocialStanding());
            Assert.AreEqual(testEmptyStringArray, testCharacter.GetSkills());
            Assert.AreEqual(testEmptyStringArray, testCharacter.GetInventory());
            Assert.AreEqual(testLowestValidCash, testCharacter.GetCash());
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TravellerCharacterGenerator.Products;

namespace TravellerCharacterGeneratorTests.Products
{

    [TestClass]
    public class CharacterTest
    {

        private Character testCharacter;
        private string testCharacterName = "testCharacterName";
        private int testValidAttributes = 7;
        private int testInvalidAttributes = -1;

        // Dummy Skills object for use in testing
        private class emptySkills: Skills
        {
        }
        // Dummy inventory object use in testing
        private class emptyInventory: Inventory
        {
        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Negative_Integer_Inputs_For_Attributes()
        {
            // first attribute is invalid
            testCharacter = null;
            try
            {
                testCharacter = new Character(testCharacterName, testInvalidAttributes, testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes);
                Assert.Fail();
            } catch (ArgumentException)
            {
                Assert.IsNull(testCharacter);
            }
            testCharacter = null;
            // second attribute is invalid
            try
            {
                testCharacter = new Character(testCharacterName, testValidAttributes, testInvalidAttributes, testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsNull(testCharacter);
            }
            // third attribute is invalid
            try
            {
                testCharacter = new Character(testCharacterName, testValidAttributes, testValidAttributes, testInvalidAttributes, testValidAttributes, testValidAttributes, testValidAttributes);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsNull(testCharacter);
            }
            // fourth attribute is invalid
            try
            {
                testCharacter = new Character(testCharacterName, testValidAttributes, testValidAttributes, testValidAttributes, testInvalidAttributes, testValidAttributes, testValidAttributes);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsNull(testCharacter);
            }
            // fifth attribute is invalid
            try
            {
                testCharacter = new Character(testCharacterName, testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes, testInvalidAttributes, testValidAttributes);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsNull(testCharacter);
            }
            // sixth attribute is invalid
            try
            {
                testCharacter = new Character(testCharacterName, testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes, testInvalidAttributes);
                Assert.Fail();
            }
            catch (ArgumentException)
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
            // Check that skills and inventory exist, but contain nothing
            Assert.IsNotNull(testCharacter.GetInventory());
            Assert.IsNotNull(testCharacter.GetSkills());
            Assert.IsTrue(testCharacter.getSkills.isEmpty());
        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Negative_Integer_Input_For_Cash()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void No_ArgumentException_Should_Be_Thrown_By_Nonnegative_Integer_Inputs_For_Cash()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Null_Inventory_Input()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Null_Skills_Input()
        {
            Assert.Fail();
        }

    }
}

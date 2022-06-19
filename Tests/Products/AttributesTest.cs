using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TravellerCharacterGenerator.Products;

namespace TravellerCharacterGeneratorTests.Products
{

    [TestClass]
    public class AttributesTest
    {

        private readonly int testValidAttributes = 7;
        private readonly int testInvalidAttributes = -1;

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Negative_Integer_Inputs_For_Attributes()
        {
            // first attribute is invalid
            testCharacter = null;
            try
            {
                testCharacter = new Character(testCharacterName, 
                    testInvalidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes);
                Assert.Fail();
            } catch (ArgumentException)
            {
                Assert.IsNull(testCharacter);
            }
            testCharacter = null;
            // second attribute is invalid
            try
            {
                testCharacter = new Character(testCharacterName, 
                    testValidAttributes, 
                    testInvalidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsNull(testCharacter);
            }
            // third attribute is invalid
            try
            {
                testCharacter = new Character(testCharacterName, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testInvalidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsNull(testCharacter);
            }
            // fourth attribute is invalid
            try
            {
                testCharacter = new Character(testCharacterName, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testInvalidAttributes, 
                    testValidAttributes, 
                    testValidAttributes);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsNull(testCharacter);
            }
            // fifth attribute is invalid
            try
            {
                testCharacter = new Character(testCharacterName, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testInvalidAttributes, 
                    testValidAttributes);
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
        public void ArgumentException_Should_Be_Thrown_By_Negative_Integer_Input_For_Cash()
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
                    new EmptyInventory(),
                    testInvalidAttributes
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
            EmptySkills testSkills = new EmptySkills;
            EmptyInventory testInventory = new EmptyInventory;
            testCharacter = new Character(testCharacterName,
                    testValidAttributes,
                    testValidAttributes,
                    testValidAttributes,
                    testValidAttributes,
                    testValidAttributes,
                    testValidAttributes,
                    new EmptySkills(),
                    new EmptyInventory(),
                    testLowestValidCash
                    );
            Assert.AreEqual(testValidAttributes, testCharacter.GetStrength());
            Assert.AreEqual(testValidAttributes, testCharacter.GetEndurance());
            Assert.AreEqual(testValidAttributes, testCharacter.GetDexterity());
            Assert.AreEqual(testValidAttributes, testCharacter.GetIntelligence());
            Assert.AreEqual(testValidAttributes, testCharacter.GetEducation());
            Assert.AreEqual(testValidAttributes, testCharacter.GetSocialStanding());
            Assert.AreEqual(testSkills, testCharacter.GetSkills());
            Assert.AreEqual(testInventory, testCharacter.GetInventory());
            Assert.AreEqual(testLowestValidCash, testCharacter.GetCash());
        }
    }
}

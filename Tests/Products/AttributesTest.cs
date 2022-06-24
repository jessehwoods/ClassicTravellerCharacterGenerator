using ClassicTravellerCharacterGenerator.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TravellerCharacterGenerator.Products;

namespace TravellerCharacterGeneratorTests.Products
{

    [TestClass]
    public class AttributesTest
    {
        private Characteristics testAttributes;
        private readonly int testValidAttributes = 7;
        private readonly int testInvalidAttributes = -1;

        [TestMethod]
        public void ArgumentOutOfRangeException_Should_Be_Thrown_By_Negative_Integer_Inputs_For_Attributes()
        {
            // first attribute is invalid
            testAttributes = null;
            try
            {
                testAttributes = new Characteristics( 
                    testInvalidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes);
                Assert.Fail();
            } catch (ArgumentOutOfRangeException)
            {
                Assert.IsNull(testAttributes);
            }
            testAttributes = null;
            // second attribute is invalid
            try
            {
                testAttributes = new Characteristics( 
                    testValidAttributes, 
                    testInvalidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsNull(testAttributes);
            }
            // third attribute is invalid
            try
            {
                testAttributes = new Characteristics( 
                    testValidAttributes, 
                    testValidAttributes, 
                    testInvalidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsNull(testAttributes);
            }
            // fourth attribute is invalid
            try
            {
                testAttributes = new Characteristics( 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testInvalidAttributes, 
                    testValidAttributes, 
                    testValidAttributes);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsNull(testAttributes);
            }
            // fifth attribute is invalid
            try
            {
                testAttributes = new Characteristics( 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testInvalidAttributes, 
                    testValidAttributes);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsNull(testAttributes);
            }
            // sixth attribute is invalid
            try
            {
                testAttributes = new Characteristics(
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testInvalidAttributes);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsNull(testAttributes);
            }
        }

        [TestMethod]
        public void No_ArgumentOutOfRangeException_Should_Be_Thrown_By_Nonnegative_Integer_Inputs_For_Attributes()
        {
            testAttributes = null;
            testAttributes = new Characteristics(testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes);
            Assert.IsNotNull(testAttributes);
            //Check attributes
            Assert.AreEqual(testValidAttributes, testAttributes.Strength);
            Assert.AreEqual(testValidAttributes, testAttributes.Endurance);
            Assert.AreEqual(testValidAttributes, testAttributes.Dexterity);
            Assert.AreEqual(testValidAttributes, testAttributes.Intelligence);
            Assert.AreEqual(testValidAttributes, testAttributes.Education);
            Assert.AreEqual(testValidAttributes, testAttributes.SocialStanding);
        }
    }
}

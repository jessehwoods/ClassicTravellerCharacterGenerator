using ClassicTravellerCharacterGenerator.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TravellerCharacterGenerator.Products;

namespace TravellerCharacterGeneratorTests.Products
{

    [TestClass]
    public class AttributesTest
    {
        private Attributes testAttributes;
        private readonly int testValidAttributes = 7;
        private readonly int testInvalidAttributes = -1;

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Negative_Integer_Inputs_For_Attributes()
        {
            // first attribute is invalid
            testAttributes = null;
            try
            {
                testAttributes = new Attributes( 
                    testInvalidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes);
                Assert.Fail();
            } catch (ArgumentException)
            {
                Assert.IsNull(testAttributes);
            }
            testAttributes = null;
            // second attribute is invalid
            try
            {
                testAttributes = new Attributes( 
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
                Assert.IsNull(testAttributes);
            }
            // third attribute is invalid
            try
            {
                testAttributes = new Attributes( 
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
                Assert.IsNull(testAttributes);
            }
            // fourth attribute is invalid
            try
            {
                testAttributes = new Attributes( 
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
                Assert.IsNull(testAttributes);
            }
            // fifth attribute is invalid
            try
            {
                testAttributes = new Attributes( 
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
                Assert.IsNull(testAttributes);
            }
            // sixth attribute is invalid
            try
            {
                testAttributes = new Attributes(
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testValidAttributes, 
                    testInvalidAttributes);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsNull(testAttributes);
            }
        }

        [TestMethod]
        public void No_ArgumentException_Should_Be_Thrown_By_Nonnegative_Integer_Inputs_For_Attributes()
        {
            testAttributes = null;
            testAttributes = new Attributes(testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes, testValidAttributes);
            Assert.IsNotNull(testAttributes);
            //Check attributes
            Assert.AreEqual(testValidAttributes, testAttributes.GetStrength());
            Assert.AreEqual(testValidAttributes, testAttributes.GetEndurance());
            Assert.AreEqual(testValidAttributes, testAttributes.GetDexterity());
            Assert.AreEqual(testValidAttributes, testAttributes.GetIntelligence());
            Assert.AreEqual(testValidAttributes, testAttributes.GetEducation());
            Assert.AreEqual(testValidAttributes, testAttributes.GetSocialStanding());

        }
    }
}

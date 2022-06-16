using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravellerCharacterGenerator.Products;

namespace TravellerCharacterGeneratorTests.Products
{
    [TestClass]
    public class CharacterTest
    {

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
            Assert.Fail();
        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Negative_Integer_Input_For_Cash()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void No_ArgumentException_Should_Be_Thrown_By_Nonnegative_Integer_Inputs_For_Attributes()
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

        [TestMethod]
        public void Validly_Constructed_Object_Should_Return_Input_Values_And_Throw_InvalidOperationException_For_Not_Input_Values()
        {
            Assert.Fail();
        }

    }
}

using ClassicTravellerCharacterGenerator.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using TravellerCharacterGenerator.Products;

namespace TravellerCharacterGeneratorTests.Products
{

    [TestClass]
    public class CharacterTest
    {

        private Character testCharacter;
        private readonly string testCharacterName = "testCharacterName";
        private Mock<Career> testCareer;
        private Mock<Characteristics> testCharacteristics;
        private Mock<Skills> testSkills;
        private Mock<Inventory> testInventory;




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

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
        private Mock<ICareer> testCareer;
        private Mock<ICharacteristics> testCharacteristics;
        private Mock<ISkills> testSkills;
        private Mock<IInventory> testInventory;

        private readonly int ageYears = 18;
        private readonly int ageMonths = 6;
        private readonly int terms = 0;
        private readonly bool testCommissioned = true;
        private readonly string testCareerName = "testCareer";
        private readonly int rankLevel = 1;
        private readonly string rankName = "rankName";
        private readonly int charactertistic = 7;
        private readonly string[] testSkillList = { "skill-1" };
        private readonly string[] testInventoryList = { "item" };


        [TestInitialize]
        public void Construct_Dummy_Objects()
        {
            // Set up characteristics
            testCharacteristics = new Mock<ICharacteristics>();
            testCharacteristics.SetupGet(x => x.Strength).Returns(charactertistic);
            testCharacteristics.SetupGet(x => x.Dexterity).Returns(charactertistic);
            testCharacteristics.SetupGet(x => x.Endurance).Returns(charactertistic);
            testCharacteristics.SetupGet(x => x.Intelligence).Returns(charactertistic);
            testCharacteristics.SetupGet(x => x.Education).Returns(charactertistic);
            testCharacteristics.SetupGet(x => x.SocialStanding).Returns(charactertistic);
            // Set up career
            testCareer = new Mock<ICareer>();
            testCareer.SetupGet(x => x.AgeYears).Returns(ageYears);
            testCareer.SetupGet(x => x.AgeMonths).Returns(ageMonths);
            testCareer.SetupGet(x => x.CareerName).Returns(testCareerName);
            testCareer.SetupGet(x => x.Terms).Returns(terms);
            testCareer.Setup(x => x.GetRankLevel()).Returns(rankLevel);
            testCareer.Setup(x => x.GetRankName()).Returns(rankName);
            testCareer.SetupGet(x => x.Commissioned).Returns(testCommissioned);
            // Set up Skills
            testSkills = new Mock<ISkills>();
            testSkills.SetupGet(x => x.SkillsArray).Returns(testSkillList);
            //Set up Inventory
            testInventory = new Mock<IInventory>();
            testInventory.SetupGet(x => x.ItemArray).Returns(testInventoryList);
        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Null_Input_For_Name()
        {
            testCharacter = null;
            try
            {
                testCharacter = new Character(null, testCharacteristics.Object, testCareer.Object, testSkills.Object, testInventory.Object);
                Assert.Fail();
            }
            catch
            {
                Assert.IsNull(testCharacter);
            }
        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Null_Input_For_Characteristics()
        {
            testCharacter = null;
            try
            {
                testCharacter = new Character(testCharacterName, null, testCareer.Object, testSkills.Object, testInventory.Object);
                Assert.Fail();
            }
            catch
            {
                Assert.IsNull(testCharacter);
            }
        }


        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Null_Career_Input()
        {
            testCharacter = null;
            try
            {
                testCharacter = new Character(testCharacterName, testCharacteristics.Object, null, testSkills.Object, testInventory.Object);
                Assert.Fail();
            }
            catch
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
                testCharacter = new Character(testCharacterName, testCharacteristics.Object, testCareer.Object, null, testInventory.Object);
                Assert.Fail();
            }
            catch
            {
                Assert.IsNull(testCharacter);
            }
        }
        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Null_Inventory_Input()
        {
            testCharacter = null;
            try
            {
                testCharacter = new Character(testCharacterName, testCharacteristics.Object, testCareer.Object, testSkills.Object, null);
                Assert.Fail();
            }
            catch
            {
                Assert.IsNull(testCharacter);
            }
        }

        [TestMethod]
        public void Valid_Construction_Should_Return_All_Input_Objects()
        {
            testCharacter = new Character(testCharacterName, testCharacteristics.Object, testCareer.Object, testSkills.Object, testInventory.Object);
            // Check name
            Assert.AreEqual(testCharacterName, testCharacter.Name);
            // Check characteristics
            Assert.AreEqual(charactertistic, testCharacter.Strength);
            Assert.AreEqual(charactertistic, testCharacter.Dexterity);
            Assert.AreEqual(charactertistic, testCharacter.Endurance);
            Assert.AreEqual(charactertistic, testCharacter.Intelligence);
            Assert.AreEqual(charactertistic, testCharacter.Education);
            Assert.AreEqual(charactertistic, testCharacter.SocialStanding);
            // Check career
            Assert.AreEqual(ageYears, testCharacter.AgeYears);
            Assert.AreEqual(ageMonths, testCharacter.AgeMonths);
            Assert.AreEqual(testCareerName, testCharacter.CareerName);
            Assert.AreEqual(rankLevel, testCharacter.GetRankLevel());
            Assert.AreEqual(rankName, testCharacter.GetRankName());
            Assert.AreEqual(testCommissioned, testCharacter.Commissioned);
            // Check skills
            Assert.AreEqual(testSkillList, testCharacter.Skills);
            // Check inventory
            Assert.AreEqual(testInventoryList, testCharacter.Inventory);

        }
    }
}

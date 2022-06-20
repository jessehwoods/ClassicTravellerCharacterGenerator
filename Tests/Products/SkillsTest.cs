using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravellerCharacterGenerator.Products;

namespace TravellerCharacterGeneratorTests.Products
{
    [TestClass]
    public class SkillsTest
    {
        Skills testSkills;
        private readonly string firstSkill = "firstSkill";
        private readonly string secondSkill = "secondSkill";


        [TestMethod]
        public void New_Skills_Should_Start_Empty()
        {
            testSkills = new Skills();
            Assert.AreEqual(0, testSkills.NumberOfSkills());
        }

        [TestMethod]
        public void AddZeroSkill_Adds_Skill_At_Zero()
        {
            testSkills = new Skills();
            testSkills.AddZeroSkill(firstSkill);
            Assert.AreEqual(1, testSkills.NumberOfSkills());
            Assert.AreEqual( firstSkill + "-0", testSkills.ToString());
        }

        [TestMethod]
        public void AddSkills_Starts_Skills_At_One()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void Adding_Skill_Again_Raises_Level_By_One()
        {
            Assert.Fail();
        }

    }
}

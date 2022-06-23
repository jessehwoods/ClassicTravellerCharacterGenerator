using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            Assert.AreEqual(0, testSkills.NumberOfSkills);
        }

        [TestMethod]
        public void AddZeroSkill_Adds_Skill_At_Zero()
        {
            testSkills = new Skills();
            testSkills.AddZeroSkill(firstSkill);
            Assert.AreEqual(1, testSkills.NumberOfSkills);
            Assert.AreEqual( firstSkill + "-0", testSkills.ToString());
        }

        [TestMethod]
        public void AddZeroSkill_Throws_ArgumentException_If_Skill_Already_Exists()
        {
            testSkills = new Skills();
            testSkills.AddZeroSkill(firstSkill);
            Assert.AreEqual(1, testSkills.NumberOfSkills);
            try
            {
                testSkills.AddZeroSkill(firstSkill);
                Assert.Fail();
            } catch (ArgumentException)
            {
                Assert.AreEqual(firstSkill + "-0", testSkills.ToString());
                Assert.AreEqual(1, testSkills.NumberOfSkills);
            }

            testSkills = new Skills();
            testSkills.AddSkill(firstSkill);
            Assert.AreEqual(1, testSkills.NumberOfSkills);
            try
            {
                testSkills.AddZeroSkill(firstSkill);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.AreEqual(firstSkill + "-1", testSkills.ToString());
                Assert.AreEqual(1, testSkills.NumberOfSkills);
            } 
        }

        [TestMethod]
        public void AddSkills_Starts_Skills_At_One()
        {
            testSkills = new Skills();
            testSkills.AddSkill(firstSkill);
            Assert.AreEqual(firstSkill + "-1", testSkills.ToString());
            Assert.AreEqual(1, testSkills.NumberOfSkills);
        }

        [TestMethod]
        public void AddSkills_Moves_Zero_Level_Skill_To_One()
        {
            testSkills = new Skills();
            testSkills.AddZeroSkill(firstSkill);
            Assert.AreEqual(firstSkill + "-0", testSkills.ToString());
            Assert.AreEqual(1, testSkills.NumberOfSkills);
            testSkills.AddSkill(firstSkill);
            Assert.AreEqual(firstSkill + "-1", testSkills.ToString());
            Assert.AreEqual(1, testSkills.NumberOfSkills);
        }

        [TestMethod]
        public void Adding_Skill_Again_Raises_Level_By_One()
        {
            testSkills = new Skills();
            testSkills.AddSkill(firstSkill);
            Assert.AreEqual(firstSkill + "-1", testSkills.ToString());
            Assert.AreEqual(1, testSkills.NumberOfSkills);
            testSkills.AddSkill(firstSkill);
            Assert.AreEqual(firstSkill + "-2", testSkills.ToString());
            Assert.AreEqual(1, testSkills.NumberOfSkills);
            testSkills.AddSkill(firstSkill);
            Assert.AreEqual(firstSkill + "-3", testSkills.ToString());
            Assert.AreEqual(1, testSkills.NumberOfSkills);
            testSkills.AddSkill(firstSkill);
            Assert.AreEqual(firstSkill + "-4", testSkills.ToString());
            Assert.AreEqual(1, testSkills.NumberOfSkills);
        }

        [TestMethod]
        public void AddSkill_Adds_Additional_Skills_As_Separate_Items()
        {
            testSkills = new Skills();
            testSkills.AddSkill(firstSkill);
            Assert.AreEqual(1, testSkills.NumberOfSkills);
            testSkills.AddSkill(secondSkill);
            Assert.AreEqual(firstSkill + "-1, " + secondSkill + "-1", testSkills.ToString());
            Assert.AreEqual(2, testSkills.NumberOfSkills);
            testSkills.AddSkill(firstSkill);
            Assert.AreEqual(firstSkill + "-2, " + secondSkill + "-1", testSkills.ToString());
            Assert.AreEqual(2, testSkills.NumberOfSkills);
        }

        [TestMethod]
        public void AddZeroSkill_Adds_Additional_Skills_As_Separate_Items()
        {
            testSkills = new Skills();
            testSkills.AddZeroSkill(firstSkill);
            Assert.AreEqual(1, testSkills.NumberOfSkills);
            testSkills.AddZeroSkill(secondSkill);
            Assert.AreEqual(firstSkill + "-0, " + secondSkill + "-0", testSkills.ToString());
            Assert.AreEqual(2, testSkills.NumberOfSkills);
            testSkills.AddSkill(firstSkill);
            Assert.AreEqual(firstSkill + "-1, " + secondSkill + "-0", testSkills.ToString());
            Assert.AreEqual(2, testSkills.NumberOfSkills);
        }

        [TestMethod]
        public void GetArrayFromDictionary_Returns_Array_Of_Formatted_Strings()
        {
            testSkills = new Skills();
            testSkills.AddZeroSkill(firstSkill);
            Assert.AreEqual(1, testSkills.SkillsArray.Length);
            Assert.AreEqual(firstSkill + "-0", testSkills.SkillsArray[0]);
            testSkills.AddZeroSkill(secondSkill);
            Assert.AreEqual(2, testSkills.SkillsArray.Length);
            Assert.AreEqual(firstSkill + "-0", testSkills.SkillsArray[0]);
            Assert.AreEqual(secondSkill + "-0", testSkills.SkillsArray[1]) ;
            testSkills.AddSkill(firstSkill);
            Assert.AreEqual(firstSkill + "-1", testSkills.SkillsArray[0]);
            Assert.AreEqual(secondSkill + "-0", testSkills.SkillsArray[1]);
        }

    }
}

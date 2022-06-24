using ClassicTravellerCharacterGenerator.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TravellerCharacterGenerator.Dice;

namespace TravellerCharacterGeneratorTests.Products
{

    [TestClass]
    public class CareerTest
    {
        private Career testCareer;
        private readonly string testCareerName = "careerName";
        private readonly string testRankName = "rankName";

        [TestMethod]
        public void New_Career_Should_Start_At_18_Age_And_0_Terms()
        {
            // Basic constructor
            testCareer = new Career(testCareerName);
            Assert.AreEqual(18, testCareer.AgeYears);
            Assert.AreEqual(0, testCareer.AgeMonths);
            Assert.AreEqual(0, testCareer.Terms);
            Assert.AreEqual(testCareerName, testCareer.CareerName);
        }

        [TestMethod]
        public void AddTerm_Should_Increase_Age_By_Two_And_Increase_Terms_By_One()
        {
            testCareer = new Career(testCareerName);
            testCareer.AddTerm();
            Assert.AreEqual(22, testCareer.AgeYears);
            Assert.AreEqual(0, testCareer.AgeMonths);
            Assert.AreEqual(1, testCareer.Terms);
            Assert.AreEqual(testCareerName, testCareer.CareerName);
            testCareer.AddTerm();
            Assert.AreEqual(26, testCareer.AgeYears);
            Assert.AreEqual(0, testCareer.AgeMonths);
            Assert.AreEqual(2, testCareer.Terms);
            Assert.AreEqual(testCareerName, testCareer.CareerName);
            testCareer.AddTerm();
            Assert.AreEqual(30, testCareer.AgeYears);
            Assert.AreEqual(0, testCareer.AgeMonths);
            Assert.AreEqual(3, testCareer.Terms);
            Assert.AreEqual(testCareerName, testCareer.CareerName);
            testCareer.AddTerm();
            Assert.AreEqual(34, testCareer.AgeYears);
            Assert.AreEqual(0, testCareer.AgeMonths);
            Assert.AreEqual(4, testCareer.Terms);
            Assert.AreEqual(testCareerName, testCareer.CareerName);
        }

        [TestMethod]
        public void AddHalfTerm_Should_Increase_Age_By_Two_And_Not_Increase_Terms()
        {
            testCareer = new Career(testCareerName);
            testCareer.AddHalfTerm();
            Assert.AreEqual(20, testCareer.AgeYears);
            Assert.AreEqual(0, testCareer.AgeMonths);
            Assert.AreEqual(0, testCareer.Terms);
            Assert.AreEqual(testCareerName, testCareer.CareerName);
        }

        [TestMethod]
        public void Adding_12_Months_Will_Add_A_Year_And_Reset_Months_To_0()
        {
            testCareer = new Career(testCareerName);
            Assert.AreEqual(18, testCareer.AgeYears);
            Assert.AreEqual(0, testCareer.AgeMonths);
            Assert.AreEqual(0, testCareer.Terms);
            Assert.AreEqual(testCareerName, testCareer.CareerName);

            for (int i = 1; i <= 11; i++)
            {
                testCareer.AddMonth();
                Assert.AreEqual(18, testCareer.AgeYears);
                Assert.AreEqual(i, testCareer.AgeMonths);
                Assert.AreEqual(0, testCareer.Terms);
                Assert.AreEqual(testCareerName, testCareer.CareerName);
            }
            testCareer.AddMonth();
            Assert.AreEqual(19, testCareer.AgeYears);
            Assert.AreEqual(0, testCareer.AgeMonths);
            Assert.AreEqual(0, testCareer.Terms);
            Assert.AreEqual(testCareerName, testCareer.CareerName);
        }

        [TestMethod]
        public void Should_Throw_Exceptions_When_Accessing_Rank_From_New_Career_Object()
        {
            testCareer = new Career(testCareerName);
            Assert.IsFalse(testCareer.Commissioned);
            try
            {
                _ = testCareer.GetRankLevel();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                Assert.AreEqual(18, testCareer.AgeYears);
                Assert.AreEqual(0, testCareer.AgeMonths);
                Assert.AreEqual(0, testCareer.Terms);
                Assert.AreEqual(testCareerName, testCareer.CareerName);
                Assert.IsFalse(testCareer.Commissioned);
            }
            try
            {
                _ = testCareer.GetRankName();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                Assert.AreEqual(18, testCareer.AgeYears);
                Assert.AreEqual(0, testCareer.AgeMonths);
                Assert.AreEqual(0, testCareer.Terms);
                Assert.AreEqual(testCareerName, testCareer.CareerName);
                Assert.IsFalse(testCareer.Commissioned);
            }
        }

        [TestMethod]
        public void Should_Not_Throw_Error_If_Commissioned()
        {
            testCareer = new Career(testCareerName);
            Assert.IsFalse(testCareer.Commissioned);
            testCareer.Promote(testRankName);
            Assert.AreEqual(testRankName, testCareer.GetRankName());
            Assert.AreEqual(1, testCareer.GetRankLevel());
            Assert.IsTrue(testCareer.Commissioned);

            testCareer.Promote(testRankName);
            Assert.AreEqual(testRankName, testCareer.GetRankName());
            Assert.AreEqual(2, testCareer.GetRankLevel());
            Assert.IsTrue(testCareer.Commissioned);

            testCareer.Promote(testRankName);
            Assert.AreEqual(testRankName, testCareer.GetRankName());
            Assert.AreEqual(3, testCareer.GetRankLevel());
            Assert.IsTrue(testCareer.Commissioned);

            testCareer.Promote(testRankName);
            Assert.AreEqual(testRankName, testCareer.GetRankName());
            Assert.AreEqual(4, testCareer.GetRankLevel());
            Assert.IsTrue(testCareer.Commissioned);

            testCareer.Promote(testRankName);
            Assert.AreEqual(testRankName, testCareer.GetRankName());
            Assert.AreEqual(5, testCareer.GetRankLevel());
            Assert.IsTrue(testCareer.Commissioned);

            testCareer.Promote(testRankName);
            Assert.AreEqual(testRankName, testCareer.GetRankName());
            Assert.AreEqual(6, testCareer.GetRankLevel());
            Assert.IsTrue(testCareer.Commissioned);

            try
            {
                testCareer.Promote(testRankName);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                Assert.AreEqual(testRankName, testCareer.GetRankName());
                Assert.AreEqual(6, testCareer.GetRankLevel());
                Assert.IsTrue(testCareer.Commissioned);
            }
        }
    }
}

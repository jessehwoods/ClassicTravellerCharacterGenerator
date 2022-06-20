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

        [TestMethod]
        public void New_Career_Should_Start_At_18_Age_And_0_Terms()
        {
            // Basic constructor
            testCareer = new Career();
            Assert.AreEqual(18, testCareer.GetAge());
            Assert.AreEqual(0, testCareer.GetTerms()););
        }

        [TestMethod]
        public void AddTerm_Should_Increase_Age_By_Two_And_Increase_Terms_By_One()
        {
            testCareer = new Career();
            testCareer.AddTerm();
            Assert.AreEqual(22, testCareer.GetAge());
            Assert.AreEqual(1, testCareer.GetTerms());
            testCareer.AddTerm();
            Assert.AreEqual(26, testCareer.GetAge());
            Assert.AreEqual(2, testCareer.GetTerms());
            testCareer.AddTerm();
            Assert.AreEqual(30, testCareer.GetAge());
            Assert.AreEqual(3, testCareer.GetTerms());
            testCareer.AddTerm();
            Assert.AreEqual(34, testCareer.GetAge());
            Assert.AreEqual(4, testCareer.GetTerms());
        }

        [TestMethod]
        public void AddHalfTerm_Should_Increase_Age_By_Two_And_Not_Increase_Terms()
        {
            testCareer = new Career();
            testCareer.AddHalfTerm();
            Assert.AreEqual(20, testCareer.GetAge());
            Assert.AreEqual(0, testCareer.GetTerms());
        }
    }
}

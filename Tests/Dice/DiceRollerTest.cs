using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TravellerCharacterGenerator.Dice;

namespace Tests.Dice
{
    [TestClass, TestCategory("Unit")]
    public class DiceRollerTest
    {
        private TravellerCharacterGenerator.Dice.DiceRoller testDiceRoller;

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Constructor_For_Number_Less_Than_One ()
        {
            try
            {
                testDiceRoller = new DiceRoller(0);
                Assert.Fail();
            } catch(System.ArgumentException)
            {
                Assert.IsNull(testDiceRoller);
            }
        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_By_Constructor_For_Number_Greater_Than_Six()
        {
            try
            {
                testDiceRoller = new DiceRoller(7);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsNull(testDiceRoller);
            }
        }

        [TestMethod]
        public void ArgumentException_Should_Be_Thrown_RollDice_For_Number_Less_Than_One()
        {
            testDiceRoller = new DiceRoller(1);
            try
            {
                testDiceRoller.RollDice(0);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.AreEqual(1, testDiceRoller.RollDice(1));
            }
        }

        [TestMethod]
        public void ArgumentException_Should_Not_Be_Thrown_By_Constructor_For_Numbers_One_To_Six()
        {
            testDiceRoller = new DiceRoller(1);
            testDiceRoller = new DiceRoller(2);
            testDiceRoller = new DiceRoller(3);
            testDiceRoller = new DiceRoller(4);
            testDiceRoller = new DiceRoller(5);
            testDiceRoller = new DiceRoller(6);
        }

        [TestMethod]
        public void RollDice_Should_Return_Number_Of_Dice_Requested_Times_Die_Output_Value_For_One_To_Six()
        {
            // I am going up to 5, because that is, I think, the highest number of dice that are rolled at once in the basic rules
            int numberToTest = 1;
            testDiceRoller = new DiceRoller(numberToTest);
            for (int i = 1; i <= 5; i++)
            {
                Assert.AreEqual(numberToTest * i, testDiceRoller.RollDice(i));
            }
            numberToTest = 2;
            testDiceRoller = new DiceRoller(numberToTest);
            for (int i = 1; i <= 5; i++)
            {
                Assert.AreEqual(numberToTest * i, testDiceRoller.RollDice(i));
            }
            numberToTest = 3;
            testDiceRoller = new DiceRoller(numberToTest);
            for (int i = 1; i <= 5; i++)
            {
                Assert.AreEqual(numberToTest * i, testDiceRoller.RollDice(i));
            }
            numberToTest = 4;
            testDiceRoller = new DiceRoller(numberToTest);
            for (int i = 1; i <= 5; i++)
            {
                Assert.AreEqual(numberToTest * i, testDiceRoller.RollDice(i));
            }
            numberToTest = 5;
            testDiceRoller = new DiceRoller(numberToTest);
            for (int i = 1; i <= 5; i++)
            {
                Assert.AreEqual(numberToTest * i, testDiceRoller.RollDice(i));
            }
            numberToTest = 6;
            testDiceRoller = new DiceRoller(numberToTest);
            for (int i = 1; i <= 5; i++)
            {
                Assert.AreEqual(numberToTest * i, testDiceRoller.RollDice(i));
            }
        }
    }
}

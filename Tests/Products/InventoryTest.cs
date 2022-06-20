using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TravellerCharacterGenerator.Products;

namespace TravellerCharacterGeneratorTests.Products
{
    [TestClass]
    public class InventoryTest
    {
        private Inventory testInventory;
        private int testCashAmount = 100;
        private string testItem1 = "testItem1";
        private string testItem2 = "testItem 2";

        [TestMethod]
        public void New_Inventory_Is_Empty()
        {
            testInventory = new Inventory();
            Assert.AreEqual(0, testInventory.NumberOfItems);
            Assert.AreEqual(0, testInventory.Cash);
        }

        [TestMethod]
        public void Adding_Cash_Adds_Money_And_Not_Item()
        {
            testInventory = new Inventory();
            testInventory.AddCash(testCashAmount);
            Assert.AreEqual(0, testInventory.NumberOfItems);
            Assert.AreEqual(testCashAmount, testInventory.Cash);
            testInventory.AddCash(testCashAmount);
            Assert.AreEqual(0, testInventory.NumberOfItems);
            Assert.AreEqual(2 * testCashAmount, testInventory.Cash);
        }

        [TestMethod]
        public void Adding_Item_Adds_To_Inventory_Not_Cash()
        {
            testInventory = new Inventory();
            testInventory.AddItem(testItem1);
            Assert.AreEqual(1, testInventory.NumberOfItems);
            Assert.AreEqual(0, testInventory.Cash);
            Assert.AreEqual(testItem1, testInventory.ItemArray[0]);
        }

        [TestMethod]
        public void Adding_Identical_Item_Adds_Second_Instance()
        {
            testInventory = new Inventory();
            testInventory.AddItem(testItem1);
            testInventory.AddItem(testItem1);
            Assert.AreEqual(2, testInventory.NumberOfItems);
            Assert.AreEqual(0, testInventory.Cash);
            Assert.AreEqual(testItem1, testInventory.ItemArray[0]);
            Assert.AreEqual(testItem1, testInventory.ItemArray[1]);
        }

        [TestMethod]
        public void Adding_Different_Items_Adds_Second_Item()
        {
            testInventory = new Inventory();
            testInventory.AddItem(testItem1);
            testInventory.AddItem(testItem2);
            Assert.AreEqual(2, testInventory.NumberOfItems);
            Assert.AreEqual(0, testInventory.Cash);
            Assert.AreEqual(testItem1, testInventory.ItemArray[0]);
            Assert.AreEqual(testItem2, testInventory.ItemArray[1]);
        }
    }
}

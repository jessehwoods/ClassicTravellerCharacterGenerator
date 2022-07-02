

using System;
using System.Collections.Generic;

namespace TravellerCharacterGenerator.Products
{
    internal class Inventory : IInventory
    {
        private List<String> itemList;

        public int Cash { get; private set; }
        public int NumberOfItems { get { return itemList.Count; } }
        public string[] ItemArray { get { return itemList.ToArray(); } }

        public Inventory()
        {
            itemList = new List<String>();
            Cash = 0;

        }

        internal void AddCash(int cashAmount)
        {
            if (cashAmount < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot add a negative amount of cash.");
            }
            Cash += cashAmount;
        }

        internal void AddItem(string itemToAdd)
        {
            if (itemToAdd == null || itemToAdd.Length == 0)
            {
                throw new ArgumentException("Cannot add a null or empty item to inventory.");
            }
            itemList.Add(itemToAdd);
        }
    }
}

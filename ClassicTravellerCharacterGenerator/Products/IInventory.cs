namespace TravellerCharacterGenerator.Products
{
    internal interface IInventory
    {
        int Cash { get; }
        string[] ItemArray { get; }
        int NumberOfItems { get; }

        void AddCash(int amount);
        void AddItem(string itemToAdd);
    }
}
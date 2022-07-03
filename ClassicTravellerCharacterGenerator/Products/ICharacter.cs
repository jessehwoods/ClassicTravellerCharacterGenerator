namespace TravellerCharacterGenerator.Products
{
    internal interface ICharacter
    {
        int AgeMonths { get; }
        int AgeYears { get; }
        string CareerName { get; }
        int Cash { get; }
        bool Commissioned { get; }
        int Dexterity { get; }
        int Education { get; }
        int Endurance { get; }
        int Intelligence { get; }
        string[] Inventory { get; }
        string Name { get; }
        string[] Skills { get; }
        int SocialStanding { get; }
        int Strength { get; }
        int Terms { get; }

        string GetRankName();
        int GetRankLevel();
    }
}
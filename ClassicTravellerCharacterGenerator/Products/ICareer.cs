namespace ClassicTravellerCharacterGenerator.Products
{
    internal interface ICareer
    {
        int AgeMonths { get; }
        int AgeYears { get; }
        string CareerName { get; }
        bool Commissioned { get; }
        int Terms { get; }

        string GetRankName();
        int GetRankLevel();
    }
}
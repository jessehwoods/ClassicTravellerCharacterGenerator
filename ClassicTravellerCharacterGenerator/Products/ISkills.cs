namespace TravellerCharacterGenerator.Products
{
    internal interface ISkills
    {
        int NumberOfSkills { get; }
        string[] SkillsArray { get; }

        void AddSkill( string skillName );
    }
}
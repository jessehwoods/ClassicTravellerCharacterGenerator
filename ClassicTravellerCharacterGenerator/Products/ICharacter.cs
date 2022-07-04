namespace TravellerCharacterGenerator.Products
{
    /// <summary>
    /// This is an interface for a character object that holds and returns information about the character.
    /// </summary>
    internal interface ICharacter
    {

        /// <summary>
        /// Name of the character.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Age of the character in years.
        /// </summary>
        int AgeYears { get; }
        /// <summary>
        /// Age of the character in months, with years removed.
        /// </summary>
        int AgeMonths { get; }
        /// <summary>
        /// Terms the character spent in their career.
        /// </summary>
        int Terms { get; }
        /// <summary>
        /// Name of the character's career.
        /// </summary>
        string CareerName { get; }
        /// <summary>
        /// Returns if the character has been commissioned.
        /// </summary>
        bool Commissioned { get; }
        /// <summary>
        /// Strength attribue, rated 1-15.
        /// </summary>
        int Strength { get; }
        /// <summary>
        /// Dexterity attribue, rated 1-15.
        /// </summary>
        int Dexterity { get; }
        /// <summary>
        /// Endurance attribue, rated 1-15.
        /// </summary>
        int Endurance { get; }
        /// <summary>
        /// Intelligence attribue, rated 1-15.
        /// </summary>
        int Intelligence { get; }
        /// <summary>
        /// Education attribue, rated 1-15.
        /// </summary>
        int Education { get; }
        /// <summary>
        /// Social Standing attribue, rated 1-15.
        /// </summary>
        int SocialStanding { get; }
        /// <summary>
        /// Cash possessed by character.
        /// </summary>
        int Cash { get; }
        /// <summary>
        /// Character's inventory, other than cash, as an array.
        /// </summary>
        string[] Inventory { get; }
        /// <summary>
        /// Character's skills as an array of strings, formatted as "{skill name}-{skill level}"
        /// </summary>
        string[] Skills { get; }
        /// <summary>
        /// Returns rank as a string, if the character has been commissioned. 
        /// </summary>
        /// <remarks>
        /// The character only has a rank name, 
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown if trying to get a rank and the character has not been commissioned.
        /// </exception>
        string GetRankName();
        /// <summary>
        /// Returns rank level as an integer from 1 to 6, if the character has been commissioned. 
        /// </summary>
        /// <remarks>
        /// There is no 0 rank. A character who has not been commissioned, tracked by the Commissioned property, just doesn't have a rank on my reading of the rules.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown if trying to get a rank and the character has not been commissioned.
        /// </exception>
        int GetRankLevel();
    }
}
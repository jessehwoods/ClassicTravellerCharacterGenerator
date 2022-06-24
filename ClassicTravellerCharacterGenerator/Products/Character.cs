using ClassicTravellerCharacterGenerator.Products;
using System;

namespace TravellerCharacterGenerator.Products
{

    /// <summary>
    /// This is a container class to represent the overall character. 
    /// </summary>
    /// <remarks>
    ///  This is used to hold the character information at the end of character creation. It is currently intended only to be used as an accessor.
    internal class Character
    {
        /// <summary>
        /// Name of the character.
        /// </summary>
        public string Name { get { return name; } }
        /// <summary>
        /// Age of the character in years.
        /// </summary>
        public int AgeYears { get { return career.AgeYears; } }
        /// <summary>
        /// Age of the character in months, with years removed.
        /// </summary>
        public int AgeMonths { get { return career.AgeMonths; } }
        /// <summary>
        /// Terms the character spent in their career.
        /// </summary>
        public int Terms { get { return career.Terms; } }
        /// <summary>
        /// Name of the character's career.
        /// </summary>
        public string CareerName { get { return career.CareerName; } }
        /// <summary>
        /// Returns if the character has been commissioned.
        /// </summary>
        public bool Commissioned { get { return career.Commissioned; } }
        /// <summary>
        /// Strength attribue, rated 1-15.
        /// </summary>
        public int Strength { get { return attributes.Strength; } }
        /// <summary>
        /// Dexterity attribue, rated 1-15.
        /// </summary>
        public int Dexterity { get { return attributes.Dexterity; } }
        /// <summary>
        /// Endurance attribue, rated 1-15.
        /// </summary>
        public int Endurance { get { return attributes.Endurance; } }
        /// <summary>
        /// Intelligence attribue, rated 1-15.
        /// </summary>
        public int Intelligence { get { return attributes.Intelligence; } }
        /// <summary>
        /// Education attribue, rated 1-15.
        /// </summary>
        public int Education { get { return attributes.Education; } }
        /// <summary>
        /// Social Standing attribue, rated 1-15.
        /// </summary>
        public int SocialStanding { get { return attributes.SocialStanding; } }
        /// <summary>
        /// Cash possessed by character.
        /// </summary>
        public int Cash { get { return inventory.Cash; } }
        /// <summary>
        /// Character's inventory, other than cash, as an array.
        /// </summary>
        public string[] Inventory { get { return inventory.ItemArray; } }
        /// <summary>
        /// Character's skills as an array of strings, formatted as "{skill name}-{skill level}"
        /// </summary>
        public string[] Skills { get { return skills.SkillsArray; } }

        private string name;
        private Characteristics attributes;
        private Career career;
        private Skills skills;
        private Inventory inventory;

        /// <summary>
        /// Constructs a character with the input values. 
        /// </summary>
        /// <param name="name">The name of the character. First and last are not distinguished.</param>
        /// <param name="attributes">The name of the character. First and last are not distinguished.</param>
        /// <param name="career">The name of the character. First and last are not distinguished.</param>
        /// <param name="skills">The name of the character. First and last are not distinguished.</param>
        /// <param name="inventory">The name of the character. First and last are not distinguished.</param>
        /// <exception cref="name"> ArgumentNullException.</exception>
        /// <exception cref="attributes"> ArgumentNullException.</exception>
        /// <exception cref="career"> ArgumentNullException.</exception>
        /// <exception cref="skills"> ArgumentNullException.</exception>
        /// <exception cref="inventory"> ArgumentNullException.</exception>
        public Character(string name, 
            Characteristics attributes,
            Career career,
            Skills skills, 
            Inventory inventory)
        {
            if (name == null || name.Length == 0)
            {
                throw new ArgumentNullException("name");
            }
            if (attributes == null)
            {
                throw new ArgumentNullException("attributes");
            }
            if (career == null)
            {
                throw new ArgumentNullException("career");
            }
            if (skills == null)
            {
                throw new ArgumentNullException("skills");
            }
            if (inventory == null)
            {
                throw new ArgumentNullException("inventory");
            }
            this.name = name;
            this.attributes = attributes;
            this.career = career;
            this.skills = skills;
            this.inventory = inventory;
        }

        /// <summary>
        /// Returns rank as a string, if the character has been commissioned. 
        /// </summary>
        /// <remarks>
        /// The character only has a rank name, 
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown if trying to get a rank and the character has not been commissioned.
        /// </exception>
        internal string GetRankName()
        {
            return career.GetRankName();
        }

        /// <summary>
        /// Returns rank level as an integer from 1 to 6, if the character has been commissioned. 
        /// </summary>
        /// <remarks>
        /// There is no 0 rank. A character who has not been commissioned, tracked by the Commissioned property, just doesn't have a rank on my reading of the rules.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown if trying to get a rank and the character has not been commissioned.
        /// </exception>
        internal int GetRankLevel()
        {
            return career.GetRankLevel();
        }

    }
}

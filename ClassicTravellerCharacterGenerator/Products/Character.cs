using ClassicTravellerCharacterGenerator.Products;
using System;

namespace TravellerCharacterGenerator.Products
{

    /// <summary>
    /// This is a container class to represent the overall character. 
    /// </summary>
    /// <remarks>
    ///  This is used to hold the character information at the end of character creation. It is currently intended only to be used as an accessor.
    internal class Character : ICharacter
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
        public int Strength { get { return characteristics.Strength; } }
        /// <summary>
        /// Dexterity attribue, rated 1-15.
        /// </summary>
        public int Dexterity { get { return characteristics.Dexterity; } }
        /// <summary>
        /// Endurance attribue, rated 1-15.
        /// </summary>
        public int Endurance { get { return characteristics.Endurance; } }
        /// <summary>
        /// Intelligence attribue, rated 1-15.
        /// </summary>
        public int Intelligence { get { return characteristics.Intelligence; } }
        /// <summary>
        /// Education attribue, rated 1-15.
        /// </summary>
        public int Education { get { return characteristics.Education; } }
        /// <summary>
        /// Social Standing attribue, rated 1-15.
        /// </summary>
        public int SocialStanding { get { return characteristics.SocialStanding; } }
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
        private ICharacteristics characteristics;
        private ICareer career;
        private ISkills skills;
        private IInventory inventory;

        /// <summary>
        /// Constructs a character with the input values. 
        /// </summary>
        /// <param name="name">The name of the character. First and last are not distinguished.</param>
        /// <param name="attributes">The name of the character. First and last are not distinguished.</param>
        /// <param name="career">The name of the character. First and last are not distinguished.</param>
        /// <param name="skills">The name of the character. First and last are not distinguished.</param>
        /// <param name="inventory">The name of the character. First and last are not distinguished.</param>
        /// <exception cref="ArgumentNullException"> If any argument is null.</exception>
        public Character(string name,
            ICharacteristics characteristics,
            ICareer career,
            ISkills skills,
            IInventory inventory)
        {
            if (name == null || name.Length == 0)
            {
                throw new ArgumentNullException("name");
            }
            if (characteristics == null)
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
            this.characteristics = characteristics;
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
        public string GetRankName()
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
        public int GetRankLevel()
        {
            return career.GetRankLevel();
        }

    }
}

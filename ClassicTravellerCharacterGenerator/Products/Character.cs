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

        public string Name { get { return name; } }

        public int AgeYears { get { return career.AgeYears; } }

        public int AgeMonths { get { return career.AgeMonths; } }

        public int Terms { get { return career.Terms; } }

        public string CareerName { get { return career.CareerName; } }

        public bool Commissioned { get { return career.Commissioned; } }

        public int Strength { get { return characteristics.Strength; } }

        public int Dexterity { get { return characteristics.Dexterity; } }

        public int Endurance { get { return characteristics.Endurance; } }

        public int Intelligence { get { return characteristics.Intelligence; } }

        public int Education { get { return characteristics.Education; } }

        public int SocialStanding { get { return characteristics.SocialStanding; } }

        public int Cash { get { return inventory.Cash; } }

        public string[] Inventory { get { return inventory.ItemArray; } }

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

        public string GetRankName()
        {
            return career.GetRankName();
        }

        public int GetRankLevel()
        {
            return career.GetRankLevel();
        }

    }
}

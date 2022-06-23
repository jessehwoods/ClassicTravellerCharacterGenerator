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
        private string name;
        private Attributes attributes;
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
            Attributes attributes,
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

        internal string GetName()
        {
            return name;
        }

        internal int GetStrength()
        {
            return attributes.Strength;
        }

        internal int GetDexterity()
        {
            return attributes.Dexterity;
        }

        internal int GetEndurance()
        {
            return attributes.Endurance;
        }

        internal int GetIntelligence()
        {
            return attributes.Intelligence;
        }

        internal int GetEducation()
        {
            return attributes.Education;
        }

        internal int GetSocialStanding()
        {
            return attributes.SocialStanding;
        }

        internal string[] GetInventory()
        {
            return inventory.ItemArray;
        }

        internal string[] GetSkills()
        {
            throw new NotImplementedException();
        }

        internal int GetTerms()
        {
            throw new NotImplementedException();
        }

        internal string GetRank()
        {
            throw new NotImplementedException();
        }

        internal string GetCareer()
        {
            throw new NotImplementedException();
        }

        internal int GetCash()
        {
            throw new NotImplementedException();
        }
    }
}

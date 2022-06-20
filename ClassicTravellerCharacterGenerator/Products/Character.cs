using ClassicTravellerCharacterGenerator.Products;
using System;

namespace TravellerCharacterGenerator.Products
{

    internal class Character
    {
        private string name;
        private Attributes attributes;
        private Career career;
        private Skills skills;
        private Inventory inventory;

        public Character(string name, 
            int age, 
            Attributes attributes,
            Career career,
            Skills skills, 
            Inventory inventory)
        {
            this.name = name;
            this.attributes = attributes;
            this.career = career;
            this.skills = skills;
            this.inventory = inventory;
        }

        internal string GetName()
        {
            throw new NotImplementedException();
        }

        internal int GetStrength()
        {
            throw new NotImplementedException();
        }

        internal int GetDexterity()
        {
            throw new NotImplementedException();
        }

        internal int GetEndurance()
        {
            throw new NotImplementedException();
        }

        internal int GetIntelligence()
        {
            throw new NotImplementedException();
        }

        internal int GetEducation()
        {
            throw new NotImplementedException();
        }

        internal int GetSocialStanding()
        {
            throw new NotImplementedException();
        }

        internal Inventory GetInventory()
        {
            throw new NotImplementedException();
        }

        internal Skills GetSkills()
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

using System;

namespace TravellerCharacterGenerator.Products
{

    internal class Character
    {
        private string name;
        private int strength;
        private int dexterity;
        private int endurance;
        private int intelligence;
        private int education;
        private int socialStanding;
        private Skills skills;
        private Inventory inventory;

        public Character(string name, 
            int strength, 
            int dexterity, 
            int endurance, 
            int intelligence, 
            int education, 
            int socialStanding)
        {
            this(strength, dexterity, endurance, intelligence, endurance, intelligence, education, socialStanding, new Skills(), new Inventory());
        }

        public Character(string name, 
            int strength, 
            int dexterity, 
            int endurance, 
            int intelligence, 
            int education, 
            int socialStanding, 
            Skills skills, 
            Inventory inventory)
        {
            this.name = name;
            this.strength = strength;
            this.dexterity = dexterity;
            this.endurance = endurance;
            this.intelligence = intelligence;
            this.education = education;
            this.socialStanding = socialStanding;
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

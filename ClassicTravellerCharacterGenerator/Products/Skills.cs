

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravellerCharacterGenerator.Products
{

    internal class Skills : ISkills
    {
        private SortedDictionary<string, int> skillsDictionary;

        public int NumberOfSkills { get { return skillsDictionary.Count; } }
        public string[] SkillsArray { get { return GetArrayFromDictionary(); } }

        public Skills()
        {
            skillsDictionary = new SortedDictionary<string, int>();
        }

        internal void AddZeroSkill(string skill)
        {
            if (skillsDictionary.ContainsKey(skill))
            {
                throw new ArgumentException("An existing skill cannot be added at 0.");
            };
            skillsDictionary.Add(skill, 0);
        }

        public void AddSkill(string skill)
        {
            if (skillsDictionary.TryGetValue(skill, out int skillvalue))
            {
                skillsDictionary[skill] = skillvalue + 1;
            }
            else
            {
                skillsDictionary.Add(skill, 1);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, int> x in skillsDictionary)
            {
                sb.AppendFormat("{0}-{1}, ", x.Key, x.Value);
            }
            sb.Length = sb.Length - 2; // Cuts of the last ", "
            return sb.ToString();
        }

        private string[] GetArrayFromDictionary()
        {
            var toReturn = skillsDictionary.Select(s => string.Format("{0}-{1}", s.Key, s.Value));
            return toReturn.ToArray();
        }
    }
}

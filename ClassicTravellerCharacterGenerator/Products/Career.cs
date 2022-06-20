using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravellerCharacterGenerator.Dice;

namespace ClassicTravellerCharacterGenerator.Products
{
    internal class Career
    {
        private int age;
        private int terms;

        private readonly int startingAge = 18;
        private readonly int startingTerms = 0;

        public Career()
        {
            age = startingAge;
            terms = startingTerms;
        }

        internal int GetAge()
        {
            return age;
        }

        internal int GetTerms()
        {
            return terms;
        }

        internal void AddHalfTerm()
        {
            age += 2;
        }

        internal void AddTerm()
        {
            age += 4;
            terms++;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        internal int GetTerms()
        {
            throw new NotImplementedException();
        }

        internal void AddTerm()
        {
            throw new NotImplementedException();
        }

        internal void AddHalfTerm()
        {
            throw new NotImplementedException();
        }
    }
}

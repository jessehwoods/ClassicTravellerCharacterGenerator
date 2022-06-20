using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicTravellerCharacterGenerator.Products
{
    internal class Attributes
    {
        private int testInvalidAttributes;
        private int testValidAttributes1;
        private int testValidAttributes2;
        private int testValidAttributes3;
        private int testValidAttributes4;
        private int testValidAttributes5;

        public Attributes(int testInvalidAttributes, int testValidAttributes1, int testValidAttributes2, int testValidAttributes3, int testValidAttributes4, int testValidAttributes5)
        {
            this.testInvalidAttributes = testInvalidAttributes;
            this.testValidAttributes1 = testValidAttributes1;
            this.testValidAttributes2 = testValidAttributes2;
            this.testValidAttributes3 = testValidAttributes3;
            this.testValidAttributes4 = testValidAttributes4;
            this.testValidAttributes5 = testValidAttributes5;
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
    }
}

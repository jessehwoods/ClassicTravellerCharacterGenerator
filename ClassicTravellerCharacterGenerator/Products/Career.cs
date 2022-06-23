using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravellerCharacterGenerator.Dice;

namespace ClassicTravellerCharacterGenerator.Products
{
    /// <summary>
    /// Holds the information about the character's age and terms of service. 
    /// </summary>
    /// <remarks>
    /// Age and terms will be used in doing checks for attribute loss and death due to aging. They are also typically displayed when describing a charcter.
    /// </remarks>
    internal class Career
    {
        public int AgeYears { get; private set; }
        public int AgeMonths { get; private set; }
        public int Terms { get; private set; }
        public string CareerName { get; private set; }

        private readonly int startingAge = 18;
        private readonly int startingTerms = 0;

        /// <summary>
        /// Creates a fresh career object at age 18 and 0 terms served. 
        /// </summary>
        /// <remarks>
        /// In Classic Traveller, a character can only have one career. Later editions allowed multiple careers, but that will not be dealt with here.
        /// </remarks>
        /// <param name="careerName">The name of the career.</param>
        /// <exception cref="CareerName"> ArgumentNullException.</exception>
        public Career(string careerName)
        {
            if (careerName == null || careerName.Length == 0)
            {
                throw new ArgumentNullException("careerName");
            }
            AgeYears = startingAge;
            Terms = startingTerms;
            CareerName = careerName;
        }

        /// <summary>
        /// Adds half a term (two years of age) to the character. 
        /// </summary>
        /// <remarks>
        ///  This is used when the character is injured after having a result of "death" during character creation.
        /// </remarks>
        internal void AddHalfTerm()
        {
            AgeYears += 2;
        }

        /// <summary>
        /// Adds a term to the character. This is four years and a single term of service. 
        /// </summary>
        internal void AddTerm()
        {
            AgeYears += 4;
            Terms++;
        }

        /// <summary>
        /// Adds a month to the age of the charcter when called. 
        /// </summary>
        /// <remarks>
        ///  This is used during the aging rolls, as described on p. 12 of the 1st book. 
        /// </remarks>
        /// <returns>The sum of a number of values from 1-6, results of six-sided dice, equal to <paramref name="numberOfDice" /> </returns>
        /// <param name="numberOfDice">The number of six-sided dice to roll.</param>
        /// <exception cref="numberOfDice"> ArgumentException if less than 1.</exception>
        internal void AddMonth()
        {
            AgeMonths += 1;
            if (AgeMonths >= 12) // Check if we've reached a full year here
            {
                AgeYears += 1;
                AgeMonths = 0;
            }
        }

    }
}

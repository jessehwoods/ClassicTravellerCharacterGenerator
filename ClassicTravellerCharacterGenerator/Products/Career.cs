using System;

namespace ClassicTravellerCharacterGenerator.Products
{
    /// <summary>
    /// Holds the information about the character's age and terms of service. 
    /// </summary>
    /// <remarks>
    /// Age and terms will be used in doing checks for attribute loss and death due to aging. They are also typically displayed when describing a charcter.
    /// </remarks>
    internal class Career : ICareer
    {
        /// <summary>
        /// Years of age of the character. 
        /// </summary>
        public int AgeYears { get; private set; }

        /// <summary>
        /// Months of age for the character, minus years of age. 
        /// </summary>
        /// <remarks>
        /// So, if the character in 20 years and 2 months old, this returns 2 months.
        /// </remarks>
        public int AgeMonths { get; private set; }

        /// <summary>
        /// Terms served in the career. 
        /// </summary>
        public int Terms { get; private set; }

        /// <summary>
        /// Name of the character's career. 
        /// </summary>
        public string CareerName { get; private set; }

        /// <summary>
        /// Tracks if the character has been commissioned. 
        /// </summary>
        public bool Commissioned { get; private set; }

        private int rank;
        private string rankName;

        private readonly int startingAge = 18;
        private readonly int startingTerms = 0;
        private readonly int startingRank = 0;
        private readonly int maximumRank = 6;

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
            rank = startingRank;
            Commissioned = false;
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


        /// <summary>
        /// Increases the rank of a commissioned character, gives a character who has not been commissioned a commmision. 
        /// </summary>
        /// <remarks>
        /// In the rules, being commissioned and being promoted are separate, distinct steps. The checks and results are identical, though, so 
        /// they are being done with a single method.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown if maximum rank has been reaached already.
        /// </exception>
        /// <exception cref="ArgumentNullException"> 
        /// Thrown is the rankName is null or 0 length.
        /// </exception>
        internal void Promote(string rankName)
        {
            if (rank >= maximumRank)
            {
                throw new InvalidOperationException("Cannot promote any more from this rank.");
            }
            if (rankName == null || rankName.Length <= 0)
            {
                throw new ArgumentNullException("Rank name cannot be null.");
            }
            Commissioned = true;
            this.rankName = rankName;
            rank++;
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
            if (!Commissioned)
            {
                throw new InvalidOperationException("Can't have a rank until commissioned.");
            }
            return rankName;
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
            if (!Commissioned)
            {
                throw new InvalidOperationException("Can't have a rank level until commissioned.");
            }
            return rank;
        }

    }
}

using System;

namespace TravellerCharacterGenerator.Dice
{
    /// <summary>
    /// Can be called to return a number that could be rolled on a defined multiple of six-sided dice.
    /// </summary>
    /// <remarks>
    /// Will be used to provide random numbers for the CharacterRoller and BranchOfService objects in a standardized way.
    /// It will also allow for the creation of deterministic number outputs in testing.
    /// </remarks>
    public class DiceRoller
    {
        private const int lowerBound = 1;
        private const int upperBound = 6;
        private Random die;

        /// <summary>
        /// Default constructor that uses the Random class to generate outputs.
        /// </summary>
        public DiceRoller()
        {
            die = new Random();
        }

        /// <summary>
        /// Constructor that will return results as though the dice rolled were always returning the provided number.
        /// </summary>
        /// <param name="result">The number that will be returned by an dice.</param>
        /// <exception cref="result">ArgumentException if outside of acceptable range for outputs.</exception>
        public DiceRoller(int result)
        {
            if (result < lowerBound || result > upperBound)
            {
                throw new ArgumentException("Argument must be from " + lowerBound + " to " + upperBound + ".");
            }
            die = new DeterministicRandom(result);
        }

        /// <summary>
        /// Gives a result in a range defined by the sum of the specified number of six-sided dice. 
        /// </summary>
        /// <remarks>
        ///  The range of possible results should be from (1 * <paramref name="numberOfDice" />) to (6 * <paramref name="numberOfDice" />).
        ///  It is expected that there will be a bell curve to rolling more than 1 die, as you would get from rolling multiple six-sided dice in real life.
        /// </remarks>
        /// <returns>The sum of a number of values from 1-6, results of six-sided dice, equal to <paramref name="numberOfDice" /> </returns>
        /// <param name="numberOfDice">The number of six-sided dice to roll.</param>
        /// <exception cref="numberOfDice"> ArgumentException if less than 1.</exception>
        public int RollDice(int numberOfDice)
        {
            if (numberOfDice < 1)
            {
                throw new ArgumentException("Number of dice to throw must be at least 1.");
            }
            var toReturn = 0;
            for (int i = 0; i < numberOfDice; i++)
            {
                toReturn += die.Next(lowerBound, upperBound);
            }
            return toReturn;
        }

        /// <summary>
        /// Random object that returns a deterministic value for the overload Next(int, int) method for testing. 
        /// </summary>
        private class DeterministicRandom : Random
        {
            private int numberToReturn;

            /// <summary>
            /// Constructor specifying the number to be returned by each call to Next(int, int). 
            /// </summary>
            /// <param name="numberToReturn">The number that will be returned on a call to Next(int, int).</param>
            public DeterministicRandom(int numberToReturn)
            {
                this.numberToReturn = numberToReturn;
            }
            /// <summary>
            /// Returns the number set at construction. 
            /// </summary>
            /// <returns>The number set by the constructor.</returns>
            /// <param name="a">Not used.</param>
            /// <param name="b">Not used.</param>
            public override int Next(int a, int b)
            {
                return numberToReturn;
            }
        }
    }
}

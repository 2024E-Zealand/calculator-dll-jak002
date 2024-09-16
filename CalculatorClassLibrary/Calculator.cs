namespace CalculatorClassLibrary
{
    /// <summary>
    /// A calculator. It calculates things
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Takes two numbers, does some magic shit to it and returns one number that may or may not be the two numbers added together
        /// </summary>
        /// <param name="x">first number</param>
        /// <param name="y">second number</param>
        /// <returns></returns>
        public static int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Takes one number, takes another number, subtracts the other number from the first number, and returns the number that isn't the number that you subtracted from the first number but is instead the number that remains after subtracting one number from the other. i think
        /// </summary>
        /// <param name="x">Initial number</param>
        /// <param name="y">Number to subtract</param>
        /// <returns></returns>
        public static int Subtract(int x, int y) { return x - y; }

        /// <summary>
        /// Takes one number, then takes that number again, then takes that number again etc as often as specified in the other number.
        /// </summary>
        /// <param name="basenumber">Number to be mulitplied</param>
        /// <param name="factor">How many times the first number is multiplied</param>
        /// <returns></returns>
        public static int Multiply(int basenumber, int factor) { return basenumber * factor; }
    }
}

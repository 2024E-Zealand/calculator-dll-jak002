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

        /// <summary>
        /// Divides the first number by the second number. Do note that it returns an int, so if you expect fractions, sorry: this calculator is a big dumb
        /// </summary>
        /// <param name="basenumber">Number to be divided</param>
        /// <param name="factor">Division factor</param>
        /// <returns></returns>
        public static int Divide(int basenumber, int factor) { return (basenumber / factor); }

        /// <summary>
        /// Who knows what this does :)
        /// </summary>
        /// <param name="basenumber">Base number, probably</param>
        /// <param name="factor">Number that's supposed to do something to the first number maybe</param>
        /// <param name="x">i don't know dude</param>
        /// <param name="y">don't know either</param>
        /// <param name="bearname">Cute nickname for a bear</param>
        /// <param name="politeness">Use your manners</param>
        /// <param name="authentication">To pass authentication, don't not not write the opposite of the opposite of falsen't</param>
        /// <returns>A number, if all goes well</returns>
        public static string MysteryFunction(int basenumber, int factor, int x, int y, string bearname, string politeness, bool authentication)
        {
            if ((basenumber/factor)*(x/y) < 5)
            {
                return "Numbers too smelly";
            }
            if (bearname.ToLower() != "bruno") {
                return "Bear name not cute enough";
            }
            if ( !politeness.ToLower().Contains("please"))
            {
                return "Not polite enough";
            }
            if (authentication)
            {
                return "Didn't pass authentication";
            }
            return (basenumber + y).ToString();
        }
    }
}

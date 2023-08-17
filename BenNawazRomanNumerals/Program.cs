using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErinElandRomanNumerals
{
    public interface IRomanNumeralGenerator
    {
        String generate(int number);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the Roman Numeral generator! (Type 'exit' to close program)");

            //Loop and leave the program running until the user exits
            while (1 != 0)
            {
                try
                {
                    promptUserForInput();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void promptUserForInput()
        {
            Console.Write("\nEnter an positive integer number between 1 and 3999 to recieve it's roman numeral equivalent: ");

            string userInputString = Console.ReadLine();

            if (userInputString.Equals("exit")) 
            {
                Console.WriteLine("Goodbye, and thanks for all the fish!");
                Environment.Exit(0);
            }

            int numValue;
            bool parsed = Int32.TryParse(userInputString, out numValue);

            if (!parsed)
            {
                throw new ArgumentException("Int32.TryParse could not parse '{0}' to an int.\n", userInputString);
            }
            else
            {
                //User input was successfully parsed, try and generate a roman numeral from it.
                RomanNumeralGenerator romanNumeralGenerater = new RomanNumeralGenerator();


                String generatedRomanNumeral = romanNumeralGenerater.generate(numValue);
                Console.WriteLine("Your input number {0} has the corresponding roman numeral: '{1}'! Cool!", userInputString, generatedRomanNumeral);
            }
        }
    }

    //Define our class to generate Roman numerals, which implements the given interface
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
        public readonly Dictionary<int, string> RomanNumeralDictionary;

        public RomanNumeralGenerator()
        {
            //Dictionary/map to represent all unique roman numeral characters.
            RomanNumeralDictionary = new Dictionary<int, string>
                {
                    { 1000, "M" },
                    { 900, "CM" },
                    { 500, "D" },
                    { 400, "CD" },
                    { 100, "C" },
                    { 90, "XC" },
                    { 50, "L" },
                    { 40, "XL" },
                    { 10, "X" },
                    { 9, "IX" },
                    { 5, "V" },
                    { 4, "IV" },
                    { 1, "I" },
                };
        }

        /* APPROACH:
         * Loop continually, subtracting from our number and appending this value to our roman numeral string.
         */
        public String generate(int number)
        {
            //Run validation checks on the number - only accept between 1 and 3999
            if (number < 1 || number > 3999)
            {
                throw new ArgumentException("Invalid input, please enter a number between 1 and 3999");
            }

            //Instantiate a new .NET string builder
            var roman = new StringBuilder();

            // Iterate over the set of possible roman numeral characters
            // Must iterate in descending order of value, starting with M = 1000
            foreach (var romanNumeralChar in this.RomanNumeralDictionary)
            {
                //Append the current 'item'
                while (number >= romanNumeralChar.Key)
                {
                    //Append the roman numeral char to our roman numeral string
                    roman.Append(romanNumeralChar.Value);

                    //Now adjust the number for next iteration
                    number -= romanNumeralChar.Key;
                }
            }

            //Return the fully built roman numeral string.
            return roman.ToString();
        }
    }
}

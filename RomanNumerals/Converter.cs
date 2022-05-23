using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
     public class Converter
    { 
        private Dictionary<string, int> romanNumeralDict = new()
             {
                {"M", 1000 },
                {"D", 500 },
                {"C", 100 },
                {"L", 50 },
                {"X", 10 },
                {"V", 5 },
                {"I", 1 }
              };

        public string Convert(int input)
        {
            //I, V, X, L, C, D, M

            int quotient = 0;
            int modulus = 0;
            string output;

            if (input.Equals(0))
                return "Invalid. Enter number greater than 0.";


            foreach (var entry in romanNumeralDict)
            {
                if (input % entry.Value == 0)
                {
                    return entry.Key;
                }
                else if ((input % entry.Value <= 3) & (input != 1))
                {
                    quotient = input / entry.Value;
                    modulus = input % entry.Value;
                    output = entry.Key + String.Concat(Enumerable.Repeat("I", modulus));
                    return output;
                }
                else
                {

                }
                

                
            }

            return "something";

        }

    }
}

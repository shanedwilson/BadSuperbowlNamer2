using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperBowlNamer2
{
   public class RomanNumeralConvertor
    {
        public List<string> romanNumerals = new List<string>() { "M", "CM", "D", "CD", "C", "XC",
                                                                "L", "XL", "X", "IX", "V", "IV", "I"};
        public List<int> numbers = new List<int>() { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        public string ToRoman(int inputNumber)
        {
            var romanNumeral = "";

            while(inputNumber > 0)
            {
                var index = numbers.FindIndex(number => number <= inputNumber);
                inputNumber -= numbers[index];
                romanNumeral += romanNumerals[index];
            }
            return romanNumeral;
        }
    }
}

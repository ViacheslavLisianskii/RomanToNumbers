using System;
using System.Collections.Generic;

namespace RomanToNumbers
{
    public class Roman
    {
        public int ConvertToNumber(string romanText)
        {
            if (string.IsNullOrEmpty(romanText))
                throw new ArgumentException(romanText);
            
            var totalValue = 0;
            var prevValue = 0;
            foreach (var romanChart in romanText)
            {
                if (!RomanNumeralsMap.ContainsKey(romanChart))
                    throw new ArgumentException("Char not used in Roman Numerals", romanChart.ToString());

                var crtValue = RomanNumeralsMap[romanChart];
                totalValue += crtValue;
                if (prevValue != 0 && prevValue < crtValue)
                {
                    if (prevValue == 1 && (crtValue == 5 || crtValue == 10)
                        || prevValue == 10 && (crtValue == 50 || crtValue == 100)
                        || prevValue == 100 && (crtValue == 500 || crtValue == 1000))
                        totalValue -= 2 * prevValue;
                    else
                        throw new ArgumentException("Not allowed char used for subtraction", romanChart.ToString());
                }
                prevValue = crtValue;
            }
            return totalValue;
        }
        
        private static readonly Dictionary<char, int> RomanNumeralsMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
    }
}
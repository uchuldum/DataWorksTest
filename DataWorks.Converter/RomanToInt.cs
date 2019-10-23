using System;
using System.Collections.Generic;

namespace DataWorks.Converter
{
    public class RomanToInt
    {
        private Dictionary<char, int> RomanMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        private bool isRomanValid(string roman)
        {
            bool contains = false;
            for(int i = 0; i < roman.Length; i++)
            {
                if (RomanMap.ContainsKey(roman[i]))
                    contains = true;
                else contains = false;
            }
            return contains;
        }

        public int RomanToInteger(string roman)
        {
            if (roman.Length == 0) return 0;    
            bool validRoman = isRomanValid(roman);
            if (!validRoman) return -1;
            int number = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanMap[roman[i]] < RomanMap[roman[i + 1]])
                {
                   if (i + 2 < roman.Length && RomanMap[roman[i + 2]] >= RomanMap[roman[i + 1]])
                            return -2;
                    number -= RomanMap[roman[i]];
                }
                else
                {
                    number += RomanMap[roman[i]];
                }
            }
            if (number > 3000) return -3;
            return number;
        }
    }
}

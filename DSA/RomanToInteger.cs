using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DSA
{
    internal class RomanToInteger
    {
        Hashtable hashtable = new Hashtable();
        public void AddRomanData()
        {
            hashtable.Add("I", "1");
            hashtable.Add("V", "5");
            hashtable.Add("X", "10");
            hashtable.Add("L", "50");
            hashtable.Add("C", "100");
            hashtable.Add("D", "500");
            hashtable.Add("M", "1000");
        }

        public string getNumberFromRoman(char romanChar)
        {
            return (string)hashtable[romanChar.ToString()];
        }


        public int RomanToInt(string s)  
        {
            char[] data = s.ToCharArray();

            int result = 0, numericValue, nextValue;

            for (var i = 0; i < data.Length; i++)  
            {
                numericValue = Convert.ToInt32(getNumberFromRoman(data[i]));

                if (i != data.Length - 1) 
                {
                    nextValue = Convert.ToInt32(getNumberFromRoman(data[i + 1]));
                    if (numericValue < nextValue) 
                    {
                        numericValue = nextValue - numericValue;
                        i++;
                    }
                }
                result += numericValue;
            }
            return result;
        }


    }
}

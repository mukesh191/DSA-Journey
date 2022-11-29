using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** My DSA Journey ******");

            RomanToInteger romanToInteger = new();
            romanToInteger.AddRomanData();

            Console.WriteLine("Roman to Int : III  ==> " + romanToInteger.RomanToInt("III"));
            Console.WriteLine("Roman to Int : LVIII  ==> " + romanToInteger.RomanToInt("LVIII"));
            Console.WriteLine("Roman to Int : XIV  ==> " + romanToInteger.RomanToInt("XIV"));




            

        }
    } 
}
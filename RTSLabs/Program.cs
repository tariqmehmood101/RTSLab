using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using C# Code Style
            PrintIntegerAboveAndBelowNumber(0, new int[] { 1, 5, 2, 1, 10 });

            //Using C++ Code Style
            PrintIntegerAboveAndBelowNumbers(0, new int[] { 1, 5, 2, 1, 10 });

            // Using C# Code Style
            PrintRotatedString("MyString", 10);

            // Using C++ Code Style
            PrintRotatedStrings("MyString",10);
        }
        // Using C# Code Style
        public static void PrintIntegerAboveAndBelowNumber(int _FindNumer, int[] IntergerArray)
        {

            var Above = IntergerArray.AsQueryable().Where(p => p > _FindNumer).Count();

            var Below = IntergerArray.AsQueryable().Where(p => p < _FindNumer).Count();

            Console.WriteLine(String.Format("C# Code Style : Above: {0}, Below: {1}", Above, Below));

            //Console.ReadKey();

        }
        // Using C++ Code Style
        public static void PrintIntegerAboveAndBelowNumbers(int _FindNumer, int[] IntergerArray)
        {
            int Above=0, Below=0;

            for (int i = 0; i < IntergerArray.Length; i++)
            {
                if (IntergerArray[i] < _FindNumer)
                {
                    Below++;
                }
                else if(IntergerArray[i] > _FindNumer)
                {
                    Above++;
                }
            }
            Console.WriteLine(String.Format("C++ Code Style : Above: {0}, Below: {1}", Above, Below));

        }
        // Using C# Code Style
        public static void PrintRotatedString(string RotatableString, int number)
        {
            if (number > RotatableString.Length)
            {
                number = number - RotatableString.Length;
            }
            string OutputString = RotatableString.Substring(RotatableString.Length - number, number) + RotatableString.Substring(0, RotatableString.Length - number);
            Console.WriteLine(String.Format("C# Code Style  : {0}",OutputString));
           
        }
        // Using C++ Code Style
        public static void PrintRotatedStrings(string RotableString, int number)
        {
            char[] letters = RotableString.ToArray();
            char letter;
            for (int j = 0; j < number; j++)
            {
                for (int i = letters.Length - 2; i >= 0 ; i--)
                {
                    letter = letters[i];
                    letters[i] = letters[i + 1];
                    letters[i + 1] = letter;
                }
            }
            Console.Write("C++ Code Style : ");
            Console.WriteLine(letters);
            Console.ReadKey();
        }



    }
}

using System;
using System.IO;

namespace COMP1003
{
    class Program
    {
        public static string fileName;

        //
        // Main
        //
        static void Main(string[] args)
        {
            if (FileExists())
            {
                Console.WriteLine("[ERROR] Input file found.\n");
                FetchData();
                Runner();
            }
            else
            {
                Console.WriteLine("[ERROR] Input file not found.\n");
            }
        }
        
        //
        // Manual Input & Conversion
        //
        static void Runner()
        {
            string convertFrom;
            string convertTo;
            string convertAmount;
            Console.WriteLine("\n\nWelcome. Please enter the values you'd like to use. To exit, type 'exit' at any time.\n\n");
            while (true)
            {
                Console.WriteLine("Original From: ");
                convertFrom = Console.ReadLine();
                if (convertFrom == "exit") { break; }

                Console.WriteLine("Convert To: ");
                convertTo = Console.ReadLine();
                if (convertTo == "exit") { break; }

                Console.WriteLine("Original Measure Amount: ");
                convertAmount = Console.ReadLine();
                if (convertAmount == "exit") { break; }

                double result = RunConvert(convertFrom, convertTo, convertAmount);

                if (result != 0)
                {
                    Console.WriteLine("\n" + convertAmount + " " + convertFrom + "s is equal to " + result + " " + convertTo + "s.\n");
                }
                else
                {
                    Console.WriteLine("\nYour request contained invalid items. Please try again.\n");
                }
            }
        }

        //
        // Automatic Input & Conversion
        //
        static void FetchData()
        {
            Console.WriteLine("\n\nFetching conversion data...\n\n");
            Console.WriteLine("\n\nDone.\n\n");
        }

        //
        // Convert Values
        //
        static double RunConvert(string convertFrom, string convertTo, string convertAmount)
        {
            int convertValue;
            return 0;
        }

        //
        // Check if the file exists.
        //
        static bool FileExists()
        {
            string covertFile1 = "convert.txt";
            bool exists1 = File.Exists(covertFile1);

            string covertFile2 = "convert.txt";
            bool exists2 = File.Exists(covertFile2);

            if (exists1)
            {
                fileName = covertFile1;
                return true;
            }
            else if (exists1)
            {
                fileName = covertFile2;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

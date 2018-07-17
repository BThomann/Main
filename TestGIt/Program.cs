using System;
using System.Text.RegularExpressions;

namespace TestGIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("Hallo wie geht es dir.");

            string test = $"12.25 Watt";
            Console.WriteLine(ParseString(test) + 0.25);

            Console.ReadLine();
        }

        private static double ParseString(string name)
        {
            double value;
            name = name.Trim();
            name = name.Replace('.', ',');
            name = Regex.Replace(name, "[^0-9.,]", "");
            if( string.IsNullOrWhiteSpace(name) )
            {
                value = 0;
            }
            else
            {
                try
                {
                    value = Convert.ToDouble(name);
                }
                catch
                {
                    value = 0;
                }

                if( value < 0 )
                {
                    value = 0;
                }
            }

            return value;
        }
    }
}

using System;
using System.Xml.Schema;

namespace TryParseExample
{
    internal class Program
    {
        static void Main()
        {
            InsertNumber("Insert the number: ");

        }
        static int InsertNumber(string message)
        {
            int number;

            while (true)
            {
                Console.Write(mesaj);
                string insert = Console.ReadLine();

                if (int.TryParse(insert, out number))
                {
                    return number;
                }

                Console.WriteLine("Incorrect entry made.");

            }
        }

    }
}




    


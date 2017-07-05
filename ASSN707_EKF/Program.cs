using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSN707_EKF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            string word1, word2;
            int length1, length2, x;
            int numofdots;

            //User Input
            Console.WriteLine("Enter the first word");
            word1 = Console.ReadLine();

            Console.WriteLine("Enter the second word");
            word2 = Console.ReadLine();

            length1 = word1.Length;
            length2 = word2.Length;
            numofdots = 30 - (length1 + length2);


            Console.Write(word1);
            //Loop
            for (x = 1; x <= numofdots; x = x + 1)
            {
                Console.Write(".");
            }
            Console.Write(word2);
            
            

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SmallestNumber(string[] listArray)
            {
                try
                {
                    int smallestNumber = int.Parse(listArray[0]);

                    for (int i = 0; i < listArray.Length; i++)
                    {
                        int valueIf = int.Parse(listArray[i]);
                        if (valueIf < smallestNumber)
                        {
                            smallestNumber = valueIf;
                        }
                    }

                    return smallestNumber;
                } catch(FormatException ex)
                {
                    Console.WriteLine("Please, use just numbers ");
                    return 0;
                }
            }
            string[] lineList;
            char answer;

            do
            {
                Console.WriteLine("Starting the Program:");
                lineList = Console.ReadLine().Split(' ');
                Console.WriteLine("Smallest Number: " + SmallestNumber(lineList));
                Console.WriteLine("Try again ? y / n:");
                answer = char.Parse(Console.ReadLine());
            }
            while (answer == 'y');
            Console.WriteLine("Have a nice day!");
        }
    }
}

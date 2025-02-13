// Written by Elijah Waskul
// 2/6/2025
namespace Homework_2_The_Replicator_of_D_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] original = new int[5];

            for (int item = 0; item < 5; item++)
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                original[item] = number;
            }

            int[] copy = new int[5];

            for (int index = 0; index < 5; index++)
                copy[index] = original[index];

            for (int index = 0; index < 5; index++)
                Console.WriteLine($"{original[index]} and {copy[index]}");
        }
    }
}

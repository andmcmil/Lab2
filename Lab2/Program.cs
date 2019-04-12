using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = null;
            do
            {
                Console.WriteLine("Enter the Length of the room.");
                float length = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Width of the room.");
                float width = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Height of the room.");
                float height = float.Parse(Console.ReadLine());

                float area = length * width;
                float perimeter = 2 * (length + width);
                float volume = length * width * height;

                Console.WriteLine($"The area of the room is {area}.");
                Console.WriteLine($"The perimeter of the room is {perimeter}.");
                Console.WriteLine($"The volume of the room is {volume}.");

                Console.WriteLine("Would you like to measure another room? Type y for yes and n for no");
                repeat = Console.ReadLine();
            } while (repeat == "y");
            Console.WriteLine("Goodbye!");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
   /* class Initializing
    {
        static int[] data = new int[10];
        static void Main()
        {
            for (int i = 0; i < 1; i++)
            {
                for (int e = 10; e > 0; e--)
                {
                    data[i] = e;
                    Console.WriteLine(data[i]);
                }
            }
            Console.ReadLine();
        }
    }*/

    /*class ReverseNumbers
    {
        static int[] num = new int[5];
        static void Main()
        {
            Console.WriteLine("Enter your first number.");
            int.TryParse(Console.ReadLine(), out num[0]);
            Console.WriteLine("Enter your second number.");
            int.TryParse(Console.ReadLine(), out num[1]);
            Console.WriteLine("Enter your third number.");
            int.TryParse(Console.ReadLine(), out num[2]);
            Console.WriteLine("Enter your fourth number.");
            int.TryParse(Console.ReadLine(), out num[3]);
            Console.WriteLine("Enter your fifth number.");
            int.TryParse(Console.ReadLine(), out num[4]);

            Console.WriteLine("Your numbers are:");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadLine();
        }
    }*/

    /*class LargestSmallest
    {
        static int[] nums = new int[10];
        static int[] largeSmall = new int[2] { 0, 0 };
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Please enter number {i + 1}");
                int.TryParse(Console.ReadLine(), out nums[i]);
                if (i == 0)
                {
                    largeSmall[0] = nums[0];
                    largeSmall[1] = nums[0];
                }
                if (largeSmall[0] > nums[i])
                {
                    largeSmall[0] = nums[i];
                }
                if (largeSmall[1] < nums[i])
                {
                    largeSmall[1] = nums[i];
                }
            }
            Console.WriteLine($"Your smallest number is {largeSmall[0]}");
            Console.WriteLine($"Your largest number is {largeSmall[1]}");
            Console.ReadLine();
        }
    }*/

    /*class Initializing2ElectricBoogaloo
    {
        static void Main()
        {
            int[,] nums = new int[3, 3];
            int assignedNum = 1;
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    nums[x, y] = assignedNum;
                    assignedNum++;
                }
                Console.WriteLine($"{nums[x, 0]}, {nums[x, 1]}, {nums[x, 2]}");
            }
            Console.ReadLine();
        }
    }*/

    /*class Days
    {
        static void Main()
        {
            int[,] days = new int[29, 5];
            int assignedNum = 1;
            int rowSum;
            int columnSum = 0;
            int columnNum = 0;
            for (int x = 0; x < 29; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    days[x, y] = assignedNum;
                    assignedNum++;
                    columnNum++;
                }
                rowSum = days[x, 0] + days[x, 1] + days[x, 2] + days[x, 3] + days[x, 4];
                Console.WriteLine($"{days[x, 0]}, {days[x, 1]}, {days[x, 2]}, {days[x, 3]}, {days[x, 4]} : {rowSum}");
            }
            for (int i = 0; i < 5; i++)
            {
                for (int e = 0; e < 29; e++)
                {
                    columnSum += days[e, i];
                    columnNum++;
                }
                columnNum = 0;
                Console.WriteLine($"{columnSum}");
                columnSum = 0;
            }
            Console.ReadLine();
        }
    }*/

    /*class Health
    {
        static void Main()
        {
            int[] characterHealth = new int[5] { 100, 100, 100, 100, 100 };
            int characterChosen;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Your characters' health values are {characterHealth[0]}, {characterHealth[1]}, {characterHealth[2]}, {characterHealth[3]}, {characterHealth[4]}");
                int.TryParse(Console.ReadLine(), out characterChosen);
                if (characterChosen <= 4 && characterChosen >= 0)
                {
                    if (characterHealth[characterChosen] > 0)
                    {
                        characterHealth[characterChosen] -= 40;
                    }
                    if (characterHealth[characterChosen] < 0)
                    {
                        characterHealth[characterChosen] = 0;
                        
                    }
                    if (characterHealth[characterChosen] == 0)
                    {
                        i--;
                        Console.WriteLine("That character is dead and can not be attacked");
                    }
                    Console.WriteLine($"That character's health is now {characterHealth[characterChosen]}");
                }
                else
                {
                    Console.WriteLine("That is not a valid number.");
                    i--;
                }
            }
            Console.WriteLine($"Your charaters' final health values are {characterHealth[0]}, {characterHealth[1]}, {characterHealth[2]}, {characterHealth[3]}, {characterHealth[4]}");
            Console.ReadLine();
        }
    }*/

    class Food
    {
        static void Main()
        {
            int[,] food = new int[3, 7];
            string[] dragonNames = new string[3] { "That One", "The Other One", "The Third One" };
            int dragonEaten = 0;
            float foodEaten = 0;
            float foodTotal = 0;
            int[] largeSmall = new int[2] { int.MaxValue, int.MinValue };
            string[] dragonLargeSmall = new string[2];
            for (int dragon = 0; dragon < 3; dragon++)
            {
                Console.WriteLine("Which dragon ate today?");
                Console.WriteLine($"Their names are {dragonNames[0]}, {dragonNames[1]}, and {dragonNames[2]}");
                dragonNames[dragon] = Console.ReadLine();
                for (int day = 0; day < 7; day++)
                {
                    Console.WriteLine($"How much did it eat on day {day + 1}?");
                    int.TryParse(Console.ReadLine(), out dragonEaten);
                    food[dragon, day] = dragonEaten;
                    foodEaten += dragonEaten;
                    food[dragon, day] = dragonEaten;
                    if (largeSmall[0] > food[dragon, day])
                    {
                        largeSmall[0] = food[dragon, day];
                        dragonLargeSmall[0] = dragonNames[dragon];
                    }
                    if (largeSmall[1] < food[dragon, day])
                    {
                        largeSmall[1] = food[dragon, day];
                        dragonLargeSmall[1] = dragonNames[dragon];
                    }
                }
                Console.WriteLine($"{dragonNames[dragon]} has eaten {foodEaten}. The average food eaten is {foodEaten/7}.");
                foodTotal += foodEaten;
                foodEaten = 0;
            }
            Console.WriteLine($"{dragonNames[0]}, {dragonNames[1]}, and {dragonNames[2]} have eaten a total of {foodTotal}. Their average food eaten is {foodTotal / 7}");

            Console.WriteLine($"The smallest amount eaten is {largeSmall[0]} and {dragonLargeSmall[0]} ate that much.");
            Console.WriteLine($"The largest amount eaten is {largeSmall[1]} and {dragonLargeSmall[1]} ate that much.");
            Console.ReadLine();
        }
    }
}

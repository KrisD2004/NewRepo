namespace prepWorkcode;
using System;
//{
// internal class Program
// {
//    static void Main(string[] args)
//   {
//      Console.WriteLine("Hello, World!");
//  }
// }
//}
class Program
{
    static void Main(string[] args)
    {
        PrepChallenge1();
        PrepChallenge2();
        PrepChallenge3();
        PrepChallenge4();

    }

    static void PrepChallenge1()
    {
        int play = 0;
        do
        {

            Console.WriteLine("Code Challenge 1");
            Console.WriteLine("Choose 5 numbers between 1 & 10");
            int[] nums = new int[5];
            try
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine("Your Array is: ");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write(nums[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Choose a numder from the array, pls");
                int choice = Convert.ToInt32(Console.ReadLine());
                int score = 0;
                if (!nums.Contains(choice))
                {
                    Console.WriteLine("Your Score is: " + 0);
                }
                else
                {
                    foreach (int num in nums)
                    {
                        if (num == choice)
                        {
                            score += num;
                        }
                    }
                    Console.WriteLine("Your score is:" + score);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("We Goofed");
                Console.WriteLine(err.ToString());
            }
            finally
            {
                Console.WriteLine("The Game is Over");
            }
        } while (play == 1);
    }



    static void PrepChallenge2()
    {
        // the console.writeline displays the text into console
        Console.WriteLine("LeapYear Calculator");
        Console.WriteLine("Please enter a year:");

        // this line of code allows the user to enter a year as a string in the console, and it converts that string into an integer
        int year = Convert.ToInt32(Console.ReadLine());

        // ternary for finding leap year
        // A leap year is divisible by 4 but not divisible by 100, unless it is also divisible by 400
        string leapYearAlert = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? "is a leap year." : "is not a leap year.";
        Console.WriteLine(year + " " + leapYearAlert);

    }

    static void PrepChallenge3()
    {
        Console.WriteLine("Perfect Sequence");
        Console.WriteLine("Enter a sequence of integers, separated by commas:");

        string input = Console.ReadLine();
        // Split the input string by commas and parse each element as an integer
        int[] arr = input.Split(',').Select(int.Parse).ToArray();

        // calling the isPerefect method with my arr and storing the result
        string result = IsPerfectSequence(arr);
        Console.WriteLine(result);
        static string IsPerfectSequence(int[] arr)
        {
            int product = 1;
            int sum = 0;

            foreach (int num in arr)
            {
                if (num < 0)
                {
                    return "No"; // Negative numbers are not valid in a perfect sequence
                }

                product *= num;
                sum += num;
            }

            if (product == sum)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
static void PrepChallenge4()
    {
        int play = 0;
        do
        {
            Console.WriteLine("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] myArray = new int[rows, columns];
            int[] sumArray = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                Console.WriteLine($"Enter {columns} numbers for row {i + 1}:");
                for (int j = 0; j < columns; j++)
                {
                    myArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    sum += myArray[i, j];
                }
                sumArray[i] = sum;
            }

            Console.WriteLine("The sum of each row:");
            foreach (int sum in sumArray)
            {
                Console.WriteLine(sum);
            }

            Console.WriteLine("Done!!!");

        } while (play == 1);
    }
}



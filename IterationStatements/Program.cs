namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Create methods below

        // Write a method that will print to the console all numbers 1000 through -1000
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ThreebyThree()
        {
            for (int z = 3; z <= 999; z += 3)
            {
                Console.WriteLine(z);
            }
        }

        // Write a method to accept two integers as parameters and check whether they are equal or not
        public static bool EqualorNot(int e, int d)
        {
            var check = (e == d) ? true : false;

            return check;
            {

            }
       
        }

        // Write a method to check whether a given number is even or odd
        public static void EvenorOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }

        // Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int num)
        {
            return num > 0;
        }

        // Write a method to read the age of a candidate and determine whether they can vote.
        // Hint: Use Parse or the safer TryParse() for an extra challenge
        // Parse()
        // TryParse()
        public static bool CanVote()
        {
            Console.Write("Enter your age here: ");
            var canParse = int.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine(age);

            return  age >=0;

        }
        static void Main(string[] args)
        {
            PrintNumbers();
            ThreebyThree();
            Console.WriteLine(EqualorNot(11, 10));
            EvenorOdd(2);
            var isPositive = IsPositive(7);
            Console.WriteLine(isPositive);
            CanVote();
            Console.WriteLine("Vote Wisley!");
        }
    }
}





















































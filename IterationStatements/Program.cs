using System.ComponentModel;

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

            while (canParse == false)
            {
                Console.WriteLine("Please enter numeric age: ");
                canParse = int.TryParse(Console.ReadLine(), out age);
                Console.WriteLine(age);
            }


            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        static void Main(string[] args)
        {
            PrintNumbers();
            ThreebyThree();
            Console.WriteLine(EqualorNot(11, 10));
            EvenorOdd(2);
            var isPositive = IsPositive(7);
            Console.WriteLine(isPositive);
            bool canVote = CanVote();

            if (canVote)
            {
                Console.WriteLine("Vote Wisley! ");
            }
            else
            {
                Console.WriteLine("Eh, maybe next year.");
            }

            //bool InTenRange = InTenRange(9);

            Console.WriteLine(InTenRange);


            MultiplyThru12(12);



        }



        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static bool InTenRange(int num)
        {
            if (num <= 10 && num >= -10)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiplyThru12(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {num} x {i}");
            }




        }

    }

}



        
    
































































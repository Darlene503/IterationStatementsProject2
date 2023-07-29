namespace IterationStatements
{
    public class Program
    {
        private static int z;

        //LukeWarm Section: Create methods below

        //Write a method that will print to the console all numbers 1000 through - 1000

        static void Main(string[] args)
        {

            PrintNumbers();
            ThreebyThree();
            Console.WriteLine(EqualorNot(11, 10));
            EvenorOdd(2);

        }
        public static void PrintNumbers()
        {

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }


            //Write a method that will print to the console numbers 3 through 999 by 3 each time

        }
        public static void ThreebyThree()
        {

            for (int z = 3; z <= 999; z += 3)
            {
                Console.WriteLine(z);
            }



            //Write a method to accept two integers as parameterss and check whether they are equal or not
        }
        public static bool EqualorNot(int e, int d)
        {
            if (e == d)
            {
                return true;
            }
            else
            {
                return false;
            }

            //Write a method to check whether a given number is even or odd

        }
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

    }

}
    
    //Write a method to check whether a given number is positive or negative

    //Write a method to read the age of a candidate and determine whether they can vote.
    //Hint: Use Parse or the safer TryParse() for an extra challenge
    //Parse()
    //TryParse()

    //Heatin Up Section:
    //Write a method to check if an integer(from the user) is in the range -10 to 10

    //Write a method to display the multiplication table(from 1 to 12) of a given integer


    //Call the methods to test them in the Main method below















































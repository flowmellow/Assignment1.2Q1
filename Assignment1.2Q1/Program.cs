//Write a C# Sharp program to accept two integers and check whether they are equal or not.

namespace Assignment1._2Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input 2 integers for testing data");
            Console.WriteLine("Input 1st number: ");
            int testOneNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number: ");            
            int testOneNumber2 = Convert.ToInt32(Console.ReadLine());

            if (testOneNumber1 == testOneNumber2)
            {
                Console.WriteLine(testOneNumber1 + " and " + testOneNumber2 + " are equal.");
            }
            else 
            {
                Console.WriteLine(testOneNumber1 + " and " + testOneNumber2 + " are not equal.");
            }
            Console.WriteLine(); // Added for spacing
            Console.WriteLine("Thank you for using the application!");
        }
    }
}

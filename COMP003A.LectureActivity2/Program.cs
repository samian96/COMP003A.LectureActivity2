using System.Security.Cryptography.X509Certificates;

namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number here:");
            // should prompt the user to enter a number when console runs
            string userNumber = Console.ReadLine();
            // ReadLine should allow input from the user to type a value
            Console.WriteLine("Enter second number here:");
            // should prompt the user to write another number
            string userNumber2 = Console.ReadLine();
            // should allow input of a second number from user
            double number1 = double.Parse(userNumber);
            // should store the variable from user input
            double number2 = double.Parse(userNumber2);
            // should store the variable from user input 2
            double sum = number1 + number2;
            // assuming should take the sum of both user inputs
            double average = sum / 2;
            // assuming should find the average between the user inputs
            Console.WriteLine($"{sum}");
            // console writeline should display the sum of both number inputs
           
        }
    }
}

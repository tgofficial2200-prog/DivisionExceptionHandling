using System;

namespace DivisionExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            DivideStrings(input1, input2);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void DivideStrings(string value1, string value2)
        {
            try
            {
                int num1 = Convert.ToInt32(value1);
                int num2 = Convert.ToInt32(value2);

                int result = num1 / num2;

                Console.WriteLine($"\nResult: {num1} ÷ {num2} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: Please enter valid whole numbers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nError: Division by zero is not allowed.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nError: The number entered is too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nUnexpected error: {ex.Message}");
            }
        }
    }
}

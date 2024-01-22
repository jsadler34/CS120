using System.Transactions;

namespace GA_IntegralMath_Jake
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int myInt = 2147483647; // Int32: Ranges from -2,147,483,648 to 2,147,483,647. Commonly used for general counting.
            long myLong = 9223372036854775807L; // Int64: Larger range for big numbers, from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            byte myByte = 255; // Byte: Ranges from 0 to 255, often used for small counts or data manipulation.
            short myShort = 32767; // Int16: Useful for numbers between -32,768 and 32,767, when int is more than needed.
            sbyte mysbyt = -128; // sbyte: Ranges from -128 to 127, when you need a small number but it could be negative.
            ushort myushort = 65535; // ushort: Ranges from 0 - 65535, used for normal arithmetic and bitwise operations.
            uint myuint = 4294967295; // uint: Ranges from 0-4294967295. like an int but only positive. 
            ulong myulong = 18446744073709551615; // ulong: Ranges from 0-18,446,744,073,709,551,615. Like a long but only positive. 


            int sum = myInt + 100; // Addition: Combines two numbers into a larger sum.
            int difference = myInt - 50; // Subtraction: Removes a quantity from another.
            int product = myShort * 2; // Multiplication: Scales a number by another number.
            int quotient = myInt / 2; // Division: Splits a number into equal parts.
            int remainder = myByte % 10; // Modulus: Finds the remainder after division.

            Console.WriteLine("simple equations");

            int result1 = 5 + 3;
            Console.WriteLine($"Equation 1 Result: {result1}");

            int result2 = 10 - 4;
            Console.WriteLine($"Equation 2 Result: {result2}");

            int result3 = 7 * 2;
            Console.WriteLine($"Equation 3 Result: {result3}");

            int result4 = 20 / 4;
            Console.WriteLine($"Equation 4 Result: {result4}");

            int result5 = 9 % 2;
            Console.WriteLine($"Equation 5 Result: {result5}");

            int result6 = 15 + 6;
            Console.WriteLine($"Equation 6 Result: {result6}");

            int result7 = 12 - 7;
            Console.WriteLine($"Equation 7 Result: {result7}");

            int result8 = 4 * 3;
            Console.WriteLine($"Equation 8 Result: {result8}");

            int result9 = 30 / 5;
            Console.WriteLine($"Equation 9 Result: {result9}");

            int result10 = 16 % 3;
            Console.WriteLine($"Equation 10 Result: {result10}");

            int result11 = 8 + 10;
            Console.WriteLine($"Equation 11 Result: {result11}");

            int result12 = 20 - 8;
            Console.WriteLine($"Equation 12 Result: {result12}");

            int result13 = 6 * 7;
            Console.WriteLine($"Equation 13 Result: {result13}");

            int result14 = 45 / 9;
            Console.WriteLine($"Equation 14 Result: {result14}");

            int result15 = 25 % 4;
            Console.WriteLine($"Equation 15 Result: {result15}");

            Console.WriteLine("complex equations");

            result1 = (5 + 3) * 2;
            Console.WriteLine($"Equation 1 Result: {result1}");

            result2 = (10 - 4) + 7 * 3;
            Console.WriteLine($"Equation 2 Result: {result2}");

            result3 = 7 * (2 + 6) / 4;
            Console.WriteLine($"Equation 3 Result: {result3}");

            result4 = (20 / 4) + 15 - 3;
            Console.WriteLine($"Equation 4 Result: {result4}");

            result5 = (9 % 2) + 12 / 4;
            Console.WriteLine($"Equation 5 Result: {result5}");

        }
    }
} // End of Main
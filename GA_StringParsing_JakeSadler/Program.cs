// See https://aka.ms/new-console-template for more information


Console.Write("Enter your first number: "); // Display asking the user to enter a number
string userNum1 = Console.ReadLine(); // Getting the users 1st string
Console.Write("Enter your second number: "); // Display asking the user for their second number
string userNum2 = Console.ReadLine(); // getting the users 2nd string

int number1 = int.Parse(userNum1); // Converting the users 1st string into an int
int number2 = int.Parse(userNum2); // Converting the users 2nd string into an int

int number3 = number1 + number2;
Console.WriteLine($"number1+number2 is {number3}");

try
{
    Console.WriteLine("Enter your third number: ");
    string userNum3 = Console.ReadLine(); //capturing the third number
    double number4 = number1 + number2 + int.Parse(userNum3); //adding the three numbers together after parsing the third
    double number5 = number4 / 3; //getting the average of the numbers
    Console.WriteLine($"the average of the numbers is {number5}");
}
catch
{ // catch opening curly brace

    // This will run if our an error is thrown
    Console.WriteLine("You had an error");
} // closing curly brace
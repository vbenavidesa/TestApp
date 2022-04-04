// See https://aka.ms/new-console-template for more information
using TestApp;

Console.WriteLine("Please enter the value:");
var _value = Console.ReadLine();
if (_value == String.Empty || _value == null)
{
    Console.WriteLine("You didnt entered any value");
}
else
{
    var _result = RomanNumberConverter.FromRoman(_value);
    if (_result == 0)
    {
        Console.WriteLine("The value entered is incorrect!");
    }
    else
    {
        Console.WriteLine("The numeric value for this is: ");
        Console.WriteLine(_result);
    }
}

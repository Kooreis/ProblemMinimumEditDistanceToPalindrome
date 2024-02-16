using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string number = Console.ReadLine();
        Console.WriteLine("Minimum edit distance to convert the number to a palindrome: " + MinEditToPalindrome(number));
    }
}
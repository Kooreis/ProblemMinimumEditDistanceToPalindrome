Here is a C# console application that calculates the minimum edit distance to convert a number to a palindrome:

```C#
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string number = Console.ReadLine();
        Console.WriteLine("Minimum edit distance to convert the number to a palindrome: " + MinEditToPalindrome(number));
    }

    static int MinEditToPalindrome(string number)
    {
        int n = number.Length;
        int[,] dp = new int[n, n];

        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (number[i] == number[j])
                {
                    dp[i, j] = dp[i + 1, j - 1];
                }
                else
                {
                    dp[i, j] = Math.Min(dp[i + 1, j], dp[i, j - 1]) + 1;
                }
            }
        }

        return dp[0, n - 1];
    }
}
```

This program reads a number from the user, then calculates and prints the minimum number of edits required to convert the number to a palindrome. The calculation is done using dynamic programming. The 2D array `dp` is used to store the minimum number of edits required to convert the substring from index `i` to `j` to a palindrome. The final result is stored in `dp[0, n - 1]`, which represents the minimum number of edits required to convert the entire string to a palindrome.
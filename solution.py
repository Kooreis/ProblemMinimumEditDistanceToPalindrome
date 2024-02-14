Here is a Python console application that calculates the minimum edit distance to convert a number to a palindrome. The application uses dynamic programming to solve the problem.

```python
def min_edit_distance(num):
    num = str(num)
    n = len(num)
    dp = [[0 for _ in range(n+1)] for _ in range(n+1)]
    for i in range(n+1):
        dp[i][0] = i
        dp[0][i] = i
    for i in range(1, n+1):
        for j in range(1, n+1):
            if num[i-1] == num[n-j]:
                dp[i][j] = dp[i-1][j-1]
            else:
                dp[i][j] = 1 + min(dp[i][j-1], dp[i-1][j])
    return dp[n][n] // 2

if __name__ == "__main__":
    num = input("Enter a number: ")
    print("Minimum edit distance to convert the number to a palindrome: ", min_edit_distance(num))
```

This application first converts the input number to a string. It then creates a 2D array to store the minimum edit distances for all substrings of the input string. The application then iterates over the string and its reverse, updating the minimum edit distance for each pair of substrings. The minimum edit distance to convert the number to a palindrome is then returned.
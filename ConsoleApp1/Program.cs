using ConsoleApp1;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        PalindromeChecker palindrome = new PalindromeChecker();
   

        string text1 = "racecar"; // This is a palindrome
        string text2 = "hello";   // This is not a palindrome

        bool isPalindrome1 = palindrome.IsPalindrome(text1);
        bool isPalindrome2 = palindrome.IsPalindrome(text2);

        Console.WriteLine($"Text 1 is a palindrome: {isPalindrome1}");
        Console.WriteLine($"Text 2 is a palindrome: {isPalindrome2}");



        
            int amount = 27; // Change this to the desired amount
            int minCoins = CoinChange.MinSplit(amount);
            Console.WriteLine("Minimum number of coins to make " + amount + " tetri: " + minCoins);


        int[] array = { 1, 3, 6, 4, 1, 2 };
        ArrayUtils arrayUtils = new ArrayUtils();
        int result = arrayUtils.NotContains(array);
        Console.WriteLine("The smallest positive integer not present in the array is: " + result);



        string sequence1 = "([]{})"; // Properly matched
        string sequence2 = "([)]";   // Not properly matched

        Solution solution = new Solution();
        bool result1 = solution.IsProperly(sequence1);
        bool result2 = solution.IsProperly(sequence2);

        Console.WriteLine("Sequence 1 is properly matched: " + result1);
        Console.WriteLine("Sequence 2 is properly matched: " + result2);




            int stairCount = 4; // Change this to the desired number of stairs

        variants Variants = new variants();
            int variants = Variants.CountVariants(stairCount);

            Console.WriteLine($"Number of ways to climb {stairCount} stairs: {variants}");
      

}

}

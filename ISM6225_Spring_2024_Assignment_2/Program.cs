﻿using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
{
        try
        {
            // Write your code here
            List<int> result = new List<int>();
            bool[] seen = new bool[nums.Length + 1];
            foreach (int num in nums)
            {
                if (num >= 1 && num <= nums.Length)
                    seen[num] = true;
            }
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!seen[i])
                result.Add(i);
            }
            return result;
        }
        catch (Exception)
        {
            throw;
        }
}

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
{
    try
    {
        // Write your code here
        List<int> result = new List<int>();
        foreach (int num in nums)
        {
            if (num % 2 == 0)
                result.Add(num);
        }
        foreach (int num in nums)
        {
            if (num % 2 != 0)
                result.Add(num);
        }
        return result.ToArray();
    }
    catch (Exception)
    {
        throw;
    }
}


        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
{
    try
    {
        // Write your code here
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
                return new int[] { map[complement], i };
            if (!map.ContainsKey(nums[i]))
                map[nums[i]] = i;
        }
        return new int[0];
    }
    catch (Exception)
    {
        throw;
    }
}


        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
{
    try
    {
        // Write your code here
        Array.Sort(nums);
        int n = nums.Length;
        int product1 = nums[n - 1] * nums[n - 2] * nums[n - 3];
        int product2 = nums[0] * nums[1] * nums[n - 1];
        return Math.Max(product1, product2);
    }
    catch (Exception)
    {
        throw;
    }
}


        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
{
    try
    {
        // Write your code here
        return Convert.ToString(decimalNumber, 2);
    }
    catch (Exception)
    {
        throw;
    }
}


        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
{
    try
    {
        // Write your code here
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] > nums[right])
                left = mid + 1;
            else
                right = mid;
        }
        return nums[left];
    }
    catch (Exception)
    {
        throw;
    }
}


        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
{
    try
    {
        // Write your code here
        if (x < 0) return false;
        int original = x;
        int reversed = 0;
        while (x != 0)
        {
            int digit = x % 10;
            reversed = reversed * 10 + digit;
            x /= 10;
        }
        return original == reversed;
    }
    catch (Exception)
    {
        throw;
    }
}


        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                if(n <= 1) return n;
                int a = 0, b = 1, c = 0;
                for (int i = 2; i <= n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return b; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

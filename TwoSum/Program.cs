/* Test assignment: TwoSum

Given an array of integers nums and an integer target, return the two numbers such that they add up to target.
If there are several such pairs of numbers, then return any of them.
If there are no such numbers, then return "None".

Example 1.
Input: nums = [2, 7, 11, 15], target = 9
Output: 2, 7
Explanation: Because 2 + 7 == 9, we return 2, 7.

Example 2.
Input: nums = [6, 2, 8, -3, 1, 1, 6, 10], target = 100
Output: None
Explanation: there are no two numbers that add up to 100, we return None.

Example 3.
Input: nums = [3, 3], target = 6
Output: 3, 3


Constraints.
2 <= nums.length <= 10^4
-10^5 <= nums[i] <= 10^5
-10^5 <= target <= 10^5


Follow-up: Can you come up with an algorithm that is less than O(n^2) time complexity?

 */

// Compiler: Mono C# 5.2.0

using System;
using NUnit.Framework;

namespace ConsoleApp
{
    internal class Program
    {
        static public string TwoSum(int[] arr, int X)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = i + 1; j < arr.Length; ++j)
                {
                    if (arr[i] + arr[j] == X)
                    {
                        return arr[i].ToString() + " " + arr[j].ToString();
                    }
                }
            }

            return "None";
        }
        static void Main(string[] args)
        {
            {
                TestAll.test1();

                //int n = Int32.Parse(Console.ReadLine());
                //int[] arr = new int[n];
                //arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                //int X = Int32.Parse(Console.ReadLine());

                //Console.WriteLine(TwoSum(arr, X));
            }
        }
    }
}

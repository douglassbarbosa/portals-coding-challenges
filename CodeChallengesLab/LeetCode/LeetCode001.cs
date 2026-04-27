namespace CodeChallengesLab.LeetCode;
public class LeetCode001
{
    //method to read input and call the solution method - this is for testing purposes
    public static void Run()
    {
        //read input Array
        string input = Console.ReadLine() ?? string.Empty;
        int[] nums = Array.ConvertAll(input.Split(','), int.Parse);
        //read target
        int target = int.Parse(Console.ReadLine() ?? "0");
        //call method
        int[] result = TwoSum(nums, target);
        //print result
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
    //method to solve the problem - Use this method as a answer to the problem
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }
        throw new ArgumentException("No two sum solution");
    }
}

// 1. Two Sum
// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.
// Output: [0,1]
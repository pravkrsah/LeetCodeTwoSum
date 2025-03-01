using System.Collections.Generic;


//Method - 1
//public class LeetCodeTwoSum
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        for (int i = 0; i < nums.Length - 1; i++)
//        {
//            for (int j = i + 1; j < nums.Length; j++)
//            {
//                if (nums[i] + nums[j] == target)
//                {
//                    return new int[2] { i, j };
//                }
//            }
//        }
//        return new int[0];
//    }

//    public static void Main()
//    {
//        LeetCodeTwoSum leet = new LeetCodeTwoSum();
//        int[] nums = { 2, 7, 11, 15 };
//        int target = 9;
//        int[] result = leet.TwoSum(nums, target);

//        if (result.Length == 2)
//        {
//            Console.WriteLine("Indices: [" + result[0] + ", " + result[1] + "]");
//        }
//        else
//        {
//            Console.WriteLine("No solution found");
//        }
//        Console.ReadLine();
//    }
//}


//Method - 2
public class TwoSumDictionary
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int index = 0;

        foreach (var num in nums)
        {
            if (dict.ContainsKey(target - num))
                return new int[] { dict[target - num], index };
            else
                dict.Add(num, index);

            index++;
        }
        return new int[2];
    }

    public static void Main()
    {
        TwoSumDictionary leet = new TwoSumDictionary();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = leet.TwoSum(nums, target);

        if (result.Length == 2)
        {
            Console.WriteLine("Indices: [" + result[0] + ", " + result[1] + "]");
        }
        else
        {
            Console.WriteLine("No solution found");
        }
        Console.ReadLine();
    }

}

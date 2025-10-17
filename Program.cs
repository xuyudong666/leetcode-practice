using leetcode;

LeetCodeSample leetCodeSample = new LeetCodeSample();

#region 优质数对的总数 I
// void TestSubarraySum(int[] nums, string label, int expected)
// {
//     var res = leetCodeSample.NumberOfPairs(nums1, nums2, k);
//     Console.WriteLine($"{label} nums1=[{string.Join(",", nums1)}], nums2=[{string.Join(",", nums2)}], k={k} -> {res} (期望={expected})");
// }

// TestNumberOfPairs(new[] { 1, 3, 4 }, new[] { 1, 3, 4 }, 1, "NumberOfPairs 示例1", 5);
// TestNumberOfPairs(new[] { 1, 2, 4, 12 }, new[] { 2, 4 }, 3, "NumberOfPairs 示例2", 2);

#endregion

#region 构成整天的下标对数目 I
// void TestCountCompleteDayPairs(int[] hours, string label, int expected)
// {
//     var res = leetCodeSample.CountCompleteDayPairs(hours);
//     Console.WriteLine($"{label} hours=[{string.Join(",", hours)}] -> {res} (期望={expected})");
// }

// TestCountCompleteDayPairs(new[] { 12, 12, 30, 24, 24 }, "CountCompleteDayPairs 示例1", 2);
// TestCountCompleteDayPairs(new[] { 72, 48, 24, 3 }, "CountCompleteDayPairs 示例2", 3);

#endregion

#region 判断一个数是否是2的幂次数

System.Console.WriteLine(leetCodeSample.IsPowerOfTwo(1));  // true
System.Console.WriteLine(leetCodeSample.IsPowerOfTwo(2)); // true
System.Console.WriteLine(leetCodeSample.IsPowerOfTwo(3));  // false
System.Console.WriteLine(leetCodeSample.IsPowerOfTwo(4));
System.Console.WriteLine(leetCodeSample.IsPowerOfTwo(8));
System.Console.WriteLine(leetCodeSample.IsPowerOfTwo(9));

#endregion

#region 
// void TestEvenOr(int[] nums, string label, int expected)
// {
//     var res = leetCodeSample.EvenNumberBitwiseORs(nums);
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}] -> {res} (期望={expected})");
// }

// TestEvenOr(new[] { 1, 2, 3, 4, 5, 6 }, "EvenNumberBitwiseORs 示例1", 6);
// TestEvenOr(new[] { 7, 9, 11 },          "EvenNumberBitwiseORs 示例2", 0);
// TestEvenOr(new[] { 1, 8, 16 },          "EvenNumberBitwiseORs 示例3", 24);
#endregion

#region 特殊数组 I
// void TestIsArraySpecial(int[] nums, string label, bool expected)
// {
//     var res = leetCodeSample.IsArraySpecial(nums);
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}] -> {res} (期望={expected})");
// }

// TestIsArraySpecial(new[] { 1 }, "IsArraySpecial 示例1", true);
// TestIsArraySpecial(new[] { 2, 1, 4 }, "IsArraySpecial 示例2", true);
// TestIsArraySpecial(new[] { 4, 3, 1, 6 }, "IsArraySpecial 示例3", false);
#endregion

#region 3701 计算交替和 测试
// void TestAlternatingSum(int[] nums, string label, int expected)
// {
//     var res = leetCodeSample.AlternatingSum(nums);
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}] -> {res} (期望={expected})");
// }

// TestAlternatingSum(new[] { 1, 3, 5, 7 }, "AlternatingSum 示例1", -4);
// TestAlternatingSum(new[] { 100 }, "AlternatingSum 示例2", 100);
// TestAlternatingSum(new[] { 2, 4, 6 }, "AlternatingSum 额外用例", 4); // 2 - 4 + 6 = 4
#endregion

#region MinimumOperations 测试
void TestMinimumOperations(int[] nums, string label, int expected)
{
    var res = leetCodeSample.MinimumOperations(nums);
    Console.WriteLine($"{label} nums=[{string.Join(",", nums)}] -> {res} (期望={expected})");
}

TestMinimumOperations(new[] { 1, 2, 3, 4 }, "MinimumOperations 示例1", 3);
TestMinimumOperations(new[] { 3, 6, 9 }, "MinimumOperations 示例2", 0);
#endregion
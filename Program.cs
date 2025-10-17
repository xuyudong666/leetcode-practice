using leetcode;

// string s = "zaz";

LeetCodeSample leetCodeSample = new LeetCodeSample();

// void TestSubarraySum(int[] nums, string label, int expected)
// {
//     var val = leetCodeSample.SubarraySum(nums);
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}] -> {val} (期望={expected})");
// }

// TestSubarraySum(new[] { 2, 3, 1 }, "SubarraySum 用例1", 11);
// TestSubarraySum(new[] { 3, 1, 1, 2 }, "SubarraySum 用例2", 13);

// void TestMinCosts(int[] cost, string label, int[] expected)
// {
//     var res = leetCodeSample.MinCosts(cost);
//     Console.WriteLine($"{label} cost=[{string.Join(",", cost)}] -> [{string.Join(",", res)}] (期望=[{string.Join(",", expected)}])");
// }

// TestMinCosts(new[] { 5, 3, 4, 1, 3, 2 }, "MinCosts 示例1", new[] { 5, 3, 3, 1, 1, 1 });
// TestMinCosts(new[] { 1, 2, 4, 6, 7 }, "MinCosts 示例2", new[] { 1, 1, 1, 1, 1 });

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
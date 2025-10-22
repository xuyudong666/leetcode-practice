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

// System.Console.WriteLine(leetCodeSample.IsPowerOfTwo(1));  // true
// System.Console.WriteLine(leetCodeSample.IsPowerOfTwo(2)); // true
// System.Console.WriteLine(leetCodeSample.IsPowerOfTwo(3));  // false
// System.Console.WriteLine(leetCodeSample.IsPowerOfTwo(4));
// System.Console.WriteLine(leetCodeSample.IsPowerOfTwo(8));
// System.Console.WriteLine(leetCodeSample.IsPowerOfTwo(9));

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
// void TestMinimumOperations(int[] nums, string label, int expected)
// {
//     var res = leetCodeSample.MinimumOperations(nums);
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}] -> {res} (期望={expected})");
// }

// TestMinimumOperations(new[] { 1, 2, 3, 4 }, "MinimumOperations 示例1", 3);
// TestMinimumOperations(new[] { 3, 6, 9 }, "MinimumOperations 示例2", 0);
#endregion

#region 最小元素和最大元素的最小平均值测试
// void TestMinimumAverage(int[] nums, string label, double expected)
// {
//     var res = leetCodeSample.MinimumAverage(nums);
//     // 使用字符串格式化保留1位小数，避免浮点数精度问题
//     string actualStr = res.ToString("F1");
//     string expectedStr = expected.ToString("F1");
//     bool passed = actualStr == expectedStr;

//     Console.ForegroundColor = passed ? ConsoleColor.Green : ConsoleColor.Red;
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}]");
//     Console.WriteLine($"  计算结果: {res:F1} (期望: {expected:F1})");
//     Console.WriteLine($"  测试结果: {(passed ? "通过" : "失败")}");
//     Console.ResetColor();
// }

// // 示例测试用例
// TestMinimumAverage(new[] { 7, 8, 3, 4, 15, 13, 4, 1 }, "示例1", 5.5);
// TestMinimumAverage(new[] { 1, 9, 8, 3, 10, 5 }, "示例2", 5.5);
// TestMinimumAverage(new[] { 1, 2, 3, 7, 8, 9 }, "示例3", 5.0);

// // 边界测试：最小数组（2个元素）
// TestMinimumAverage(new[] { 5, 10 }, "边界测试-2个元素", 7.5);
#endregion

#region 替换为数位和以后的最小元素

//System.Console.WriteLine(leetCodeSample.BitSum(999));

// void TestMinElement(int[] nums, string label, int expected)
// {
//     int res = leetCodeSample.MinElement(nums);
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}] -> {res} (期望={expected})");
// }

// TestMinElement(new[] { 10, 12, 13, 14 }, "MinElement 示例1", 1);
// TestMinElement(new[] { 1, 2, 3, 4 }, "MinElement 示例2", 1);
// TestMinElement(new[] { 999, 19, 199 }, "MinElement 示例3", 10);
#endregion

#region 
// void TestTransformArray(int[] nums, int[] expected, string label)
// {
//     var res = leetCodeSample.TransformArray(nums);
//     Console.WriteLine($"{label} input=[{string.Join(",", nums)}] -> [{string.Join(",", res)}] 期望=[{string.Join(",", expected)}]");
// }

// TestTransformArray(new[] { 4, 3, 2, 1 },      new[] { 0, 0, 1, 1 },       "TransformArray 示例1");
// TestTransformArray(new[] { 1, 5, 1, 4, 2 },   new[] { 0, 0, 1, 1, 1 },    "TransformArray 示例2");
#endregion

#region 循环数组中相邻元素的最大差值测试
// void TestMaxAdjacentDistance(int[] nums, string label, int expected)
// {
//     var res = leetCodeSample.MaxAdjacentDistance(nums);
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}] -> {res} (期望={expected})");
// }

// TestMaxAdjacentDistance(new[] { 1, 2, 4 }, "MaxAdjacentDistance 示例1", 3);
// TestMaxAdjacentDistance(new[] { -5, -10, -5 }, "MaxAdjacentDistance 示例2", 5);
// TestMaxAdjacentDistance(new[] { -2,-5 }, "MaxAdjacentDistance 示例3", 3);
#endregion

#region K 次乘运算后的最终数组 I
// void TestGetFinalState(int[] nums, int k, int multiplier, string label, int[] expected)
// {
//     var inputStr = string.Join(",", nums);
//     var res = leetCodeSample.GetFinalState((int[])nums.Clone(), k, multiplier);
//     bool pass = res.SequenceEqual(expected);
//     Console.ForegroundColor = pass ? ConsoleColor.Green : ConsoleColor.Red;
//     Console.WriteLine($"{label} nums=[{inputStr}], k={k}, multiplier={multiplier}");
//     Console.WriteLine($"  结果=[{string.Join(",", res)}], 期望=[{string.Join(",", expected)}] -> {(pass ? "通过" : "失败")}");
//     Console.ResetColor();
// }

// TestGetFinalState(new[] { 2, 1, 3, 5, 6 }, 5, 2, "GetFinalState 示例1", new[] { 8, 4, 6, 5, 6 });
// TestGetFinalState(new[] { 1, 2 }, 3, 4, "GetFinalState 示例2", new[] { 16, 8 });
#endregion

#region 构成整天的下标对数目 I
// void TestCountCompleteDayPairs(int[] hours, string label, int expected)
// {
//     var res = leetCodeSample.CountCompleteDayPairs(hours);
//     bool pass = res == expected;
//     Console.ForegroundColor = pass ? ConsoleColor.Green : ConsoleColor.Red;
//     Console.WriteLine($"{label} hours=[{string.Join(",", hours)}]");
//     Console.WriteLine($"  结果={res}, 期望={expected} -> {(pass ? "通过" : "失败")}");
//     Console.ResetColor();
// }

// TestCountCompleteDayPairs(new[] { 12, 12, 30, 24, 24 }, "CountCompleteDayPairs 示例1", 2);
// TestCountCompleteDayPairs(new[] { 72, 48, 24, 3 }, "CountCompleteDayPairs 示例2", 3);
#endregion

#region 好数字之和
void TestSumOfGoodNumbers(int[] nums, int k, string label, int expected)
{
    var res = leetCodeSample.SumOfGoodNumbers(nums, k);
    bool pass = res == expected;
    Console.ForegroundColor = pass ? ConsoleColor.Green : ConsoleColor.Red;
    Console.WriteLine($"{label} nums=[{string.Join(",", nums)}], k={k}");
    Console.WriteLine($"  结果={res}, 期望={expected} -> {(pass ? "通过" : "失败")}");
    Console.ResetColor();
}

TestSumOfGoodNumbers(new[] { 1, 3, 2, 1, 5, 4 }, 2, "SumOfGoodNumbers 示例1", 12);
TestSumOfGoodNumbers(new[] { 2, 1 }, 1, "SumOfGoodNumbers 示例2", 2);
#endregion

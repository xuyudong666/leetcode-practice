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
// void TestSumOfGoodNumbers(int[] nums, int k, string label, int expected)
// {
//     var res = leetCodeSample.SumOfGoodNumbers(nums, k);
//     bool pass = res == expected;
//     Console.ForegroundColor = pass ? ConsoleColor.Green : ConsoleColor.Red;
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}], k={k}");
//     Console.WriteLine($"  结果={res}, 期望={expected} -> {(pass ? "通过" : "失败")}");
//     Console.ResetColor();
// }

// TestSumOfGoodNumbers(new[] { 1, 3, 2, 1, 5, 4 }, 2, "SumOfGoodNumbers 示例1", 12);
// TestSumOfGoodNumbers(new[] { 2, 1 }, 1, "SumOfGoodNumbers 示例2", 2);
#endregion

#region 数位和等于下标的最小下标
// void TestSmallestIndex(int[] nums, string label, int expected)
// {
//     var res = leetCodeSample.SmallestIndex(nums);
//     bool pass = res == expected;
//     Console.ForegroundColor = pass ? ConsoleColor.Green : ConsoleColor.Red;
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}]");
//     Console.WriteLine($"  结果={res}, 期望={expected} -> {(pass ? "通过" : "失败")}");
//     Console.ResetColor();
// }

// TestSmallestIndex(new[] { 1, 3, 2 }, "SmallestIndex 示例1", 2);
// TestSmallestIndex(new[] { 1, 10, 11 }, "SmallestIndex 示例2", 1);
// TestSmallestIndex(new[] { 1, 2, 3 }, "SmallestIndex 示例3", -1);
#endregion

#region 出现次数能被 K 整除的元素总和
// void TestSumDivisibleByK(int[] nums, int k, string label, int expected)
// {
//     var res = leetCodeSample.SumDivisibleByK(nums, k);
//     bool pass = res == expected;
//     Console.ForegroundColor = pass ? ConsoleColor.Green : ConsoleColor.Red;
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}], k={k}");
//     Console.WriteLine($"  结果={res}, 期望={expected} -> {(pass ? "通过" : "失败")}");
//     Console.ResetColor();
// }

// TestSumDivisibleByK(new[] { 1, 2, 2, 3, 3, 3, 3, 4 }, 2, "SumDivisibleByK 示例1", 16);
// TestSumDivisibleByK(new[] { 1, 2, 3, 4, 5 }, 2, "SumDivisibleByK 示例2", 0);
// TestSumDivisibleByK(new[] { 4, 4, 4, 1, 2, 3 }, 3, "SumDivisibleByK 示例3", 12);
#endregion

#region 交替组 I
// void TestNumberOfAlternatingGroups(int[] colors, string label, int expected)
// {
//     var res = leetCodeSample.NumberOfAlternatingGroups(colors);
//     bool pass = res == expected;
//     Console.ForegroundColor = pass ? ConsoleColor.Green : ConsoleColor.Red;
//     Console.WriteLine($"{label} colors=[{string.Join(",", colors)}]");
//     Console.WriteLine($"  结果={res}, 期望={expected} -> {(pass ? "通过" : "失败")}");
//     Console.ResetColor();
// }

// TestNumberOfAlternatingGroups(new[] { 1, 1, 1 }, "NumberOfAlternatingGroups 示例1", 0);
// TestNumberOfAlternatingGroups(new[] { 0, 1, 0, 0, 1 }, "NumberOfAlternatingGroups 示例2", 3);
#endregion

#region 构造最小位运算数组 I
// void TestMinBitwiseArray(int[] nums, string label, int[] expected)
// {
//     var res = leetCodeSample.MinBitwiseArray(nums);
//     bool pass = res.SequenceEqual(expected);
//     Console.ForegroundColor = pass ? ConsoleColor.Green : ConsoleColor.Red;
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}]");
//     Console.WriteLine($"  结果=[{string.Join(",", res)}], 期望=[{string.Join(",", expected)}] -> {(pass ? "通过" : "失败")}");
//     Console.ResetColor();
// }

// TestMinBitwiseArray(new[] { 2, 3, 5, 7 }, "MinBitwiseArray 示例1", new[] { -1, 1, 4, 3 });
// TestMinBitwiseArray(new[] { 11, 13, 31 }, "MinBitwiseArray 示例2", new[] { 9, 12, 15 });
#endregion

#region 求出出现两次数字的 XOR 值
// void TestDuplicateNumbersXOR(int[] nums, string label, int expected)
// {
//     int res = leetCodeSample.DuplicateNumbersXOR(nums);
//     bool pass = res == expected;
//     Console.ForegroundColor = pass ? ConsoleColor.Green : ConsoleColor.Red;
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}]");
//     Console.WriteLine($"  结果={res}, 期望={expected} -> {(pass ? "通过" : "失败")}");
//     Console.ResetColor();
// }

// TestDuplicateNumbersXOR(new[] { 1, 2, 1, 3 }, "DuplicateNumbersXOR 示例1", 1);
// TestDuplicateNumbersXOR(new[] { 1, 2, 3 }, "DuplicateNumbersXOR 示例2", 0);
// TestDuplicateNumbersXOR(new[] { 1, 2, 2, 1 }, "DuplicateNumbersXOR 示例3", 3);
#endregion

#region 链表最大孪生和
// ListNode BuildList(int[] values)
// {
//     var dummy = new ListNode(0);
//     var current = dummy;
//     foreach (var value in values)
//     {
//         current.next = new ListNode(value);
//         current = current.next;
//     }
//     return dummy.next!;
// }

// void TestPairSum(int[] nums, string label, int expected)
// {
//     var head = BuildList(nums);
//     int res = leetCodeSample.PairSum(head);
//     bool pass = res == expected;
//     Console.ForegroundColor = pass ? ConsoleColor.Green : ConsoleColor.Red;
//     Console.WriteLine($"{label} head=[{string.Join(",", nums)}]");
//     Console.WriteLine($"  结果={res}, 期望={expected} -> {(pass ? "通过" : "失败")}");
//     Console.ResetColor();
// }

// TestPairSum(new[] { 5, 4, 2, 1 }, "PairSum 示例1", 6);
// TestPairSum(new[] { 4, 2, 2, 3 }, "PairSum 示例2", 7);
// TestPairSum(new[] { 1, 100000 }, "PairSum 示例3", 100001);
#endregion

#region 矩阵中的蛇
// void TestFinalPositionOfSnake(int n, string[] commands, string label, int expected)
// {
//     int res = leetCodeSample.FinalPositionOfSnake(n, commands);
//     bool pass = res == expected;
//     Console.ForegroundColor = pass ? ConsoleColor.Green : ConsoleColor.Red;
//     Console.WriteLine($"{label} n={n}, commands=[{string.Join(",", commands)}]");
//     Console.WriteLine($"  结果={res}, 期望={expected} -> {(pass ? "通过" : "失败")}");
//     Console.ResetColor();
// }

// TestFinalPositionOfSnake(2, new[] { "RIGHT", "DOWN" }, "FinalPositionOfSnake 示例1", 3);
// TestFinalPositionOfSnake(3, new[] { "DOWN", "RIGHT", "UP" }, "FinalPositionOfSnake 示例2", 1);
#endregion

#region 统计元素和差值为偶数的分区方案
// void TestCountPartitions(int[] nums, string label, int expected)
// {
//     int res = leetCodeSample.CountPartitions(nums);
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}] -> {res} (期望={expected})");
// }

// TestCountPartitions(new[] { 10, 10, 3, 7, 6 }, "CountPartitions 示例1", 4);
// TestCountPartitions(new[] { 1, 2, 2 }, "CountPartitions 示例2", 0);
// TestCountPartitions(new[] { 2, 4, 6, 8 }, "CountPartitions 示例3", 3);
#endregion

#region 求出出现两次数字的 XOR 值
// void TestDuplicateNumbersXOR(int[] nums, string label, int expected)
// {
//     int res = leetCodeSample.DuplicateNumbersXOR(nums);
//     Console.WriteLine($"{label} nums=[{string.Join(",", nums)}] -> {res} (期望={expected})");
// }

// TestDuplicateNumbersXOR(new[] { 10,18,7,10,18 }, "DuplicateNumbersXOR 示例4", 24);
// TestDuplicateNumbersXOR(new[] { 1, 2, 1, 3 }, "DuplicateNumbersXOR 示例1", 1);
// TestDuplicateNumbersXOR(new[] { 1, 2, 3 }, "DuplicateNumbersXOR 示例2", 0);
// TestDuplicateNumbersXOR(new[] { 1, 2, 2, 1 }, "DuplicateNumbersXOR 示例3", 3);
#endregion

#region NeighborSum 测试
// void TestNeighborSum(int[][] grid, int value1, int value2, string label1, string label2, int expAdj, int expAdj2, int expDiag1, int expDiag2)
// {
//     var helper = new NeighborSum(grid);
//     //Console.WriteLine($"{label1} AdjacentSum({value1}) -> {helper.AdjacentSum(value1)} (期望={expAdj})");
//     //Console.WriteLine($"{label1} AdjacentSum({value2}) -> {helper.AdjacentSum(value2)} (期望={expAdj2})");
//     Console.WriteLine($"{label1} DiagonalSum({value2}) -> {helper.DiagonalSum(value2)} (期望={expDiag1})");
//     Console.WriteLine($"{label1} DiagonalSum({value1}) -> {helper.DiagonalSum(value1)} (期望={expDiag2})");
// }

// TestNeighborSum(
//     new[]
//     {
//         new[] { 0, 1, 2 },
//         new[] { 3, 4, 5 },
//         new[] { 6, 7, 8 }
//     },
//     1, 4, "示例1", "示例1", 6, 16, 16, 4);

// var grid2 = new[]
// {
//     new[] { 1, 2, 0, 3 },
//     new[] { 4, 7, 15, 6 },
//     new[] { 8, 9, 10, 11 },
//     new[] { 12, 13, 14, 5 }
// };
// var helper2 = new NeighborSum(grid2);
// Console.WriteLine($"示例2 AdjacentSum(15) -> {helper2.AdjacentSum(15)} (期望=23)");
// Console.WriteLine($"示例2 DiagonalSum(9) -> {helper2.DiagonalSum(9)} (期望=45)");
#endregion

#region 使数组的值全部为 K 的最少操作次数
void TestMinOperations(int[] nums, int k, string label, int expected)
{
    var res = leetCodeSample.MinOperations(nums, k);
    bool pass = res == expected;
    Console.ForegroundColor = pass ? ConsoleColor.Green : ConsoleColor.Red;
    Console.WriteLine($"{label} nums=[{string.Join(",", nums)}], k={k}");
    Console.WriteLine($"  结果={res}, 期望={expected} -> {(pass ? "通过" : "失败")}");
    Console.ResetColor();
}

TestMinOperations(new[] { 5, 2, 5, 4, 5 }, 2, "MinOperations 示例1", 2);
TestMinOperations(new[] { 2, 1, 2 }, 2, "MinOperations 示例2", -1);
TestMinOperations(new[] { 9, 7, 5, 3 }, 1, "MinOperations 示例3", 4);
#endregion
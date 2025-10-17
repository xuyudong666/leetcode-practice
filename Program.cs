using leetcode;

LeetCodeSample leetCodeSample = new LeetCodeSample();

#region 优质数对的总数 I
// void TestNumberOfPairs(int[] nums1, int[] nums2, int k, string label, int expected)
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
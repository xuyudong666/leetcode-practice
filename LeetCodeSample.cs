
using System.Runtime.CompilerServices;

namespace leetcode;

public class LeetCodeSample
{

    #region 出现频率最低的数字
    public int GetLeastFrequentDigit(int n)
    {
        Dictionary<int, int> pairs = [];
        while (n > 0)
        {
            var num = n % 10;
            if (pairs.TryGetValue(num, out var count))
            {
                pairs[num] = count + 1;
            }
            else
            {
                pairs[num] = 1;
            }

            n /= 10;
        }

        KeyValuePair<int, int> p = new(int.MaxValue, int.MaxValue);
        foreach (var pair in pairs)
        {
            if (pair.Value < p.Value)
            {
                p = pair;
            }

            if (pair.Value == p.Value && pair.Key < p.Key)
            {
                p = pair;
            }
        }

        return p.Key;
    }
    #endregion

    #region 统计特殊字母的数量 I
    public int NumberOfSpecialChars(string word)
    {
        int result = 0;

        HashSet<char> chars = [];

        for (int i = 0; i < word.Length; i++)
        {
            if (chars.Contains(word[i]))
            {
                continue;
            }
            else
            {
                chars.Add(word[i]);
            }


            if (chars.Contains((char)(word[i] - ' ')) || chars.Contains((char)(word[i] + ' ')))
            {
                ++result;
            }
        }

        return result;
    }
    #endregion

    #region 找到字符串中合法的相邻数字
    public string FindValidPair(string s)
    {
        Dictionary<char, int> cDict = [];

        for (int i = 0; i < s.Length; i++)
        {
            if (cDict.TryGetValue(s[i], out int value))
            {
                cDict[s[i]] = ++value;
            }
            else
            {
                cDict[s[i]] = 1;
            }
        }

        for (int i = 0; i < s.Length - 1; i++)
        {
            int next = i + 1;
            if (s[i] != s[next] && (s[i] - '0') == cDict[s[i]] && (s[next] - '0') == cDict[s[next]])
            {
                return new string([s[i], s[next]]);
            }
        }
        return string.Empty;
    }
    #endregion

    #region 字符串及其反转中是否存在同一子字符串
    public bool IsSubstringPresent(string s)
    {
        HashSet<string> strings = [];

        for (int i = 0; i < s.Length - 1; i++)
        {
            strings.Add(new string([s[i], s[i + 1]]));
        }

        for (int i = s.Length - 1; i > 0; i--)
        {
            if (strings.Contains(new string([s[i], s[i - 1]])))
            {
                return true;
            }
        }

        return false;
    }
    #endregion

    #region 两个字符串的排列差
    public int FindPermutationDifference(string s, string t)
    {
        Dictionary<char, int> cDict = [];

        for (int i = 0; i < s.Length; i++)
        {
            cDict[s[i]] = i;
        }

        int result = 0;

        for (int i = 0; i < t.Length; i++)
        {
            var index = cDict[t[i]];
            result += Math.Abs(index - i);
        }

        return result;
    }
    #endregion

    #region 找到频率最高的元音和辅音
    public int MaxFreqSum(string s)
    {
        Dictionary<char, int> vowelDictionary = [];
        Dictionary<char, int> consonantDictionary = [];

        char[] vowels = ['a', 'e', 'i', 'o', 'u'];

        foreach (var c in s)
        {
            if (vowels.Contains(c))
            {
                if (!vowelDictionary.TryGetValue(c, out var count))
                {
                    vowelDictionary[c] = 1;
                }
                {
                    vowelDictionary[c] = count + 1;
                }
            }
            else
            {
                if (!consonantDictionary.TryGetValue(c, out var count))
                {
                    consonantDictionary[c] = 1;
                }
                else
                {
                    consonantDictionary[c] = count + 1;
                }
            }
        }

        int vowelMax = 0;
        int consonantMax = 0;

        foreach (var kv in vowelDictionary)
        {
            if (vowelMax < kv.Value)
            {
                vowelMax = kv.Value;
            }
        }

        foreach (var kv in consonantDictionary)
        {
            if (consonantMax < kv.Value)
            {
                consonantMax = kv.Value;
            }
        }

        return vowelMax + consonantMax;
    }
    #endregion

    #region  找出缺失的元素
    public IList<int> FindMissingElements(int[] nums)
    {
        List<int> result = [];
        HashSet<int> values = [];
        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (var num in nums)
        {
            values.Add(num);

            max = Math.Max(max, num);

            min = Math.Min(min, num);
        }

        for (int i = min; i < max; i++)
        {
            if (!values.Contains(i))
            {
                result.Add(i);
            }
        }

        return result;
    }
    #endregion

    #region 统计移除递增子数组的数目 I
    public int IncremovableSubarrayCount(int[] nums)
    {
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                bool isIncreasing = true;
                for (int left = 0; left < i - 1; left++)
                {
                    if (nums[left] >= nums[left + 1])
                    {
                        isIncreasing = false;
                        break;
                    }
                }

                if (!isIncreasing)
                    continue;

                for (int right = j + 1; right < nums.Length - 1; right++)
                {
                    if (nums[right] >= nums[right + 1])
                    {
                        isIncreasing = false;
                        break;
                    }
                }

                if (isIncreasing)
                {
                    if (i != 0 && j != nums.Length - 1 && nums[i - 1] >= nums[j + 1])
                    {
                        continue;
                    }
                    ++result;
                }
            }
        }

        return result;
    }
    #endregion

    #region 跳过交替单元格的之字形遍历
    public IList<int> ZigzagTraversal(int[][] grid)
    {
        List<int> result = [];
        int jump = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            if ((i & 1) == 0)
            {
                for (int j = 0 + jump; j < grid[i].Length; j += 2)
                {
                    result.Add(grid[i][j]);
                }
                if ((grid[i].Length & 1) == 0)
                {
                    jump = 0;
                }
                else
                {
                    jump = 1;
                }
            }
            else
            {
                for (int j = grid[i].Length - 1 - jump; j >= 0; j -= 2)
                {
                    result.Add(grid[i][j]);
                }

                jump = 0;
            }
        }

        return result;
    }
    #endregion

    #region 求出加密整数的和
    public int SumOfEncryptedInt(int[] nums)
    {
        int result = 0;

        foreach (var num in nums)
        {
            result += Encrypt(num);
        }

        return result;
    }

    public int Encrypt(int num)
    {
        int maxDigit = 0;
        int count = 0;
        int frequency = 1;

        while (num > 0)
        {
            int bit = num % 10;
            if (bit > maxDigit)
            {
                maxDigit = bit;
            }

            num /= 10;
            count += frequency;
            frequency *= 10;
        }

        return count * maxDigit;
    }
    #endregion

    #region 使数组的值全部为 K 的最少操作次数
    public int MinOperations(int[] nums, int k)
    {
        HashSet<int> values = [];

        foreach (var num in nums)
        {
            if (k > num)
            {
                return -1;
            }

            if (num > k)
            {
                values.Add(num);
            }
        }

        return values.Count;
    }
    #endregion

    #region 求出出现两次数字的 XOR 值
    public int DuplicateNumbersXOR(int[] nums)
    {
        int result = 0;

        Dictionary<int, int> kv = [];

        foreach (var num in nums)
        {
            if (kv.TryGetValue(num, out int value))
            {
                kv[num] = ++value;
            }
            else
            {
                kv[num] = 1;
            }
        }

        foreach (var sum in kv)
        {
            if (sum.Value == 2)
            {
                if (result == 0)
                {
                    result = sum.Key;
                }
                else
                {
                    result ^= sum.Key;
                }
            }
        }

        return result;
    }
    #endregion

    #region  统计元素和差值为偶数的分区方案
    public int CountPartitions(int[] nums)
    {
        int result = 0;
        int[] prevsum = new int[nums.Length];
        prevsum[0] = nums[0];
        int[] suffixsum = new int[nums.Length];
        suffixsum[0] = nums[^1];

        for (int i = 1; i < nums.Length; i++)
        {
            prevsum[i] = nums[i] + prevsum[i - 1];
        }

        for (int i = nums.Length - 2, j = 1; i >= 0; i--, j++)
        {
            suffixsum[j] = nums[i] + suffixsum[j - 1];
        }

        int length = nums.Length;
        for (int i = 0, j = length - 2; i < length - 1; i++, j--)
        {
            int sum = prevsum[i] - suffixsum[j];
            if ((sum & 1) == 0)
            {
                ++result;
            }
        }

        return result;
    }
    #endregion

    #region 矩阵中的蛇
    public int FinalPositionOfSnake(int n, IList<string> commands)
    {
        int x = 0, y = 0;

        foreach (var command in commands)
        {
            if (command == "UP" && x > 0)
            {
                x--;
            }
            else if (command == "DOWN" && x < n - 1)
            {
                x++;
            }
            else if (command == "LEFT" && y > 0)
            {
                y--;
            }
            else if (command == "RIGHT" && y < n - 1)
            {
                y++;
            }
        }

        return y + x * n;
    }
    #endregion

    #region 使数组元素互不相同所需的最少操作次数
    public int MinimumOperations(int[] nums)
    {
        int result = 0;


        HashSet<int> seen = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.Contains(nums[i]))
            {
                break;
            }
            else
            {
                seen.Add(nums[i]);
            }
        }

        return result;
    }
    #endregion

    #region 链表最大孪生和
    public int PairSum(ListNode head)
    {
        int max = int.MinValue;

        List<int> values = new List<int>();

        ListNode current = head;
        while (current != null)
        {
            values.Add(current.val);
            current = current.next;
        }

        int n = values.Count;
        for (int i = 0; i < n / 2; i++)
        {
            int pairSum = values[i] + values[n - 1 - i];
            max = Math.Max(max, pairSum);
        }

        return max;
    }
    #endregion

    #region 求出出现两次数字的 XOR 值
    // public int DuplicateNumbersXOR(int[] nums)
    // {
    //     int result = 0;
    //     Dictionary<int, int> frequency = new Dictionary<int, int>();

    //     foreach (var num in nums)
    //     {
    //         if (frequency.ContainsKey(num))
    //         {
    //             frequency[num]++;
    //         }
    //         else
    //         {
    //             frequency[num] = 1;
    //         }
    //     }

    //     foreach (var kvp in frequency)
    //     {
    //         if (kvp.Value == 2)
    //         {
    //             result ^= kvp.Key;
    //         }
    //     }

    //     return result;
    // }
    #endregion

    #region 构造最小位运算数组 I
    public int[] MinBitwiseArray(IList<int> nums)
    {
        int[] result = new int[nums.Count];
        Array.Fill(result, -1);

        for (int i = 0; i < nums.Count; i++)
        {
            for (int j = 1; j <= nums[i]; j++)
            {
                if ((j | (j + 1)) == nums[i])
                {
                    result[i] = j;
                    break;
                }
            }
        }

        return result;
    }
    #endregion

    #region 交替组 I
    public int NumberOfAlternatingGroups(int[] colors)
    {
        int sum = 0;

        for (int i = 0; i < colors.Length; i++)
        {
            int prevIndex = (i - 1 + colors.Length) % colors.Length;
            int nextIndex = (i + 1) % colors.Length;


            if (colors[i] != colors[prevIndex] && colors[i] != colors[nextIndex])
            {
                sum++;
            }
        }

        return sum;
    }
    #endregion

    #region 出现次数能被 K 整除的元素总和
    public int SumDivisibleByK(int[] nums, int k)
    {
        int sum = 0;

        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }
        }

        foreach (var kvp in frequency)
        {
            if (kvp.Value % k == 0)
            {
                sum += kvp.Key * kvp.Value;
            }
        }

        return sum;
    }
    #endregion

    #region 数位和等于下标的最小下标
    public int SmallestIndex(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (DigitSum(nums[i]) == i)
            {
                return i;
            }
        }
        return -1;
    }

    private int DigitSum(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }
    #endregion

    #region 好数字之和
    public int SumOfGoodNumbers(int[] nums, int k)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int left = i - k;
            int right = i + k;
            if ((left < 0 || nums[i] > nums[left]) && (right >= nums.Length || nums[i] > nums[right]))
            {
                sum += nums[i];
            }
        }

        return sum;
    }
    #endregion

    #region  构成整天的下标对数目 I
    public int CountCompleteDayPairs(int[] hours)
    {
        int count = 0;

        for (int i = 1; i < hours.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if ((hours[i] + hours[j]) % 24 == 0)
                {
                    count++;
                }
            }
        }

        return count;
    }
    #endregion

    #region K 次乘运算后的最终数组 I
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        for (int i = k; i > 0; i--)
        {
            int index = 0;
            int minValue = nums[0];
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] < minValue)
                {
                    minValue = nums[j];
                    index = j;
                }
            }
            nums[index] *= multiplier;
        }

        return nums;
    }
    #endregion

    #region 循环数组中相邻元素的最大差值
    public int MaxAdjacentDistance(int[] nums)
    {
        int result = Math.Max(nums[nums.Length - 1] - nums[0], nums[0] - nums[nums.Length - 1]);

        for (int i = 1; i < nums.Length; i++)
        {
            result = Math.Max(result, nums[i] - nums[i - 1]);
            result = Math.Max(result, nums[i - 1] - nums[i]);
        }

        return result;
    }
    #endregion

    #region 将数组按照奇偶性转化
    public int[] TransformArray(int[] nums)
    {
        int evenSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if ((nums[i] & 1) == 0)
            {
                evenSum++;
            }
        }

        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++, evenSum--)
        {
            if (evenSum > 0)
            {
                result[i] = 0;
            }
            else
            {
                result[i] = 1;
            }
        }

        return result;
    }
    #endregion

    #region 替换为数位和以后的最小元素

    public int MinElement(int[] nums)
    {
        int result = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            result = Math.Min(BitSum(nums[i]), result);
        }

        return result;
    }
    public int BitSum(int num)
    {
        int result = 0;

        while (num > 0)
        {
            result += num % 10;
            num /= 10;
        }

        return result;
    }
    #endregion

    #region 最小元素和最大元素的最小平均值
    public double MinimumAverage(int[] nums)
    {
        double result = double.MaxValue;

        Array.Sort(nums);
        int n = nums.Length - 1;
        int mid = n / 2;
        for (int i = 0; i <= mid; i++, n--)
        {
            double avg = (nums[i] + nums[n]) / 2.0;
            if (avg < result)
            {
                result = avg;
            }
        }

        return result;
    }
    #endregion

    #region 判断一个数是否是2的幂次数
    public bool IsPowerOfTwo(int n)
    {
        if (n < 2)
            return false;

        return (n & (n - 1)) == 0;
    }
    #endregion

    #region  优质数对的总数 I
    public int NumberOfPairs(int[] nums1, int[] nums2, int k)
    {
        int count = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] % (nums2[j] * k) == 0)
                {
                    count++;
                }
            }
        }

        return count;
    }
    #endregion

    #region 使所有元素都可以被 3 整除的最少操作数
    // public int MinimumOperations(int[] nums)
    // {
    //     int result = 0;

    //     foreach (var num in nums)
    //     {
    //         if (num % 3 != 0)
    //         {
    //             result++;
    //         }
    //     }

    //     return result;
    // }
    #endregion

    #region 3701. 计算交替和
    public int AlternatingSum(int[] nums)
    {
        int result = 0;
        bool isEvent = true;
        for (int i = 0; i < nums.Length; i++)
        {
            if (isEvent)
            {
                result += nums[i];
            }
            else
            {
                result -= nums[i];
            }
            isEvent = !isEvent;
        }

        return result;
    }
    #endregion

    #region 特殊数组 I
    public bool IsArraySpecial(int[] nums)
    {
        bool result = true;

        bool isEvent = (nums[0] & 1) == 0;

        for (int i = 1; i < nums.Length; i++)
        {
            bool currentIsEvent = (nums[i] & 1) == 0;
            if (isEvent == currentIsEvent)
            {
                return false;
            }
            isEvent = !isEvent;
        }

        return result;
    }
    #endregion

    public int ScoreOfString(string s)
    {
        int result = 0;

        for (int i = 1; i < s.Length; i++)
        {
            result += Math.Abs(s[i] - s[i - 1]);
        }

        return result;
    }

    public IList<int> StableMountains(int[] height, int threshold)
    {
        List<int> result = [];

        for (int i = 1; i < height.Length; i++)
        {
            if (height[i - 1] > threshold)
            {
                result.Add(i);
            }
        }

        return result;
    }

    // public int MinOperations(int[] nums, int k)
    // {
    //     int max = 0;

    //     foreach (var num in nums)
    //     {
    //         if (num > max)
    //         {
    //             max = num;
    //         }
    //     }

    //     return max % k;
    // }

    public int SubarraySum(int[] nums)
    {
        int result = 0;
        int n = nums.Length;
        int[] prefix = new int[n + 1];
        for (int j = 0; j < n; j++)
        {
            prefix[j + 1] = prefix[j] + nums[j];
        }

        for (int i = 0; i < n; i++)
        {
            int start = Math.Max(0, i - nums[i]);
            result += prefix[i + 1] - prefix[start];
        }

        return result;
    }

    public int[] MinCosts(int[] cost)
    {
        int[] result = new int[cost.Length];
        int minCost = int.MaxValue;
        for (int i = 0; i < cost.Length; i++)
        {
            if (cost[i] < minCost)
            {
                minCost = cost[i];
                result[i] = minCost;
            }
            else
            {
                result[i] = minCost;
            }
        }

        return result;
    }

    public int EvenNumberBitwiseORs(int[] nums)
    {
        int result = 0;
        foreach (var num in nums)
        {
            if ((num & 1) == 0)
            {
                result |= num;
            }
        }

        return result;
    }
}


namespace leetcode;

public class LeetCodeSample
{
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
    public int MinimumOperations(int[] nums)
    {
        int result = 0;

        foreach (var num in nums)
        {
            if (num % 3 != 0)
            {
                result++;
            }
        }

        return result;
    }
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

    public int MinOperations(int[] nums, int k)
    {
        int max = 0;

        foreach (var num in nums)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max % k;
    }

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

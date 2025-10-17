
namespace leetcode;

public class LeetCodeSample
{
    #region 判断一个数是否是2的幂次数
    public bool IsPowerOfTwo(int n)
    {
        if (n < 2)
            return false;

        return (n & (n - 1)) == 0;
    }
    #endregion

    #region 构成整天的下标对数目 I
    public int CountCompleteDayPairs(int[] hours)
    {
        int count = 0;

        for (int i = 1; i < hours.Length; i++)
        {
            if ((hours[i - 1] + hours[i]) % 24 == 0)
            {
                count++;
            }
        }

        return count;
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

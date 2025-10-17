
namespace leetcode;

public class LeetCodeSample
{
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
